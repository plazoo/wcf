namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SERVICIO_PRP_CABECERA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SERVICIO_PRP_CABECERA()
        {
            SERVICIO_PRP_DETALLE = new HashSet<SERVICIO_PRP_DETALLE>();
            SERVICIO_PRP_RESULTADO = new HashSet<SERVICIO_PRP_RESULTADO>();
        }

        [Key]
        public int IdOrdenServicio { get; set; }

        public int IdOrdenServicioInterno { get; set; }

        [Required]
        [StringLength(2)]
        public string IdLocal { get; set; }

        [StringLength(250)]
        public string IdTipoServicio { get; set; }

        public int IdTipoCafe { get; set; }

        public int Cosecha { get; set; }

        public int IdCliente { get; set; }

        public int InicioSaco { get; set; }

        public decimal InicioTara { get; set; }

        public decimal InicioKgBruto { get; set; }

        public decimal InicioKgNeto { get; set; }

        public int? FinTipoSaco { get; set; }

        public int? FinSaco { get; set; }

        public decimal? FinTara { get; set; }

        public decimal? FinKgBruto { get; set; }

        public decimal? FinKgNeto { get; set; }

        [Column(TypeName = "text")]
        public string Observacion { get; set; }

        public int IdEstado { get; set; }

        [Required]
        [StringLength(6)]
        public string UsuarioRegistro { get; set; }

        public DateTime FechaRegistro { get; set; }

        [StringLength(6)]
        public string UsuarioFinProceso { get; set; }

        public DateTime? FechaFinProceso { get; set; }

        [StringLength(6)]
        public string UsuarioModifica { get; set; }

        public DateTime? FechaModifica { get; set; }

        [StringLength(250)]
        public string TipoServicioDescripcion { get; set; }

        public int? IdGuiaAsignado { get; set; }

        public virtual CLIENTE CLIENTE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICIO_PRP_DETALLE> SERVICIO_PRP_DETALLE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICIO_PRP_RESULTADO> SERVICIO_PRP_RESULTADO { get; set; }
    }
}
