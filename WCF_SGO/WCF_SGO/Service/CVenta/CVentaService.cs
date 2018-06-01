using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Persistence.domain;
using Repository.CVenta;

namespace Service.CVenta
{
    public class CVentaService : ICVentaService
    {
        private readonly ICVentaRepository iCVentaRepository;
        public CVentaService()
        {
            iCVentaRepository = new CVentaRepository();
        }

        public ICollection<ComprobanteCliente> GetLisComprobanteCliente(string nroDocumentoCliente, string tipoComprobante, string correlativo)
        {
            return iCVentaRepository.GetLisComprobanteCliente(nroDocumentoCliente, tipoComprobante, correlativo);
        }
        public ICollection<ComprobanteCliente> GetLisIdComprobanteCliente(int idComprobante)
        {
            return iCVentaRepository.GetLisIdComprobanteCliente(idComprobante);
        }
        public ICollection<ComprobanteVenta> GetReporteComprobanteVenta(int idComprobante)
        {
            return iCVentaRepository.GetReporteComprobanteVenta(idComprobante);
        }
        public ClienteExiste GetClienteExiste(string nroDocumento)
        {
            return iCVentaRepository.GetClienteExiste(nroDocumento);
        }
        public ICollection<LisDatosGeneraCodigoBarra> GetLisDatosGeneraCodigoBarra(int idComprobante)
        {
            return iCVentaRepository.GetLisDatosGeneraCodigoBarra(idComprobante);
        }
    }//end class
}
