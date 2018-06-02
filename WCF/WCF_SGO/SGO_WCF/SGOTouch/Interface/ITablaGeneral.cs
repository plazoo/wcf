using System.ServiceModel;
using Persistence.domain;
using System.Collections.Generic;

namespace SGO_WCF.SGOTouch.Services
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ITablaGeneral" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ITablaGeneral
    {
        [OperationContract]
        [ApplyDataContractResolver]
        ICollection<SelLocalIdEmpresaUsuario> usp_SelLocalIdEmpresaUsuario(string IdEmpresa, int IdUsuario);
        [OperationContract]
        [ApplyDataContractResolver]
        ICollection<usp_Mant_TIPO_COSECHA_Result> usp_Mant_TIPO_COSECHA(int bus, TIPO_COSECHA oP);
        [OperationContract]
        [ApplyDataContractResolver]
        ICollection<usp_Mant_CLIENTE_COSECHA_Result> usp_Mant_CLIENTE_COSECHA(int bus, CLIENTE_COSECHA oP);
        [OperationContract]
        [ApplyDataContractResolver]
        ICollection<usp_LisTipoCafe_Result> usp_LisTipoCafe(string strEstado);
        [OperationContract]
        [ApplyDataContractResolver]
        ICollection<usp_LisComboSacoCafe_Result> usp_LisComboSacoCafe(string strEstado);
        [OperationContract]
        [ApplyDataContractResolver]
        ICollection<usp_LisLaboratorioDisponibleXCliente_Result> usp_LisLaboratorioDisponibleXCliente(int inIdCliente, string strIdLocal);
        [OperationContract]
        [ApplyDataContractResolver]
        ICollection<usp_LisTipoRuma_Result> usp_LisTipoRuma(string strIdLocal, string strIdEstado);
        [OperationContract]
        [ApplyDataContractResolver]
        ICollection<usp_LisBusquedaClienteFiltro_Result> usp_LisBusquedaClienteFiltro(string strFiltro);
        [OperationContract]
        [ApplyDataContractResolver]
        ICollection<usp_LisContratoConGI_Result> usp_LisContratoConGI(int inIdCliente, int inCosecha);
    }
}
