using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistence.domain;
using System.Data.SqlClient;

namespace Repository.SGOTouch
{
    public class RTicketPesada : IRTicketPesada
    {
     
        public int usp_InsTicketPesada(int TipoOperacion, TICKET_PESADA oTP)
        {
            using (var db = new ApplicationDbContextSGO())
            {
                var response = db.usp_InsTicketPesada(TipoOperacion,oTP.IdTicketPesada,oTP.Cosecha,oTP.IdCliente,oTP.IdContactoCliente,oTP.IdLocal,
                    oTP.FechaTicket.ToString(),oTP.IdLaboratorio,oTP.NroSaco,oTP.IdSaco,oTP.PesoSaco,oTP.Tara,oTP.KgBruto,oTP.KgNeto,oTP.DsctoAgua,oTP.KgSeco,
                    oTP.IdProceso,oTP.Observaciones,oTP.IdEstado,oTP.UsuarioRegistro,oTP.IdTipoCafe,oTP.IdGuiaRemision,oTP.GuiaRemision);
                return response;
                //return null;
            }
        }


        public ICollection<usp_LisTicketPesada_Result> usp_LisTicketPesada(string strEstado, string strFiltro, string strIdlocal, string strFechaIncio, string strFechaFin)
        {
            using (var db = new ApplicationDbContextSGO())
            {
                var response = db.usp_LisTicketPesada(strEstado, strFiltro, strIdlocal, strFechaIncio, strFechaFin).ToList();
                return response;
            }
        }


        public ICollection<usp_ReporteTicketPesada_Result> usp_ReporteTicketPesada(string strIdTicketPesada)
        {
            using (var db = new ApplicationDbContextSGO())
            {
                var response = db.usp_ReporteTicketPesada(Convert.ToInt32(strIdTicketPesada)).ToList();
                return response;
            }
        }
    }
}
