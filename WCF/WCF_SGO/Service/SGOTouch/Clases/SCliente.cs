using System;
using System.Collections.Generic;
using System.Linq;
using Persistence.domain;
using Repository.SGOTouch;
using Service.SGOTouch.Interace;

namespace Service.SGOTouch.Clases
{
    public class SCliente: ISCliente
    {
        private readonly IRCliente iRCliente;
        public SCliente()
        {
            iRCliente = new RCliente();
        }

        public ICollection<LisClienteContacto> usp_LisClienteContacto(int? inIdCliente, string strEstado)
        {
            return iRCliente.usp_LisClienteContacto(inIdCliente,strEstado);
        }
    }
}
