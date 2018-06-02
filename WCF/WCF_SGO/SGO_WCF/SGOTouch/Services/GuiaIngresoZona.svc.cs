using System;
using System.Collections.Generic;
using System.Linq;
using Persistence.domain;
using Service;
using Service.SGOTouch.Interace;
using Service.SGOTouch.Clases;

namespace SGO_WCF.SGOTouch.Services
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "GuiaIngresoZona" en el código, en svc y en el archivo de configuración a la vez.
    
    public class GuiaIngresoZona : IGuiaIngresoZona
    {
        private readonly ISGuiaIngresoZona _iSGuiaIngresoZona;
        private readonly ILogService iLogService;
        public GuiaIngresoZona()
        {
            _iSGuiaIngresoZona = new SGuiaIngresoZona();
            iLogService = new LogService();

        }


        public ICollection<usp_LisDatoGuiaIngresoZona_Result> usp_LisDatoGuiaIngresoZona(int inIdGuiaIngreso)
        {
            ICollection<usp_LisDatoGuiaIngresoZona_Result> retorno = new List<usp_LisDatoGuiaIngresoZona_Result>();

            try
            {
               retorno= _iSGuiaIngresoZona.usp_LisDatoGuiaIngresoZona(inIdGuiaIngreso);
            }
            catch (Exception ex)
            {
                iLogService.SetLog(string.Concat("WPF => usp_LisDatoGuiaIngresoZona | ", ex.Message, " | ", ex.Source.ToString(), " | ", ex.StackTrace.ToString()), null);
            }

            return retorno;
        }

        public List<usp_LisGuiaIngresoDetalle_Result> usp_LisGuiaIngresoDetalle(int inIdGuia)
        {
            List<usp_LisGuiaIngresoDetalle_Result> retorno = new List<usp_LisGuiaIngresoDetalle_Result>();

            try
            {
                retorno=_iSGuiaIngresoZona.usp_LisGuiaIngresoDetalle(inIdGuia);
            }
            catch (Exception ex)
            {
                iLogService.SetLog(string.Concat("WPF => usp_LisGuiaIngresoDetalle | ", ex.Message, " | ", ex.Source.ToString(), " | ", ex.StackTrace.ToString()), null);
            }

            return retorno;
        }

        public ICollection<usp_LisGuiaIngresoEditar_Result> usp_LisGuiaIngresoEditar(int inIdGuia)
        {
            ICollection<usp_LisGuiaIngresoEditar_Result> retorno = new List<usp_LisGuiaIngresoEditar_Result>();

            try
            {
                retorno= _iSGuiaIngresoZona.usp_LisGuiaIngresoEditar(inIdGuia);
            }
            catch (Exception ex)
            {
                iLogService.SetLog(string.Concat("WPF => usp_LisGuiaIngresoEditar | ", ex.Message, " | ", ex.Source.ToString(), " | ", ex.StackTrace.ToString()), null);
            }

            return retorno;
        }

        public ICollection<usp_LisGuiaIngresoZona_Result> usp_LisGuiaIngresoZona(string strEstado, string strFiltro,
            string strIdlocal, string strFechaInicio, string strFechaFin)
        {
            ICollection<usp_LisGuiaIngresoZona_Result> retorno = new List<usp_LisGuiaIngresoZona_Result>();

            try
            {
                retorno= _iSGuiaIngresoZona.usp_LisGuiaIngresoZona(strEstado, strFiltro, strIdlocal, strFechaInicio, strFechaFin);
            }
            catch (Exception ex)
            {
                iLogService.SetLog(string.Concat("WPF => usp_LisGuiaIngresoZona | ", ex.Message, " | ", ex.Source.ToString(), " | ", ex.StackTrace.ToString()), null);
            }

            return retorno;
        }

        public ICollection<usp_ListadoDetalleRemision_Result> usp_ListadoDetalleRemision(int inIdTraslado)
        {
            
            ICollection<usp_ListadoDetalleRemision_Result> retorno = new List<usp_ListadoDetalleRemision_Result>();

            try
            {
                retorno = _iSGuiaIngresoZona.usp_ListadoDetalleRemision(inIdTraslado);
            }
            catch (Exception ex)
            {
                iLogService.SetLog(string.Concat("WPF => usp_ListadoDetalleRemision | ", ex.Message, " | ", ex.Source.ToString(), " | ", ex.StackTrace.ToString()), null);
            }

            return retorno;
        }

        public ICollection<usp_ReporteGuiaIngreso_Result> usp_ReporteGuiaIngreso(string strIdGuiaIngreso)
        {
            ICollection<usp_ReporteGuiaIngreso_Result> retorno = new List<usp_ReporteGuiaIngreso_Result>();

            try
            {
                retorno= _iSGuiaIngresoZona.usp_ReporteGuiaIngreso(strIdGuiaIngreso);
            }
            catch (Exception ex)
            {
                iLogService.SetLog(string.Concat("WPF => usp_ReporteGuiaIngreso | ", ex.Message, " | ", ex.Source.ToString(), " | ", ex.StackTrace.ToString()), null);
            }

            return retorno;
        } 
        

        public ICollection<usp_ListIngresoSaldo_Result> usp_ListIngresoSaldo(int IdGuia)
        {
            ICollection<usp_ListIngresoSaldo_Result> retorno= new List<usp_ListIngresoSaldo_Result>();
            try
            {
                retorno = _iSGuiaIngresoZona.usp_ListIngresoSaldo(IdGuia);

            }
            catch (Exception ex)
            {
                iLogService.SetLog(string.Concat("WPF => usp_ListIngresoSaldo | ", ex.Message, " | ", ex.Source.ToString(), " | ", ex.StackTrace.ToString()), null);
            }

            return retorno;
        }
        

        public ICollection<usp_LisRecepcionGuiaRemisionZona_Result> usp_LisRecepcionGuiaRemisionZona(string strIdlocal)
        {
            ICollection<usp_LisRecepcionGuiaRemisionZona_Result> returnL = new List<usp_LisRecepcionGuiaRemisionZona_Result>();
            try
            {
                returnL = _iSGuiaIngresoZona.usp_LisRecepcionGuiaRemisionZona(strIdlocal).ToList();
            }
            catch (Exception ex)
            {
                iLogService.SetLog(string.Concat("WPF => usp_LisRecepcionGuiaRemisionZona | ", ex.Message, " | ", ex.Source.ToString(), " | ", ex.StackTrace.ToString()), null);
            }

            return returnL;
        } 

        public int InsertarGuiaIngresoCompleto(int inTipoOperacion, string oGIC, string oSLstDJson, string oLstGIS)
        {
            int inResponse = 0;
            try
            {
                inResponse = _iSGuiaIngresoZona.InsertarGuiaIngresoCompleto(inTipoOperacion, oGIC, oSLstDJson, oLstGIS);
            }
            catch (Exception ex)
            {
                iLogService.SetLog(string.Concat("WPF => InsertarGuiaIngresoCompleto | ", ex.Message, " | ", ex.Source.ToString(), " | ", ex.StackTrace.ToString()), null);
            }

            return inResponse;
        }

        

        public GUIA_INGRESO_CAB ECab()
        {
            throw new NotImplementedException();
        }

        public GUIA_INGRESO_DET EDet()
        {
            throw new NotImplementedException();
        }

        public GUIA_INGRESO_SALDO ESaldo()
        {
            throw new NotImplementedException();
        }
    }
}

