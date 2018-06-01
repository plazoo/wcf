using Service.SGOTouch.Clases;
using Service.SGOTouch.Interace;
using System;
using System.Collections;
using System.Collections.Generic;
using Persistence.domain;
using  Service;

namespace SGO_WCF.SGOTouch.Services
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "TablaGeneral" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione TablaGeneral.svc o TablaGeneral.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class TablaGeneral : ITablaGeneral
    {
        
        private readonly ISTablaGeneral iSTablaGeneral;
        private readonly ILogService iLogService;

        public TablaGeneral()
        {
            iSTablaGeneral = new STablaGeneral();
            iLogService = new LogService();

        }

        public ICollection<usp_LisBusquedaClienteFiltro_Result> usp_LisBusquedaClienteFiltro(string strFiltro)
        {
            ICollection<usp_LisBusquedaClienteFiltro_Result> retorno = new List<usp_LisBusquedaClienteFiltro_Result>();
            
            try
            {
                retorno = iSTablaGeneral.usp_LisBusquedaClienteFiltro(strFiltro);
            }
            catch (Exception ex)
            {
                iLogService.SetLog(string.Concat("WPF => usp_LisBusquedaClienteFiltro | ", ex.Message, " | ", ex.Source.ToString(), " | ", ex.StackTrace.ToString()), null);
            }
            return retorno;
         
        }

        public ICollection<usp_LisComboSacoCafe_Result> usp_LisComboSacoCafe(string strEstado)
        {
            ICollection<usp_LisComboSacoCafe_Result> retorno = new List<usp_LisComboSacoCafe_Result>();


            try
            {
                retorno = iSTablaGeneral.usp_LisComboSacoCafe(strEstado);
            }
            catch (Exception ex)
            {
                iLogService.SetLog(string.Concat("WPF => usp_LisComboSacoCafe | ", ex.Message, " | ", ex.Source.ToString(), " | ", ex.StackTrace.ToString()), null);
            }
            return retorno;
            
        }

        public ICollection<usp_LisContratoConGI_Result> usp_LisContratoConGI(int inIdCliente, int inCosecha)
        {
            
            ICollection<usp_LisContratoConGI_Result> retorno = new List<usp_LisContratoConGI_Result>();

            try
            {
                retorno = iSTablaGeneral.usp_LisContratoConGI(inIdCliente, inCosecha);
            }
            catch (Exception ex)
            {
                iLogService.SetLog(string.Concat("WPF => usp_LisContratoConGI | ", ex.Message, " | ", ex.Source.ToString(), " | ", ex.StackTrace.ToString()), null);
            }
            return retorno;
        }

        public ICollection<usp_LisLaboratorioDisponibleXCliente_Result> usp_LisLaboratorioDisponibleXCliente(int inIdCliente, string strIdLocal)
        {
            ICollection<usp_LisLaboratorioDisponibleXCliente_Result> retorno = new List<usp_LisLaboratorioDisponibleXCliente_Result>();


            try
            {
                retorno = iSTablaGeneral.usp_LisLaboratorioDisponibleXCliente(inIdCliente, strIdLocal);
            }
            catch (Exception ex)
            {
                iLogService.SetLog(string.Concat("WPF => usp_LisLaboratorioDisponibleXCliente | ", ex.Message, " | ", ex.Source.ToString(), " | ", ex.StackTrace.ToString()), null);
            }
            return retorno; 
        }

        public ICollection<usp_LisTipoCafe_Result> usp_LisTipoCafe(string strEstado)
        {
            ICollection<usp_LisTipoCafe_Result> retorno = new List<usp_LisTipoCafe_Result>();

            try
            {
                retorno = iSTablaGeneral.usp_LisTipoCafe(strEstado);
            }
            catch (Exception ex)
            {
                iLogService.SetLog(string.Concat("WPF => usp_LisTipoCafe | ", ex.Message, " | ", ex.Source.ToString(), " | ", ex.StackTrace.ToString()), null);
            }
            return retorno;
          
        }

        public ICollection<usp_LisTipoRuma_Result> usp_LisTipoRuma(string strIdLocal, string strIdEstado)
        {
            ICollection<usp_LisTipoRuma_Result> retorno = new List<usp_LisTipoRuma_Result>();


            try
            {
                retorno = iSTablaGeneral.usp_LisTipoRuma(strIdLocal, strIdEstado);
            }
            catch (Exception ex)
            {
                iLogService.SetLog(string.Concat("WPF => usp_LisTipoRuma | ", ex.Message, " | ", ex.Source.ToString(), " | ", ex.StackTrace.ToString()), null);
            }
            return retorno; 
        }

        public ICollection<usp_Mant_CLIENTE_COSECHA_Result> usp_Mant_CLIENTE_COSECHA(int bus, CLIENTE_COSECHA oP)
        {
            ICollection<usp_Mant_CLIENTE_COSECHA_Result> retorno = new List<usp_Mant_CLIENTE_COSECHA_Result>();


            try
            {
                retorno = iSTablaGeneral.usp_Mant_CLIENTE_COSECHA(bus, oP);
            }
            catch (Exception ex)
            {
                iLogService.SetLog(string.Concat("WPF => usp_Mant_CLIENTE_COSECHA | ", ex.Message, " | ", ex.Source.ToString(), " | ", ex.StackTrace.ToString()), null);
            }
            return retorno;
            
        }

        public ICollection<usp_Mant_TIPO_COSECHA_Result> usp_Mant_TIPO_COSECHA(int bus, TIPO_COSECHA oP)
        {
            ICollection<usp_Mant_TIPO_COSECHA_Result> retorno = new List<usp_Mant_TIPO_COSECHA_Result>();


            try
            {
                retorno = iSTablaGeneral.usp_Mant_TIPO_COSECHA(bus, oP);
            }
            catch (Exception ex)
            {
                iLogService.SetLog(string.Concat("WPF => usp_Mant_TIPO_COSECHA | ", ex.Message, " | ", ex.Source.ToString(), " | ", ex.StackTrace.ToString()), null);
            }
            return retorno;
        }

        public ICollection<SelLocalIdEmpresaUsuario> usp_SelLocalIdEmpresaUsuario(string IdEmpresa, int IdUsuario)
        {
            ICollection<SelLocalIdEmpresaUsuario> retorno = new List<SelLocalIdEmpresaUsuario>();

            try
            {
                retorno = iSTablaGeneral.usp_SelLocalIdEmpresaUsuario(IdEmpresa, IdUsuario);
            }
            catch (Exception ex)
            {
                iLogService.SetLog(string.Concat("WPF => usp_SelLocalIdEmpresaUsuario | ", ex.Message, " | ", ex.Source.ToString(), " | ", ex.StackTrace.ToString()), null);
            }
            return retorno;
        }
    }
}
