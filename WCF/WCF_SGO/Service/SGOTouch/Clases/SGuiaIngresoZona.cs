using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistence.domain;
using Service.SGOTouch.Interace;
using Repository.SGOTouch;

namespace Service.SGOTouch.Clases
{
    public class SGuiaIngresoZona : ISGuiaIngresoZona
    {
        private readonly IRGuiaIngresoZona iRGuiaIngresoZona;
        public SGuiaIngresoZona()
        {
            iRGuiaIngresoZona = new RGuiaIngresoZona();
        }

        public ICollection<usp_LisDatoGuiaIngresoZona_Result> usp_LisDatoGuiaIngresoZona(int inIdGuiaIngreso)
        {
            return iRGuiaIngresoZona.usp_LisDatoGuiaIngresoZona(inIdGuiaIngreso);
        }

        public List<usp_LisGuiaIngresoDetalle_Result> usp_LisGuiaIngresoDetalle(int inIdGuia)
        {
            return iRGuiaIngresoZona.usp_LisGuiaIngresoDetalle(inIdGuia);
        }

        public ICollection<usp_LisGuiaIngresoEditar_Result> usp_LisGuiaIngresoEditar(int inIdGuia)
        {
            return iRGuiaIngresoZona.usp_LisGuiaIngresoEditar(inIdGuia);
        }

        public ICollection<usp_LisGuiaIngresoZona_Result> usp_LisGuiaIngresoZona(string strEstado, string strFiltro, string strIdlocal, string strFechaInicio, string strFechaFin)
        {
            return iRGuiaIngresoZona.usp_LisGuiaIngresoZona( strEstado, strFiltro, strIdlocal, strFechaInicio,  strFechaFin);
        }

        public ICollection<usp_ListadoDetalleRemision_Result> usp_ListadoDetalleRemision(int inIdTraslado)
        {
            return iRGuiaIngresoZona.usp_ListadoDetalleRemision(inIdTraslado);
        }

        public ICollection<usp_ReporteGuiaIngreso_Result> usp_ReporteGuiaIngreso(string strIdGuiaIngreso)
        {
            return iRGuiaIngresoZona.usp_ReporteGuiaIngreso(strIdGuiaIngreso);
        }


        public ICollection<usp_ListIngresoSaldo_Result> usp_ListIngresoSaldo(int IdGuia)
        {
            return iRGuiaIngresoZona.usp_ListIngresoSaldo(IdGuia);
            
        }

        public ICollection<usp_LisRecepcionGuiaRemisionZona_Result> usp_LisRecepcionGuiaRemisionZona(string strIdlocal)
        {
            return iRGuiaIngresoZona.usp_LisRecepcionGuiaRemisionZona(strIdlocal);
        }

        public int InsertarGuiaIngresoCompleto(int inTipoOperacion, string oGIC, string oSLstDJson, string oLstGIS)
        {
            return iRGuiaIngresoZona.InsertarGuiaIngresoCompleto(inTipoOperacion,oGIC, oSLstDJson, oLstGIS);
        }
    }
}
