using System.Collections.Generic;
using Persistence.domain;
//using Persistence.DBContext;

namespace Repository.SGOTouch
{
    public interface IRTicketPesada
    {
        int usp_InsTicketPesada(int TipoOperacion, TICKET_PESADA oBe);
        ICollection<usp_LisTicketPesada_Result> usp_LisTicketPesada(string strEstado, string strFiltro, string strIdlocal, string strFechaIncio, string strFechaFin);
        ICollection<usp_ReporteTicketPesada_Result> usp_ReporteTicketPesada(string strIdTicketPesada);
    }
    
}
