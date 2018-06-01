using System.Collections.Generic;
using Persistence.domain;
using System.ServiceModel;

namespace SGO_WCF.SGOTouch.Interface
{
    [ServiceContract]
    public interface ICliente
    {
        [OperationContract]
        [ApplyDataContractResolver]
        ICollection<LisClienteContacto> usp_LisClienteContacto(int? inIdCliente, string strEstado);
    }
}
