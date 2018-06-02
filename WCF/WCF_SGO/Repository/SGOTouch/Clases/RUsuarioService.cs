using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistence.domain;
using System.Data.SqlClient;

namespace Repository.SGOTouch
{
    public class RUsuarioService : IRUsuarioService
    {

        public Usuario Validar_Usuario2(Usuario oU)
        {
            using (var db = new ApplicationDbContextSGU())
            {
                var response = db.usp_SelUsuarioLogin(oU.vUsuario, oU.vPassword, 24).ToList();
                return response.SingleOrDefault();
            }
        }
    }
}
