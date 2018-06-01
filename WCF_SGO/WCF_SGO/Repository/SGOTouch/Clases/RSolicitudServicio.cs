using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistence.domain;

namespace Repository.SGOTouch
{
    public class RSolicitudServicio : IRSolicitudServicio
    {
        public ICollection<usp_LisTickedPesadaEnProceso_Result> usp_LisTickedPesadaEnProceso(int inProceso, string strIdlocal, int intCliente, int intEstado)
        {
            using (var db = new ApplicationDbContextSGO())
            {
                var response = db.usp_LisTickedPesadaEnProceso(inProceso,  strIdlocal,  intCliente,  intEstado).ToList();
                return response;
                
            }
        }
    }
}
