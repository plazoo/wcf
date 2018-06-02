using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppTest.ServiceCVenta;
using System.ServiceModel;
using ConsoleAppTest.ServiceUsuario;
namespace ConsoleAppTest
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando test...");
            //var client = new ServiceCVentaClient();
            //var response = client.GetLisComprobanteCliente("27723691","03", "B902-00000001");
            //var responseId = client.GetComprobante(162);
            Console.WriteLine("{0}      {1}     {2}     {3}     {4}     {5}", "Correlativo", "Subtotal", "Impuesto", "Total", "Estado", "FechaOperacion");
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            //foreach (var item in response)
            //{
            //    Console.WriteLine("{0}      {1}     {2}     {3}     {4}     {5}", item.Correlativo, item.ImporteSubtotal, item.Impuesto, item.ImporteTotal, item.InvoiceState, item.FechaOperacion);
            //    Console.WriteLine("-------------------------------------------------------------------------------------------------");
            //}
            var o = new UsuarioServiceClient();
            var resp = o.Validar_Usuario2(new Usuario {
                vUsuario ="sabanto",
                vPassword=""
            });
            Console.ReadKey();
        }
    }
}
