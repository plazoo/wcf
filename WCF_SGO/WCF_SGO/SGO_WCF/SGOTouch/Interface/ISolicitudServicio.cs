using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using Persistence.domain;

namespace SGO_WCF.SGOTouch.Services
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISolicitudServicio" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ISolicitudServicio
    {
        [OperationContract]
        [ApplyDataContractResolver]
        ICollection<usp_LisTickedPesadaEnProceso_Result> usp_LisTickedPesadaEnProceso(int inProceso, string strIdlocal, int intCliente, int intEstado);
    }
}
