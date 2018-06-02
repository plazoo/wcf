using Service.SGOTouch.Interace;
using System;
using System.Linq;
using Persistence.domain;
using Repository.SGOTouch;
using System.Collections.Generic;

namespace Service.SGOTouch.Clases
{
    public class SCertificadoVSP : ISCertificadoVSP
    {
        private readonly IRCertificadoVSP iRCertificadoVSP;
        public SCertificadoVSP()
        {
            iRCertificadoVSP = new RCertificadoVSP();
        }
        public ICollection<usp_LisSaldoCertificado_Result> usp_LisSaldoCertificado(int IdCliente, string strCosecha)
        {
            return iRCertificadoVSP.usp_LisSaldoCertificado(IdCliente,strCosecha);
        }
    }
}
