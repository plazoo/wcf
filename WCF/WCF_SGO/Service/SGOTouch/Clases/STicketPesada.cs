using Service.SGOTouch.Interace;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;
using Persistence.domain;
using System;
using Repository.SGOTouch;

namespace Service.SGOTouch.Clases
{
    public class STicketPesada : ISTicketPesada
    {
        private readonly IRTicketPesada iRTicketPesada;
        public STicketPesada()
        {
            iRTicketPesada = new RTicketPesada();
        }

        public int usp_InsTicketPesada(int TipoOperacion, TICKET_PESADA oBe)
        {
            return iRTicketPesada.usp_InsTicketPesada(TipoOperacion,oBe);
        }


        public ICollection<usp_LisTicketPesada_Result> usp_LisTicketPesada(string strEstado, string strFiltro, string strIdlocal, string strFechaIncio, string strFechaFin)
        {
            return iRTicketPesada.usp_LisTicketPesada(strEstado, strFiltro, strIdlocal, strFechaIncio, strFechaFin);
        }

        public ICollection<usp_ReporteTicketPesada_Result> usp_ReporteTicketPesada(string strIdTicketPesada)
        {
            return iRTicketPesada.usp_ReporteTicketPesada(strIdTicketPesada);
        }
    }
}
