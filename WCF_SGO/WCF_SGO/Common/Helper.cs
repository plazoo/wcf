using System;
using System.Configuration;
using Microsoft.Reporting.WinForms;
using System.IO;
using Ionic.Zip;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Text;

namespace Common
{
    public static class Helper
    {
        public static string GetSettings(string key) { return ConfigurationManager.AppSettings[key]; }
        public static string GetSettings(string key, int index)
        {
            var arKey = ConfigurationManager.AppSettings[key].ToString().Split('|');
            return arKey[index].ToString();
        }
        private static string pathFE { get { return GetSettings(Constantes.PathFE); } }
        private static string ReportPath { get { return GetSettings(Constantes.ReportPath); } }

        public static Response GenerarPdf(object dtObj, string fileName, int tipoPDF)
        {
            var Response = new Response();
            var reportViewer = new ReportViewer();
            reportViewer.ProcessingMode = ProcessingMode.Local;
            reportViewer.LocalReport.EnableExternalImages = true;
            var reportName = Constantes.InternaRpt;
            if (tipoPDF == 2)
                reportName = Constantes.ExportacionRpt;
            reportViewer.LocalReport.ReportPath = string.Concat(ReportPath, reportName);
            reportViewer.LocalReport.DataSources.Clear();
            try
            {
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("ds", dtObj));
                Microsoft.Reporting.WinForms.Warning[] warnings = null;
                string[] streamids = null;
                string mimeType = null;
                string encoding = null;
                string extension = null;
                string deviceInfo = string.Concat("<DeviceInfo>", "  <OutputFormat>PDF</OutputFormat>",
                                            "  <PageWidth>8.5in</PageWidth>", "  <PageHeight>11.5in</PageHeight>",
                                            "  <MarginTop>0.2in</MarginTop>", "  <MarginLeft>0.2in</MarginLeft>",
                                            "  <MarginRight>0.2in</MarginRight>", "  <MarginBottom>0.2in</MarginBottom>",
                                            "  </DeviceInfo>");
                reportViewer.RefreshReport();
                byte[] bytes = reportViewer.LocalReport.Render("PDF", deviceInfo, out mimeType,
                    out encoding, out extension, out streamids, out warnings);
                var path = string.Concat(pathFE, Constantes.PdfFolderName, "\\", fileName);
                if (!File.Exists(path))
                    File.WriteAllBytes(path, bytes);
                else
                {
                    File.Delete(path);
                    File.WriteAllBytes(path, bytes);
                }
                Response.Exito = true;
                Response.MensajeError = string.Concat("Se ha generado el PDF del comprobante Nro.", fileName);
            }
            catch (Exception ex)
            {
                Response.Exito = false;
                Response.MensajeError = ex.Message + "n" + ex.Source;
                throw;
            }
            return Response;
        }
        public static Result ZipFile(string[] files, string zipName)
        {
            var Response = new Result();
            try
            {
                var fileName = string.Format("{0}{1}\\{2}.zip", pathFE, Constantes.ZipFileName, zipName);
                using (ZipFile zip = new ZipFile())
                {
                    zip.AddFiles(files, "");
                    zip.Save(fileName);
                }
                Response.Exit = true;
                Response.Message = fileName;
                Response.Weft = Convert.ToBase64String(File.ReadAllBytes(fileName));
            }
            catch (Exception ex)
            {
                Response.Exit = false;
                Response.Message = ex.Message + "n" + ex.Source;
                throw;
            }
            return Response;
        }
        public static DataTable ConvertToDatatable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }
        public static string getMd5Hash(string input)
        {
            // Create a new instance of the MD5 object.
            MD5 md5Hasher = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i <= data.Length - 1; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }
}