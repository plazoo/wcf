//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Persistence.domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class GASTO_PRP_DET
    {
        public int IdGastoPRPDet { get; set; }
        public Nullable<int> IdGasto_PRP { get; set; }
        public Nullable<int> IdTipoDocumento { get; set; }
        public Nullable<int> IdTipoOperacion { get; set; }
        public Nullable<int> IdCatalogoCuentaContable { get; set; }
        public Nullable<int> IdGastoCentroCosto { get; set; }
        public Nullable<System.DateTime> DocumentoFecha { get; set; }
        public string DocumentoSerie { get; set; }
        public string DocumentoNumero { get; set; }
        public string RUC { get; set; }
        public string Proveedor { get; set; }
        public string Descripcion { get; set; }
        public string IdMoneda { get; set; }
        public Nullable<decimal> BaseImponible { get; set; }
        public Nullable<decimal> ImpuestoIGV { get; set; }
        public Nullable<decimal> Inafectos { get; set; }
        public Nullable<decimal> MontoRedondeo { get; set; }
        public Nullable<decimal> MontoTotal { get; set; }
        public Nullable<int> IdEstado { get; set; }
        public Nullable<System.DateTime> FechaRegistra { get; set; }
        public Nullable<int> UsuarioRegistra { get; set; }
        public Nullable<System.DateTime> FechaActualiza { get; set; }
        public Nullable<int> UsuarioActualiza { get; set; }
        public Nullable<int> inMovilidadNacional { get; set; }
    }
}