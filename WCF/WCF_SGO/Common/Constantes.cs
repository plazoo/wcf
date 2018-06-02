using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class Constantes
    {
        public const string FormatoFecha = "yyyy-MM-dd";
        public const string FormatoNumerico = "###0.#0";
        public const string PathFE = "pathFE";
        public const string ReportPath = "reportPath";
        public const string FolterPathName = "folderName";
        public const string ReportFileName = "reportName";
        public static string PdfFolderName { get { return Helper.GetSettings(Constantes.FolterPathName, 0); } }
        public static string XmlFolderName { get { return Helper.GetSettings(Constantes.FolterPathName, 1); } }
        public static string ZipFileName { get { return Helper.GetSettings(Constantes.FolterPathName, 2); } }
        public static string InternaRpt { get { return Helper.GetSettings(Constantes.ReportFileName, 0); } }
        public static string ExportacionRpt { get { return Helper.GetSettings(Constantes.ReportFileName, 1); } }
    }
}
