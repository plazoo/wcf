using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using Persistence.domain;
using Service.CVenta;
using Common;
namespace SGO_WCF.CVenta
{
    [ServiceContract]
    public interface IServiceCVenta
    {
        [OperationContract]
        [ApplyDataContractResolver]
        Result GetComprobante(int idComprobante);
        [OperationContract]
        [ApplyDataContractResolver]
        IList<ComprobanteCliente> GetLisComprobanteCliente(string nroDocumentoCliente, string tipoComprobante, string correlativo);
        //[OperationContract]
        //[ApplyDataContractResolver]
        //ClienteExiste GetClienteExiste(string nroDocumento);
    }
}
