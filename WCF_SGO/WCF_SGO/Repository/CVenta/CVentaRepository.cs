using System.Collections.Generic;
using System.Linq;

using Persistence.domain;


namespace Repository.CVenta
{
    public class CVentaRepository : ICVentaRepository
    {
        public ICollection<ComprobanteCliente> GetLisComprobanteCliente(string nroDocumentoCliente, string tipoComprobante, string correlativo)
        {
            using (var db = new ApplicationDbContextSGO())
            {
                var response = db.usp_LisComprobanteCliente(nroDocumentoCliente, tipoComprobante, correlativo).ToList();
                return response;
            }
        }
        public ICollection<ComprobanteCliente> GetLisIdComprobanteCliente(int idComprobante)
        {
            using (var db = new ApplicationDbContextSGO())
            {
                var response = db.usp_LisIdComprobanteCliente(idComprobante).ToList();
                return response;
            }
        }
        public ICollection<ComprobanteVenta> GetReporteComprobanteVenta(int idComprobante)
        {
            using (var db = new ApplicationDbContextSGO())
            {
                var response = db.usp_ReporteComprobanteVenta(idComprobante).ToList();
                return response;
            }
        }
        public ClienteExiste GetClienteExiste(string nroDocumento)
        {
            using (var db = new ApplicationDbContextSGO())
            {
                var response = db.usp_LisClienteExiste(nroDocumento).ToList();
                return response.SingleOrDefault();
            }
        }
        public ICollection<LisDatosGeneraCodigoBarra> GetLisDatosGeneraCodigoBarra(int idComprobante)
        {
            using (var db = new ApplicationDbContextSGO())
            {
                var response = db.usp_LisDatosGeneraCodigoBarra(idComprobante).ToList();
                return response;
            }
        }
    }//end class
}
