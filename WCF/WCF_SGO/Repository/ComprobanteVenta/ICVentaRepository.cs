using System.Collections.Generic;

using Persistence.domain;

namespace Repository.ComprobanteVenta
{
    public interface IComprobanteVentaRepository
    {
        ICollection<usp_LisComprobanteCliente_Result> usp_LisComprobanteCliente_Result(string nroDocumentoCliente);
    }
}
