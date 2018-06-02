using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistence.domain;
using Repository.SGOTouch;
using Service.SGOTouch.Interace;

namespace Service.SGOTouch.Clases
{
    public class SSolicitudServicio :ISSolicitudServicio 
    {
        private readonly IRSolicitudServicio iRSolicitudServicio;
        public SSolicitudServicio()
        {
            iRSolicitudServicio = new RSolicitudServicio();
        }

        public ICollection<usp_LisTickedPesadaEnProceso_Result> usp_LisTickedPesadaEnProceso(int inProceso, string strIdlocal, int intCliente, int intEstado)
        {
            return iRSolicitudServicio.usp_LisTickedPesadaEnProceso(inProceso, strIdlocal, intCliente, intEstado);
        }
    }
}
