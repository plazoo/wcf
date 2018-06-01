using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Persistence.domain;
using Service;
using Service.CVenta;
using Common;
using System.IO;

namespace SGO_WCF.SGOLog
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "SGOLog" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione SGOLog.svc o SGOLog.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class SGOLog : ISGOLog
    {
        private ILogService iLogService;
        
        public SGOLog()
        {
            iLogService = new LogService();

        }

        public int SetLog(string description, int? user)
        {
            return iLogService.SetLog(description,user);
        }
    }
}
