using System.Collections.Generic;
using Persistence.domain;

namespace Service.SGOTouch.Interace
{
    public interface ISCliente
    {
        ICollection<LisClienteContacto> usp_LisClienteContacto(int? inIdCliente, string strEstado);
        /*Deberia ser string strCosecha pero lo mantengo asi porque en el store Procedure recibe @COSECHA int*/
        /*int inCosecha  <=> se van a realizar operaciones*/
    }
}
