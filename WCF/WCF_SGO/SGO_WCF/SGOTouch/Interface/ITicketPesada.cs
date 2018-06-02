using Persistence.domain;
using System.Collections.Generic;
using System.ServiceModel;

namespace SGO_WCF.SGOTouch
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ITicketPesada" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ITicketPesada
    {
        [OperationContract]
        [ApplyDataContractResolver]
        IList<ComprobanteCliente> GetComp();
        [OperationContract]
        [ApplyDataContractResolver]
        int usp_InsTicketPesada(int TipoOperacion, TICKET_PESADA oBe);
        [OperationContract]
        [ApplyDataContractResolver]
        ICollection<usp_LisTicketPesada_Result> usp_LisTicketPesada(string strEstado, string strFiltro, string strIdlocal, string strFechaIncio, string strFechaFin);
        

        [OperationContract]
        [ApplyDataContractResolver]
        ICollection<usp_ReporteTicketPesada_Result> usp_ReporteTicketPesada(string strIdTicketPesada);

    }
}
