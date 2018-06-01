using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Persistence.domain;
using Service.SGOTouch.Interace;
using Service.SGOTouch.Clases;
using Service;

namespace SGO_WCF.SGOTouch.Services
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "SolicitudServicio" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione SolicitudServicio.svc o SolicitudServicio.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class SolicitudServicio : ISolicitudServicio
    {
        private readonly ISSolicitudServicio iSSolicitudServicio;
        private readonly ILogService iLogService;

        public SolicitudServicio()
        {
            iSSolicitudServicio = new SSolicitudServicio();
            iLogService = new LogService();

        }

        public ICollection<usp_LisTickedPesadaEnProceso_Result> usp_LisTickedPesadaEnProceso(int inProceso, string strIdlocal, int intCliente, int intEstado)
        {
            ICollection<usp_LisTickedPesadaEnProceso_Result> retorno = new List<usp_LisTickedPesadaEnProceso_Result>();

            try
            {
                retorno= iSSolicitudServicio.usp_LisTickedPesadaEnProceso(inProceso, strIdlocal, intCliente, intEstado);

            }
            catch (Exception ex)
            {
                iLogService.SetLog(string.Concat("WPF => usp_LisTickedPesadaEnProceso | ", ex.Message, " | ", ex.Source.ToString(), " | ", ex.StackTrace.ToString()), null);
            }

            return retorno;
        }
    }
}
