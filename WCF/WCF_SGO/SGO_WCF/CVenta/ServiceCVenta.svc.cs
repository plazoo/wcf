using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using Persistence.domain;
using Service;
using Service.CVenta;
using Common;
using System.IO;
using Service.SGOTouch;
using ServiceGenerateBarCode;

namespace SGO_WCF.CVenta
{
    public class ServiceCVenta : IServiceCVenta
    {
        private readonly ICVentaService _iCVentaService;
        private readonly ILogService _iLogService;
        private readonly IGenerateBarCode _iGenerateBarCode;
        public ServiceCVenta()
        {
            _iCVentaService = new CVentaService();
            _iLogService = new LogService();
            _iGenerateBarCode = new GenerateImgQR();
        }
        public IList<ComprobanteCliente> GetLisComprobanteCliente(string nroDocumentoCliente, string tipoComprobante, string correlativo)
        {
            var response = new List<ComprobanteCliente>();
            try
            {
                response = _iCVentaService.GetLisComprobanteCliente(nroDocumentoCliente, tipoComprobante, correlativo).ToList();
            }
            catch (Exception ex)
            {
                _iLogService.SetLog(string.Concat(ex.Message, " | ", ex.Source, " | ", ex.StackTrace), null);
            }
            return response;
        }
        public Result GetComprobante(int idComprobante)
        {
            var response = new Result();
            var objectResponse = new ComprobanteCliente();
            var reportResponse = new List<ComprobanteVenta>();
            var resultZip = new Result();
            try
            {
                var barCodeData = _iCVentaService.GetLisDatosGeneraCodigoBarra(idComprobante).Single();
                string contents = barCodeData.NroDocumentoEmisor + "|" + barCodeData.TipoDocumento + "|";
                contents += barCodeData.NroComprobante.Replace("-", "|") + "|" + barCodeData.TotalIgv + "|";
                contents += barCodeData.TotalVenta + "|" + barCodeData.FechaEmision + "|" + barCodeData.TipoDocumentoReceptor + "|";
                contents += barCodeData.NroDocumentoReceptor + "|" + barCodeData.DigestValue + "|-|-";
                _iGenerateBarCode.GenerateImg(contents);

                objectResponse = _iCVentaService.GetLisIdComprobanteCliente(idComprobante).SingleOrDefault();
                reportResponse = _iCVentaService.GetReporteComprobanteVenta(idComprobante).ToList();
                var reportObjectResponse = reportResponse.SingleOrDefault();
                //var reportDtResponse = Helper.ConvertToDatatable(reportResponse);
                var tipoPDF = 1;
                if (reportObjectResponse.IdTipoOperacion.Equals("02"))
                {
                    if (reportObjectResponse.OperacionName.ToUpper().Trim().Equals("EXPORTACIÓN"))
                    {
                        tipoPDF = 2;
                    }
                    else
                    {
                        tipoPDF = 1;
                    }
                }
                else
                {
                    tipoPDF = 1;
                }
                var gereraPdf = Helper.GenerarPdf(reportResponse, objectResponse.NombreArhivo.Replace(".xml", ".pdf"), tipoPDF);
                if (gereraPdf.Exito)
                {
                    string xmlName = string.Concat(Helper.GetSettings(Constantes.PathFE), Constantes.XmlFolderName, "\\", objectResponse.NombreArhivo);
                    string pdfName = string.Concat(Helper.GetSettings(Constantes.PathFE), Constantes.PdfFolderName, "\\", objectResponse.NombreArhivo.Replace(".xml", ".pdf"));
                    string[] files = { xmlName, pdfName };
                    string name = objectResponse.NombreArhivo.Replace(".xml", "").Trim();
                    resultZip = Helper.ZipFile(files, name);
                    if (resultZip.Exit)
                    {
                        response.Exit = true;
                        response.Message = "La descarga se completó satisfactoriamente";
                        response.Weft = resultZip.Weft.Length > 0 ? Convert.ToBase64String(File.ReadAllBytes(resultZip.Message)) : resultZip.Weft;
                        response.FolderName = objectResponse.NombreArhivo.Replace(".xml", ".zip");
                    }
                    else
                    {
                        response.Exit = false;
                        response.Message = null;
                        response.FolderName = null;
                        response.Weft = null;
                    }
                }
                else
                {
                    response.Exit = false;
                    response.Message = null;
                    response.FolderName = null;
                    response.Weft = null;
                }
            }
            catch (Exception ex)
            {
                _iLogService.SetLog(string.Concat(ex.Message, " | ", ex.Source, " | ", ex.StackTrace), null);
                response.Exit = false;
                response.Message = null;
                response.FolderName = null;
                response.Weft = null;
                return response;
            }
            finally
            {
                if (resultZip.Exit)
                {
                    File.Delete(resultZip.Message);
                }
            }
            return response;
        }
    }
}
