namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GASTO_PRP_DET
    {
        [Key]
        public int IdGastoPRPDet { get; set; }

        public int? IdGasto_PRP { get; set; }

        public int? IdTipoDocumento { get; set; }

        public int? IdTipoOperacion { get; set; }

        public int? IdCatalogoCuentaContable { get; set; }

        public int? IdGastoCentroCosto { get; set; }

        public DateTime? DocumentoFecha { get; set; }

        [StringLength(4)]
        public string DocumentoSerie { get; set; }

        [StringLength(16)]
        public string DocumentoNumero { get; set; }

        [StringLength(11)]
        public string RUC { get; set; }

        [StringLength(150)]
        public string Proveedor { get; set; }

        [StringLength(400)]
        public string Descripcion { get; set; }

        [StringLength(3)]
        public string IdMoneda { get; set; }

        public decimal? BaseImponible { get; set; }

        public decimal? ImpuestoIGV { get; set; }

        public decimal? Inafectos { get; set; }

        public decimal? MontoRedondeo { get; set; }

        public decimal? MontoTotal { get; set; }

        public int? IdEstado { get; set; }

        public DateTime? FechaRegistra { get; set; }

        public int? UsuarioRegistra { get; set; }

        public DateTime? FechaActualiza { get; set; }

        public int? UsuarioActualiza { get; set; }

        public int? inMovilidadNacional { get; set; }

        public virtual GASTO_PRP_CAB GASTO_PRP_CAB { get; set; }
    }
}
