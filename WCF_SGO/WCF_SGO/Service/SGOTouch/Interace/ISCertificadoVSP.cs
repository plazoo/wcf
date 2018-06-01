using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.SGOTouch;
using Persistence.domain;

namespace Service.SGOTouch.Interace
{
    public interface ISCertificadoVSP
    {
        ICollection<usp_LisSaldoCertificado_Result> usp_LisSaldoCertificado(int IdCliente, string strCosecha);
    }
}
