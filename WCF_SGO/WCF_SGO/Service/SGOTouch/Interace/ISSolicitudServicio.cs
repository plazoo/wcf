using System;
using System.Collections.Generic;
using Persistence.domain;

namespace Service.SGOTouch.Interace
{
    public interface ISSolicitudServicio
    {

        ICollection<usp_LisTickedPesadaEnProceso_Result> usp_LisTickedPesadaEnProceso(int inProceso, string strIdlocal, int intCliente, int intEstado);
    }
}
