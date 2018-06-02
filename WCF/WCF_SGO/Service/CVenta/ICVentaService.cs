using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Persistence.domain;
using Repository.CVenta;

namespace Service.CVenta
{
    public interface ICVentaService
    {
        ICollection<ComprobanteCliente> GetLisComprobanteCliente(string nroDocumentoCliente, string tipoComprobante, string correlativo);
        ICollection<ComprobanteCliente> GetLisIdComprobanteCliente(int idComprobante);
        ICollection<ComprobanteVenta> GetReporteComprobanteVenta(int idComprobante);
        ICollection<LisDatosGeneraCodigoBarra> GetLisDatosGeneraCodigoBarra(int idComprobante);
        ClienteExiste GetClienteExiste(string nroDocumento);
    }
}
