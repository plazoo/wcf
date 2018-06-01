
using System.Collections.Generic;
using Persistence.domain;

namespace Repository.SGOTouch
{
    public interface IRSolicitudServicio
    {
        ICollection<usp_LisTickedPesadaEnProceso_Result> usp_LisTickedPesadaEnProceso(int inProceso, string strIdlocal, int intCliente, int intEstado);

    }
}
