using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistence.domain;
namespace Repository.SGOTouch
{
    public class RTablaGeneral : IRTablaGeneral
    {
        #region "TablaGeneral"


        public ICollection<usp_LisBusquedaClienteFiltro_Result> usp_LisBusquedaClienteFiltro(string strFiltro)
        {
            using (var db = new ApplicationDbContextSGO())
            {
                var response = db.usp_LisBusquedaClienteFiltro(strFiltro).ToList();
                return response;
            }
        }

        public ICollection<usp_LisComboSacoCafe_Result> usp_LisComboSacoCafe(string strEstado)
        {
            using (var db = new ApplicationDbContextSGO())
            {
                var response = db.usp_LisComboSacoCafe(strEstado).ToList();

                return response;
            }
        }

        public ICollection<usp_LisContratoConGI_Result> usp_LisContratoConGI(int inIdCliente, int inCosecha)
        {
            using (var db = new ApplicationDbContextSGO())
            {
                var response = db.usp_LisContratoConGI(inIdCliente, inCosecha).ToList();

                return response;
            }
        }

        public ICollection<usp_LisLaboratorioDisponibleXCliente_Result> usp_LisLaboratorioDisponibleXCliente(int inIdCliente, string strIdLocal)
        {
            using (var db = new ApplicationDbContextSGO())
            {
                var response = db.usp_LisLaboratorioDisponibleXCliente(inIdCliente, strIdLocal).ToList();

                return response;
            }
        }

        public ICollection<usp_LisTipoCafe_Result> usp_LisTipoCafe(string strEstado)
        {
            using (var db = new ApplicationDbContextSGO())
            {
                var response = db.usp_LisTipoCafe(strEstado).ToList();

                return response;
            }
        }

        public ICollection<usp_LisTipoRuma_Result> usp_LisTipoRuma(string strIdLocal, string strIdEstado)
        {
            using (var db = new ApplicationDbContextSGO())
            {
                var response = db.usp_LisTipoRuma(strIdLocal, strIdEstado).ToList();

                return response;
            }
        }

        public ICollection<usp_Mant_CLIENTE_COSECHA_Result> usp_Mant_CLIENTE_COSECHA(int bus,CLIENTE_COSECHA oP)
        {
            using (var db = new ApplicationDbContextSGO())
            {
                var response = db.usp_Mant_CLIENTE_COSECHA(bus,oP.IdClienteCosecha,oP.IdCosecha,oP.IdCliente,oP.InEstado,
                    oP.UsuarioModifica,oP.UsuarioRegistro,oP.InVigente).ToList();
                return response;
                
            }
        }

        public ICollection<usp_Mant_TIPO_COSECHA_Result> usp_Mant_TIPO_COSECHA(int bus, TIPO_COSECHA oP)
        {
            using (var db = new ApplicationDbContextSGO())
            {
                var response = db.usp_Mant_TIPO_COSECHA(bus,oP.IdCosecha,oP.vcCosecha,oP.vcComentario,oP.IdEstado,oP.UsuarioRegistro,oP.UsuarioModifica).ToList();
                return response;
                
            }
        }

        public  ICollection<SelLocalIdEmpresaUsuario> usp_SelLocalIdEmpresaUsuario(string IdEmpresa, int IdUsuario)
        {
            using (var db = new ApplicationDbContextSGU())
            {
                var response = db.usp_SelLocalIdEmpresaUsuario(IdEmpresa, IdUsuario).ToList();
                return response;
            }
        }
        #endregion
        
    }
}
