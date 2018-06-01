using System.Collections.Generic;

using Persistence.domain;

namespace Repository.CVenta
{
    public interface ICVentaRepository
    {
        ICollection<ComprobanteCliente> GetLisComprobanteCliente(string nroDocumentoCliente, string tipoComprobante, string correlativo);
        ICollection<ComprobanteCliente> GetLisIdComprobanteCliente(int idComprobante);
        ICollection<ComprobanteVenta> GetReporteComprobanteVenta(int idComprobante);
        ICollection<LisDatosGeneraCodigoBarra> GetLisDatosGeneraCodigoBarra(int idComprobante);
        ClienteExiste GetClienteExiste(string nroDocumento);
    }
}
