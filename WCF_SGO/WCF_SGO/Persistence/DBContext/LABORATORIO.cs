namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LABORATORIO")]
    public partial class LABORATORIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LABORATORIO()
        {
            LABORATORIO_REFERENCIA = new HashSet<LABORATORIO_REFERENCIA>();
            LABORATORIO_DEFECTO = new HashSet<LABORATORIO_DEFECTO>();
        }

        [Key]
        public int IdLaboratorio { get; set; }

        public int IdLaboratorioZona { get; set; }

        public int IdCliente { get; set; }

        public int IdDocOperacion { get; set; }

        public int IdDocumento { get; set; }

        [Required]
        [StringLength(2)]
        public string IdLocal { get; set; }

        public int IdTipoCafe { get; set; }

        public DateTime FechaAnalisis { get; set; }

        [Required]
        [StringLength(10)]
        public string FormatoAnalisis { get; set; }

        public int NroSaco { get; set; }

        public decimal KgBruto { get; set; }

        public decimal KgNeto { get; set; }

        public decimal PesoSaco { get; set; }

        public decimal Tara { get; set; }

        public decimal? HumedadZona { get; set; }

        public decimal? PorcRendimiento { get; set; }

        [StringLength(10)]
        public string Calidad { get; set; }

        public decimal? APPorcHumedad { get; set; }

        public decimal? APPorcAgua { get; set; }

        public decimal? APMHumedad { get; set; }

        public decimal? APPorcPajilla { get; set; }

        public decimal? APMSeca { get; set; }

        public decimal? APPtc { get; set; }

        public decimal? APPorcCompra { get; set; }

        public decimal? APOro { get; set; }

        public decimal? APPorcOro { get; set; }

        public decimal? APColor { get; set; }

        public decimal? APPorcColor { get; set; }

        public decimal? APMaquina { get; set; }

        public decimal? APPorcMaquina { get; set; }

        public decimal? APBanda { get; set; }

        public decimal? APPorcBanda { get; set; }

        public decimal? APBola { get; set; }

        public decimal? APPorcBola { get; set; }

        public decimal? APOtros { get; set; }

        public decimal? APProcOtros { get; set; }

        public decimal? APSc18 { get; set; }

        public decimal? APPorcSc18 { get; set; }

        public decimal? APSc16 { get; set; }

        public decimal? APPorcSc16 { get; set; }

        public decimal? APSc12 { get; set; }

        public decimal? APPorcSc12 { get; set; }

        public decimal? APSc0 { get; set; }

        public decimal? APPorcSc0 { get; set; }

        [StringLength(30)]
        public string APAcidez { get; set; }

        [StringLength(30)]
        public string APCuerpo { get; set; }

        [StringLength(30)]
        public string APCalidad { get; set; }

        public int? AOTrilla { get; set; }

        public int? AOLote { get; set; }

        [StringLength(10)]
        public string AORuma { get; set; }

        public decimal? AOBrocado { get; set; }

        public decimal? AOBanda { get; set; }

        public decimal? AOManchado { get; set; }

        public decimal? AOColor { get; set; }

        public decimal? AOInmaduro { get; set; }

        public decimal? AOMaquina { get; set; }

        public decimal? AOMantequilla { get; set; }

        public decimal? AOBlanco { get; set; }

        public decimal? AOProcHumedad { get; set; }

        public decimal? AODeforme { get; set; }

        public decimal? AOPartido { get; set; }

        public decimal? AOOtros { get; set; }

        public int NroTaza { get; set; }

        [Column(TypeName = "text")]
        public string Observacion { get; set; }

        public int IdEstado { get; set; }

        [Required]
        [StringLength(6)]
        public string UsuarioRegistro { get; set; }

        public DateTime FechaRegistro { get; set; }

        [StringLength(6)]
        public string UsuarioModifica { get; set; }

        public DateTime? FechaModifica { get; set; }

        public decimal? PorcTamoCascara { get; set; }

        public decimal? PorcDescarte { get; set; }

        [StringLength(50)]
        public string IdCertificacion { get; set; }

        [StringLength(200)]
        public string vcCertificacion { get; set; }

        public virtual CLIENTE CLIENTE { get; set; }

        public virtual DOCUMENTO_OPERACION DOCUMENTO_OPERACION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LABORATORIO_REFERENCIA> LABORATORIO_REFERENCIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LABORATORIO_DEFECTO> LABORATORIO_DEFECTO { get; set; }

        public virtual TIPO_CAFE TIPO_CAFE { get; set; }
    }
}
