using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistence.domain;
using Repository.SGOTouch;


namespace Service.SGOTouch
{
    public class SUsuarioService : ISUsuarioService
    {
        private readonly IRUsuarioService iUsuarioService;
        public SUsuarioService()
        {
            iUsuarioService = new RUsuarioService();
        }

 
        public Usuario Validar_Usuario2(Usuario oU)
        {
            return iUsuarioService.Validar_Usuario2(oU);
        }
    }
}
