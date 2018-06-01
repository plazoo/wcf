using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using Persistence.domain;
using Service.CVenta;
using Common;

namespace SGO_WCF.SGOLog
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISGOLog" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ISGOLog
    {
        [OperationContract]
        [ApplyDataContractResolver]
        int SetLog(string description, int? user);
    }
}
