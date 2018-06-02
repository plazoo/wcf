using System.Collections.Generic;
using System.ServiceModel;
using Persistence.domain;

namespace SGO_WCF.SGOTouch
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IUsuarioService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IUsuarioService
    {
  
        [OperationContract]
        [ApplyDataContractResolver]
        Usuario GetValidarUsuario(string user, string password);

        
    }
}
