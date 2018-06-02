using Persistence.domain;
using Service.SGOTouch.Interace;
using System;
using System.Collections.Generic;
using Service;
using Service.SGOTouch.Clases;
using SGO_WCF.SGOTouch.Interface;

namespace SGO_WCF.SGOTouch.Services
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "CertificadoVSP" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione CertificadoVSP.svc o CertificadoVSP.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class CertificadoVSP : ICertificadoVSP
    {
        private readonly ILogService iLogService;
        private readonly ISCertificadoVSP iSCertificadoVSP;
        public CertificadoVSP()
        {
            iSCertificadoVSP = new SCertificadoVSP();
            iLogService = new LogService();
        }

        public ICollection<usp_LisSaldoCertificado_Result> usp_LisSaldoCertificado(int IdCliente, string strCosecha)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                
                iLogService.SetLog(string.Concat("WPF => Validar_Usuario | ", ex.Message, " | ", ex.Source.ToString(), " | ", ex.StackTrace.ToString()), null);

                throw;
            }
            return iSCertificadoVSP.usp_LisSaldoCertificado(IdCliente,strCosecha);
        }
    }
}
