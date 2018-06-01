using SGO_WCF.SGOTouch.Interface;
using System;
using System.Collections.Generic;
using Service.SGOTouch;
using Persistence.domain;
using Service.SGOTouch.Interace;
using Service.SGOTouch.Clases;
using Service;

namespace SGO_WCF.SGOTouch.Services
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Cliente" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Cliente.svc o Cliente.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Cliente : ICliente
    {
        private readonly ISCliente iSCliente;
        private readonly ILogService iLogService;
        public Cliente()
        {
            iSCliente = new SCliente();
            iLogService = new LogService();
        }

        public ICollection<LisClienteContacto> usp_LisClienteContacto(int? inIdCliente, string strEstado)
        {
            ICollection<LisClienteContacto> retorno = new List<LisClienteContacto>();

            try
            {
                    retorno=iSCliente.usp_LisClienteContacto(inIdCliente, strEstado);
            }
            catch (Exception ex)
            {
                iLogService.SetLog(string.Concat("WPF => usp_LisClienteContacto | ", ex.Message, " | ", ex.Source.ToString(), " | ", ex.StackTrace.ToString()), null);
            }

            return retorno;
        }
    }
}
