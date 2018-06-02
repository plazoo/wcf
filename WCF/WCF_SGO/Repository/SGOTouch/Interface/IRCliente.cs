using Persistence.domain;
using System.Collections.Generic;

namespace Repository.SGOTouch
{
    public interface IRCliente
    {
        ICollection<LisClienteContacto> usp_LisClienteContacto(int? inIdCliente, string strEstado);

    }
}
