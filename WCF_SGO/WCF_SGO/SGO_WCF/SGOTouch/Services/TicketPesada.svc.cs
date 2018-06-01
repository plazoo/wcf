using Persistence.domain;
using Service.SGOTouch.Interace;
using System;
using System.Collections.Generic;
using System.Linq;
using Service;
using Service.SGOTouch.Clases;

namespace SGO_WCF.SGOTouch
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "TicketPesada" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione TicketPesada.svc o TicketPesada.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class TicketPesada : ITicketPesada
    {
        private readonly ISTicketPesada iSTicketPesada;
        private readonly ILogService iLogService;
        public TicketPesada()
        {
            iSTicketPesada = new STicketPesada();
            iLogService = new LogService();
        }
        public IList<ComprobanteCliente> GetComp()
        {
            return new List<ComprobanteCliente>();
        }

        public int usp_InsTicketPesada(int TipoOperacion, TICKET_PESADA oBe)
        {
            int inResponse = 0;
            try
            {
                inResponse= iSTicketPesada.usp_InsTicketPesada(TipoOperacion, oBe);
            }
            catch (Exception ex)
            {
                iLogService.SetLog(string.Concat("WPF => usp_LisTicketPesada | ", ex.Message, " | ", ex.Source.ToString(), " | ", ex.StackTrace.ToString()), null);

            }
            return inResponse;
        }



        public ICollection<usp_LisTicketPesada_Result> usp_LisTicketPesada(string strEstado, string strFiltro, string strIdlocal, string strFechaIncio, string strFechaFin)
        {
            ICollection<usp_LisTicketPesada_Result> retorno = new List<usp_LisTicketPesada_Result>();

            try
            {
                retorno = iSTicketPesada.usp_LisTicketPesada(strEstado, strFiltro, strIdlocal, strFechaIncio, strFechaFin);
            }
            catch (Exception ex)
            {
                iLogService.SetLog(string.Concat("WPF => usp_LisTicketPesada | ", ex.Message, " | ", ex.Source.ToString(), " | ", ex.StackTrace.ToString()), null);
            }
            return retorno; 
        }


        public ICollection<usp_ReporteTicketPesada_Result> usp_ReporteTicketPesada(string strIdTicketPesada)
        {
            ICollection<usp_ReporteTicketPesada_Result> retorno = new List<usp_ReporteTicketPesada_Result>();
            try
            {
                retorno = iSTicketPesada.usp_ReporteTicketPesada(strIdTicketPesada);
            }
            catch (Exception ex)
            {
                iLogService.SetLog(string.Concat("WPF => usp_ReporteTicketPesada | ", ex.Message, " | ", ex.Source.ToString(), " | ", ex.StackTrace.ToString()), null);
            }
            return retorno;
        }
    }
}
