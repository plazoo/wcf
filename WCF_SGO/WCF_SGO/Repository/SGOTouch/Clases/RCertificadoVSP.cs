using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistence.domain;

namespace Repository.SGOTouch
{
    public class RCertificadoVSP : IRCertificadoVSP
    {
       public  ICollection<usp_LisSaldoCertificado_Result> usp_LisSaldoCertificado(int IdCliente, string strCosecha)
        {
            using (var db = new ApplicationDbContextSGO())
            {
                var response = db.usp_LisSaldoCertificado(IdCliente,Convert.ToInt32(strCosecha)).ToList();
                return response;
            }
        }

    }
}
