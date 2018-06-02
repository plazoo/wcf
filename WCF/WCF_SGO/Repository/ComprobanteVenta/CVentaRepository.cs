using System.Collections.Generic;
using System.Linq;

using Persistence.domain;


namespace Repository.ComprobanteVenta
{
    public class ComprobanteVentaRepository:IComprobanteVentaRepository
    {
        public ICollection<usp_LisComprobanteCliente_Result> usp_LisComprobanteCliente_Result(string nroDocumentoCliente)
        {
            using(var db = new SGOEntities())
            {
                var response = db.usp_LisComprobanteCliente(nroDocumentoCliente).ToList();
                return response;
            }
        }
    }
}
