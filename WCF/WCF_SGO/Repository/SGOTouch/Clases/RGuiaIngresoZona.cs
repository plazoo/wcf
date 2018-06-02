using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistence.domain;
using System.Transactions;
using Newtonsoft.Json;


namespace Repository.SGOTouch
{
    
    public class RGuiaIngresoZona : IRGuiaIngresoZona
    {
        

        public int InsertarGuiaIngresoCompleto(
                                                int inTipoOperacion, 
                                                //GUIA_INGRESO_CAB oGIC,
                                                string oSGICJson,
                                                string oSLstDJson, 
                                                string oSLstSJson)
        {
            int inCountDetalle = 0;
            int inCountSaldo = 0;
            int inReturn= 0;

            var oSLstDDesJson = JsonConvert.DeserializeObject<List<GUIA_INGRESO_DET>>(oSLstDJson);
            var oSlstSDesJson = JsonConvert.DeserializeObject<List<GUIA_INGRESO_SALDO>>(oSLstSJson);
            var oSGICDesJson=  JsonConvert.DeserializeObject<GUIA_INGRESO_CAB>(oSGICJson);

         

            using (TransactionScope scope = new TransactionScope())
            {
                using (var db = new ApplicationDbContextSGO())
                {
                    var responseC1 = 0;
                    try
                    {
                        var responseC = (
                            db.usp_InsGuiaIngresoCabecera(
                                inTipoOperacion,
                                oSGICDesJson.IdGuia,
                                oSGICDesJson.IdLocal,
                                oSGICDesJson.IdCliente,
                                oSGICDesJson.IdContactoCliente,
                                oSGICDesJson.RumaDestino,
                                oSGICDesJson.TotalSaco,
                                oSGICDesJson.TotalKgBruto,
                                oSGICDesJson.TotalTara,
                                oSGICDesJson.TotalDsctoAgua,
                                oSGICDesJson.TotalKgNeto,
                                oSGICDesJson.IdEstado,
                                oSGICDesJson.IdDivision,
                                oSGICDesJson.IdProceso,
                                oSGICDesJson.UsuarioRegistro,
                                oSGICDesJson.IdCertificadoVSP,
                                oSGICDesJson.DescCertificacion,
                                oSGICDesJson.ModalidadIngreso,
                                oSGICDesJson.IdIngresoPRP,
                                oSGICDesJson.IdOficinaOrigen,
                                oSGICDesJson.IdTraslado,
                                oSGICDesJson.GuiaRemisionExterna,
                                oSGICDesJson.IdClienteTrazabilidad,
                                oSGICDesJson.IdTrasladoFila,
                                oSGICDesJson.IdTipoCafe,
                                oSGICDesJson.Observacion,
                                oSGICDesJson.IdContrato, /*null,*/
                                oSGICDesJson.Cosecha.ToString()
                            )
                        );
                        responseC1 = Convert.ToInt32(responseC.FirstOrDefault());


                        var returIdGuia = responseC1; //Convert.ToInt32(responseC1.FirstOrDefault());

                        foreach (var item in oSLstDDesJson)
                        {

                            var responseD = (db.usp_InsGuiaIngresoDetalle(
                                        returIdGuia,
                                        item.IdTicketPesada,
                                        item.IdOrdenServicio,
                                        item.IdResultado,
                                        item.NroSaco,
                                        item.KgBruto,
                                        item.Tara,
                                        item.KgNeto
                                    )
                                );


                            if (responseD > 0) inCountDetalle++;
                        }

                        foreach (var item in oSlstSDesJson)
                        {
                            var responseS = (db.usp_InsGuiaIngresoSaldo(
                                        returIdGuia,
                                        item.IdTicketPesada,
                                        item.IdCliente,
                                        item.Cosecha,
                                        item.Saco,
                                        item.KgBruto,
                                        item.Tara,
                                        item.KgNeto,
                                        item.SacoOperacion,
                                        item.KgBrutoOperacion,
                                        item.TaraOperacion,
                                        item.KgNetoOperacion,
                                        item.SacoSaldo,
                                        item.KgBrutoSaldo,
                                        item.TaraSaldo,
                                        item.KgNetoSaldo,
                                        item.IdEstado,
                                        item.UsuarioRegistro
                                    )
                                );
                            if (responseS > 0) inCountSaldo++;

                        }

                        try
                        {

                            if (inTipoOperacion == 1 &&
                                (oSGICDesJson.ModalidadIngreso == "CON" || oSGICDesJson.ModalidadIngreso == "CER") &&
                                oSGICDesJson.IdProceso == 0)
                            {
                                string idCertificados =
                                    (oSGICDesJson.IdCertificadoVSP.Substring(0,
                                        oSGICDesJson.IdCertificadoVSP.Length - 1))
                                    .Replace('|', ',');
                                /* ∟ El formato que acepta el store es 2,3,4,5 =>  2|3|4|5| -> 2,3,4,5 */

                                var responseCer = db.usp_InsSaldoCertificado(
                                    returIdGuia.ToString(),
                                    oSGICDesJson.IdCliente.ToString(),
                                    oSGICDesJson.Cosecha.ToString(),
                                    oSGICDesJson.TotalKgNeto.ToString(),
                                    idCertificados,
                                    "GI"
                                );
                            }

                        }
                        catch (Exception ex)
                        {
                            db.usp_INS_TBL_LOG(
                                string.Concat("WPF => R InsertarGuiaIngresoCompleto  usp_InsSaldoCertificado |  ",
                                    ex.Message, " | ", ex.Source.ToString(), " | ", ex.StackTrace.ToString()),
                                Convert.ToInt32(oSGICDesJson.UsuarioRegistro));

                        }



                        var responseH = db.usp_UpdGuiaIngresoRendHumZona(Convert.ToInt32(returIdGuia));

                        if (inCountDetalle == oSLstDDesJson.Count && inCountSaldo == oSlstSDesJson.Count &&
                            responseH > 0)
                        {
                            scope.Complete();
                            inReturn = 1;
                        }
                        else if (inTipoOperacion == 2)
                        {
                            scope.Complete();
                            inReturn = 1;
                        }
                        else
                        {
                            inReturn = 0;
                        }
                    }


                    catch (Exception ex)
                    {
                        db.usp_INS_TBL_LOG(
                            string.Concat("WPF => R InsertarGuiaIngresoCompleto |  ",
                                ex.Message, " | ", ex.Source.ToString(), " | ", ex.StackTrace.ToString()),
                            Convert.ToInt32(oSGICDesJson.UsuarioRegistro));

                    }
                }

                return inReturn;
            }
        }


//        public int ScopesComplete()
//        {
//            int ScopesReturn = 0;
//            if(returnInsCabecera > 0 && returnInsDetalle > 0 && returnInsSaldo > 0 &&  returnRendHumZona > 0)
//            {
////                scopeInsCabecera.Complete();
//                scopeInsDetalle.Complete();
//                scopeInsSaldo.Complete();
//                scopeSaldoCert.Complete();
//                scopeRendHumZona.Complete();
//                ScopesReturn = 1;
//            }
//            return ScopesReturn;
//        }       
                
                
        public ICollection<usp_LisDatoGuiaIngresoZona_Result> usp_LisDatoGuiaIngresoZona(int inIdGuiaIngreso)
        {
            using (var db = new ApplicationDbContextSGO())
            {
                var response = db.usp_LisDatoGuiaIngresoZona(inIdGuiaIngreso.ToString()).ToList();
                return response;                
            }
        }

        public List<usp_LisGuiaIngresoDetalle_Result> usp_LisGuiaIngresoDetalle(int inIdGuia)
        {
            using (var db = new ApplicationDbContextSGO())
            {
                var response = db.usp_LisGuiaIngresoDetalle(inIdGuia).ToList();
                return response;
            }
        }

        public ICollection<usp_LisGuiaIngresoEditar_Result> usp_LisGuiaIngresoEditar(int inIdGuia)
        {
            using (var db = new ApplicationDbContextSGO())
            {
                var response = db.usp_LisGuiaIngresoEditar(inIdGuia).ToList();
                return response;
                
            }
        }
        
        public ICollection<usp_LisGuiaIngresoZona_Result> usp_LisGuiaIngresoZona( string strEstado, string strFiltro, string strIdlocal, string strFechaInicio, string strFechaFin)
        {
            using (var db = new ApplicationDbContextSGO())
            {
                var response = db.usp_LisGuiaIngresoZona( strEstado,  strFiltro, strIdlocal, strFechaInicio,  strFechaFin).ToList();
                return response;
            }
        }

        public ICollection<usp_ListadoDetalleRemision_Result> usp_ListadoDetalleRemision(int inIdTraslado)
        {
            using (var db = new ApplicationDbContextSGO())
            {
                var response = db.usp_ListadoDetalleRemision(inIdTraslado).ToList();
                return response;
            }
        }

        public ICollection<usp_ReporteGuiaIngreso_Result> usp_ReporteGuiaIngreso(string strIdGuiaIngreso)
        {
            using (var db = new ApplicationDbContextSGO())
            {
                var response = db.usp_ReporteGuiaIngreso(Convert.ToInt32(strIdGuiaIngreso)).ToList();
                return response;
                
            }
        }


        
        public ICollection<usp_ListIngresoSaldo_Result> usp_ListIngresoSaldo(int IdGuia)
        {
            using (var db = new ApplicationDbContextSGO())
            {
                var response = (db.usp_ListIngresoSaldo(IdGuia)).ToList();
                return response;
            }
        }

        public ICollection<usp_LisRecepcionGuiaRemisionZona_Result> usp_LisRecepcionGuiaRemisionZona(string strIdlocal)
        {
            using (var db = new ApplicationDbContextSGO())
            {
                var response = db.usp_LisRecepcionGuiaRemisionZona(strIdlocal).ToList();
                return response;
            }
        }


    }
}
