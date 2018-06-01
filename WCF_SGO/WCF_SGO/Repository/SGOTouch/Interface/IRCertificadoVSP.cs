using Persistence.domain;
using System.Collections.Generic;


namespace Repository.SGOTouch
{
    public interface IRCertificadoVSP
    {
        ICollection<usp_LisSaldoCertificado_Result> usp_LisSaldoCertificado(int IdCliente, string strCosecha);
    }
}
