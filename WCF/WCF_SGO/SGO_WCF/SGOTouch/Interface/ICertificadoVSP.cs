using Persistence.domain;
using System.Collections.Generic;
using System.ServiceModel;

namespace SGO_WCF.SGOTouch.Interface
{
    [ServiceContract]
    public interface ICertificadoVSP
    {
        [OperationContract]
        [ApplyDataContractResolver]
        ICollection<usp_LisSaldoCertificado_Result> usp_LisSaldoCertificado(int IdCliente, string strCosecha);
    }
}
