using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Persistence.domain;

using Service.SGOTouch;
using Service.CVenta;

using Common;
using System.IO;
using Service;


namespace SGO_WCF.SGOTouch
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "UsuarioService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione UsuarioService.svc o UsuarioService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class UsuarioService : IUsuarioService
    {
        
        private readonly ILogService  _iLogService;
        private readonly ISUsuarioService _iSUsuarioService;

        //private ICVentaService asd;
        public UsuarioService()
        {
            
            //iSUsuarioService = new SUsuarioService();
            _iSUsuarioService = new SUsuarioService();
            _iLogService = new LogService();
        }
      
        public Usuario GetValidarUsuario(string user,string password)
        {
            var response = new Usuario();
            try
            {
                var usuario = new Usuario()
                {
                    vUsuario = user,
                    vPassword = Helper.getMd5Hash(password)
                };
                response = _iSUsuarioService.Validar_Usuario2(usuario);
            }
            catch (Exception ex)
            {
                
                _iLogService.SetLog(string.Concat("WPF => GetValidarUsuario | ", ex.Message, " | ", ex.Source.ToString(), " | ", ex.StackTrace.ToString()), null);

            }
            return response;
        }
    }
}
