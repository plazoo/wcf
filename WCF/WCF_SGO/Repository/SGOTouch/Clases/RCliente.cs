
using System;
using System.Collections.Generic;
using Persistence.domain;
using System.Linq;

namespace Repository.SGOTouch
{
    public class RCliente : IRCliente
    {
        
        public ICollection<LisClienteContacto> usp_LisClienteContacto(int? inIdCliente, string strEstado)
        {
            //var response = new List<usp_LisClienteContacto_Result>();
            using (var db = new ApplicationDbContextSGO())
            {
                var response = db.usp_LisClienteContacto(inIdCliente, strEstado).ToList();
                return response;
                //return null;
            }
        }
    }
}
