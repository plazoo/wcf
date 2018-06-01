using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistence.domain;
using Repository.SGOTouch;
using Service.SGOTouch.Interace;

namespace Service.SGOTouch.Clases
{
    public class STablaGeneral : ISTablaGeneral
    {
        private readonly IRTablaGeneral iRTablaGeneral;
        public STablaGeneral()
        {
            iRTablaGeneral = new RTablaGeneral();
        }

        public ICollection<usp_LisBusquedaClienteFiltro_Result> usp_LisBusquedaClienteFiltro(string strFiltro)
        {
            return iRTablaGeneral.usp_LisBusquedaClienteFiltro(strFiltro);            
        }

        public ICollection<usp_LisComboSacoCafe_Result> usp_LisComboSacoCafe(string strEstado)
        {
            return iRTablaGeneral.usp_LisComboSacoCafe(strEstado);
        }

        public ICollection<usp_LisContratoConGI_Result> usp_LisContratoConGI(int inIdCliente, int inCosecha)
        {
            return iRTablaGeneral.usp_LisContratoConGI(inIdCliente,inCosecha);
        }

        public ICollection<usp_LisLaboratorioDisponibleXCliente_Result> usp_LisLaboratorioDisponibleXCliente(int inIdCliente, string strIdLocal)
        {
            return iRTablaGeneral.usp_LisLaboratorioDisponibleXCliente(inIdCliente,strIdLocal);
        }

        public ICollection<usp_LisTipoCafe_Result> usp_LisTipoCafe(string strEstado)
        {
            return iRTablaGeneral.usp_LisTipoCafe(strEstado);
        }

        public ICollection<usp_LisTipoRuma_Result> usp_LisTipoRuma(string strIdLocal, string strIdEstado)
        {
            return iRTablaGeneral.usp_LisTipoRuma(strIdLocal,strIdEstado);
        }

        public ICollection<usp_Mant_CLIENTE_COSECHA_Result> usp_Mant_CLIENTE_COSECHA(int bus, CLIENTE_COSECHA oP)
        {
            return iRTablaGeneral.usp_Mant_CLIENTE_COSECHA(bus,oP);
        }

        public ICollection<usp_Mant_TIPO_COSECHA_Result> usp_Mant_TIPO_COSECHA(int bus, TIPO_COSECHA oP)
        {
            return iRTablaGeneral.usp_Mant_TIPO_COSECHA(bus, oP);
        }

        public ICollection<SelLocalIdEmpresaUsuario> usp_SelLocalIdEmpresaUsuario(string IdEmpresa, int IdUsuario)
        {
            return iRTablaGeneral.usp_SelLocalIdEmpresaUsuario(IdEmpresa,IdUsuario);
        }
    }
}
