namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ORDEN_COMPRA_CAB
    {
        [Key]
        public int IdOrden { get; set; }

        public int IdOrdenInterno { get; set; }

        public int IdSolicitante { get; set; }

        public int IdProveedor { get; set; }

        public int IdClienteBanco { get; set; }

        public int IdCentroCosto { get; set; }

        public int IdTipoOrden { get; set; }

        public int IdOperacion { get; set; }

        public int IdSubTipoOperacion { get; set; }

        [StringLength(40)]
        public string vcSerieCotizacion { get; set; }

        [StringLength(20)]
        public string vcTelefono { get; set; }

        public int IdLocal { get; set; }

        [StringLength(10)]
        public string TipoMoneda { get; set; }

        public int inTipoCompraServicio { get; set; }

        [StringLength(50)]
        public string vcCompraServicio { get; set; }

        public int inTipoGastoPlanta { get; set; }

        [StringLength(50)]
        public string vcGastoPlanta { get; set; }

        public decimal dcSubTotal { get; set; }

        public decimal dcIGVvalor { get; set; }

        public decimal dcIgv { get; set; }

        public decimal dcValorTotal { get; set; }

        public int inEstado { get; set; }

        public int UsuarioRegistro { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public int? UsuarioModifica { get; set; }

        public DateTime? FechaModifica { get; set; }

        public int? IdEstadoProceso { get; set; }

        public int? IdUsuarioProceso { get; set; }

        public DateTime? FechaProceso { get; set; }

        [StringLength(500)]
        public string vcMotivo { get; set; }
    }
}
