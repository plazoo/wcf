using Persistence.domain;
using System.Collections.Generic;
using System.ServiceModel;


namespace SGO_WCF.SGOTouch.Services
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IGuiaIngresoZona" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IGuiaIngresoZona
    {
       
        [OperationContract]
        [ApplyDataContractResolver]
        ICollection<usp_LisGuiaIngresoZona_Result> usp_LisGuiaIngresoZona(string strEstado, string strFiltro, string strIdlocal, string strFechaInicio, string strFechaFin);


        [OperationContract]
        [ApplyDataContractResolver]
        ICollection<usp_LisDatoGuiaIngresoZona_Result> usp_LisDatoGuiaIngresoZona(int inIdGuiaIngreso);
        [OperationContract]
        [ApplyDataContractResolver]
        ICollection<usp_ReporteGuiaIngreso_Result> usp_ReporteGuiaIngreso(string strIdGuiaIngreso);
        [OperationContract]
        [ApplyDataContractResolver]
        ICollection<usp_LisGuiaIngresoEditar_Result> usp_LisGuiaIngresoEditar(int inIdGuia);
        [OperationContract]
        [ApplyDataContractResolver]
        ICollection<usp_ListadoDetalleRemision_Result> usp_ListadoDetalleRemision(int inIdTraslado);
        [OperationContract]
        [ApplyDataContractResolver]
        List<usp_LisGuiaIngresoDetalle_Result> usp_LisGuiaIngresoDetalle(int inIdGuia);
        [OperationContract]
        [ApplyDataContractResolver]
        ICollection<usp_ListIngresoSaldo_Result> usp_ListIngresoSaldo(int IdGuia);
        [OperationContract]
        [ApplyDataContractResolver]
        ICollection<usp_LisRecepcionGuiaRemisionZona_Result> usp_LisRecepcionGuiaRemisionZona(string strIdlocal);

        [OperationContract]
        [ApplyDataContractResolver]
        int InsertarGuiaIngresoCompleto(int inTipoOperacion, string oGIC, string oSLstDJson, string oLstGIS);

        [OperationContract]
        [ApplyDataContractResolver]
        GUIA_INGRESO_CAB ECab();

        [OperationContract]
        [ApplyDataContractResolver]
        GUIA_INGRESO_DET EDet();

        [OperationContract]
        [ApplyDataContractResolver]
        GUIA_INGRESO_SALDO ESaldo();
    }
}
