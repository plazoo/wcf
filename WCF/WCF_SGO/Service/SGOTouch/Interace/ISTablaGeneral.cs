using System;
using System.Collections.Generic;
using Repository.SGOTouch;
using Persistence.domain;

namespace Service.SGOTouch.Interace
{
    public interface ISTablaGeneral
    {
        ICollection<SelLocalIdEmpresaUsuario> usp_SelLocalIdEmpresaUsuario(string IdEmpresa, int IdUsuario);
        ICollection<usp_Mant_TIPO_COSECHA_Result> usp_Mant_TIPO_COSECHA(int bus, TIPO_COSECHA oP);
        ICollection<usp_Mant_CLIENTE_COSECHA_Result> usp_Mant_CLIENTE_COSECHA(int bus, CLIENTE_COSECHA oP);
        ICollection<usp_LisTipoCafe_Result> usp_LisTipoCafe(string strEstado);
        ICollection<usp_LisComboSacoCafe_Result> usp_LisComboSacoCafe(string strEstado);
        ICollection<usp_LisLaboratorioDisponibleXCliente_Result> usp_LisLaboratorioDisponibleXCliente(int inIdCliente, string strIdLocal);
        ICollection<usp_LisTipoRuma_Result> usp_LisTipoRuma(string strIdLocal, string strIdEstado);
        ICollection<usp_LisBusquedaClienteFiltro_Result> usp_LisBusquedaClienteFiltro(string strFiltro);
        ICollection<usp_LisContratoConGI_Result> usp_LisContratoConGI(int inIdCliente, int inCosecha);
    }
}
