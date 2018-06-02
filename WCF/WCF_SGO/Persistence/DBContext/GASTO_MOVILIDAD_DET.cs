namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GASTO_MOVILIDAD_DET
    {
        [Key]
        public int IdMovilidadDet { get; set; }

        public int? IdMovilidadCab { get; set; }

        public int? IdGastoCentroCosto { get; set; }

        public int? IdCatalogoCuentaContable { get; set; }

        public DateTime? FechaUso { get; set; }

        public int? FlagFechaMonto { get; set; }

        [StringLength(3)]
        public string IdMoneda { get; set; }

        [StringLength(150)]
        public string Origen { get; set; }

        [StringLength(150)]
        public string Destino { get; set; }

        [StringLength(200)]
        public string Descripcion { get; set; }

        public decimal? BaseImponible { get; set; }

        public decimal? Monto { get; set; }

        public decimal? Exceso { get; set; }

        public int? IdEstado { get; set; }

        public DateTime? FechaRegistra { get; set; }

        public int? UsuarioRegistra { get; set; }

        public DateTime? FechaActualiza { get; set; }

        public int? UsuarioActualiza { get; set; }

        public virtual GASTO_MOVILIDAD_CAB GASTO_MOVILIDAD_CAB { get; set; }
    }
}
