using System.Collections.Generic;
using System.Linq;
using Persistence.domain;

namespace Service.SGOTouch.Interace
{
    public interface ISTicketPesada
    {
        int usp_InsTicketPesada(int TipoOperacion, TICKET_PESADA oBe);
        ICollection<usp_LisTicketPesada_Result> usp_LisTicketPesada(string strEstado, string strFiltro, string strIdlocal, string strFechaIncio, string strFechaFin);
        
        ICollection<usp_ReporteTicketPesada_Result> usp_ReporteTicketPesada(string strIdTicketPesada);

    }
}
