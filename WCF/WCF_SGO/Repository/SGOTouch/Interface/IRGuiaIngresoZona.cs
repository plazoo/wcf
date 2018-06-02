
using System.Collections.Generic;
using Persistence.domain;
using System.Data;

namespace Repository.SGOTouch
{
    public interface IRGuiaIngresoZona
    {

        ICollection<usp_LisGuiaIngresoZona_Result> usp_LisGuiaIngresoZona(string strEstado, string strFiltro, string strIdlocal, string strFechaInicio, string strFechaFin);
        ICollection<usp_LisDatoGuiaIngresoZona_Result> usp_LisDatoGuiaIngresoZona(int inIdGuiaIngreso);
        ICollection<usp_ReporteGuiaIngreso_Result> usp_ReporteGuiaIngreso(string strIdGuiaIngreso);
        ICollection<usp_LisGuiaIngresoEditar_Result> usp_LisGuiaIngresoEditar(int inIdGuia);
        ICollection<usp_ListadoDetalleRemision_Result> usp_ListadoDetalleRemision(int inIdTraslado);
        List<usp_LisGuiaIngresoDetalle_Result> usp_LisGuiaIngresoDetalle(int inIdGuia);
        ICollection<usp_ListIngresoSaldo_Result> usp_ListIngresoSaldo(int IdGuia);
        ICollection<usp_LisRecepcionGuiaRemisionZona_Result> usp_LisRecepcionGuiaRemisionZona(string strIdlocal);
        
        int InsertarGuiaIngresoCompleto(
                                        int inTipoOperacion, 
                                        //GUIA_INGRESO_CAB oGIC,
                                        string oSGICJson,
                                        string oSLstDJson, 
                                        string oSLstSJson
                                        );
    }
}
