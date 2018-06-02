namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CLIENTE")]
    public partial class CLIENTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIENTE()
        {
            CIERRE_ANUAL = new HashSet<CIERRE_ANUAL>();
            CLIENTE_BANCO = new HashSet<CLIENTE_BANCO>();
            CLIENTE_CERTIFICADO = new HashSet<CLIENTE_CERTIFICADO>();
            CLIENTE_CONTACTO = new HashSet<CLIENTE_CONTACTO>();
            CLIENTE_GARANTIA = new HashSet<CLIENTE_GARANTIA>();
            CLIENTE_LIMITE = new HashSet<CLIENTE_LIMITE>();
            CONTRATO_COMPRA = new HashSet<CONTRATO_COMPRA>();
            CONTRATO_COMPRA_ZONA = new HashSet<CONTRATO_COMPRA_ZONA>();
            GUIA_INGRESO_CAB = new HashSet<GUIA_INGRESO_CAB>();
            LABORATORIOs = new HashSet<LABORATORIO>();
            SERVICIO_PRP_CABECERA = new HashSet<SERVICIO_PRP_CABECERA>();
            TICKET_PESADA = new HashSet<TICKET_PESADA>();
        }

        [Key]
        public int IdCliente { get; set; }

        public int IdTipoCliente { get; set; }

        public int? IdTipoOrigen { get; set; }

        public int? IdTipoDocumento { get; set; }

        [StringLength(30)]
        public string DocIdentidad { get; set; }

        [StringLength(200)]
        public string NombreComercial { get; set; }

        [StringLength(200)]
        public string RazonSocial { get; set; }

        [StringLength(200)]
        public string NombreCliente { get; set; }

        [StringLength(200)]
        public string ApellidoCliente { get; set; }

        [StringLength(25)]
        public string TelefonoPrincipal { get; set; }

        [StringLength(25)]
        public string TelefonoAlternativo { get; set; }

        public int? IdDepartamento { get; set; }

        public int? IdProvincia { get; set; }

        public int? IdDistrito { get; set; }

        [StringLength(200)]
        public string CentroPoblado { get; set; }

        [StringLength(200)]
        public string Caserio { get; set; }

        [StringLength(255)]
        public string DireccionContrato { get; set; }

        [StringLength(255)]
        public string DireccionFactura { get; set; }

        [StringLength(255)]
        public string ReferenciaFactura { get; set; }

        [StringLength(255)]
        public string DireccionInstruccion { get; set; }

        [StringLength(255)]
        public string DireccionMuestra { get; set; }

        public int? IdIdioma { get; set; }

        [StringLength(200)]
        public string NombreLegal { get; set; }

        [StringLength(200)]
        public string ApellidoLegal { get; set; }

        [StringLength(30)]
        public string DocIdentidadLegal { get; set; }

        [StringLength(25)]
        public string TelefonoLegal { get; set; }

        [StringLength(120)]
        public string CorreoLegal { get; set; }

        public int IdEstado { get; set; }

        [Required]
        [StringLength(6)]
        public string UsuarioRegistro { get; set; }

        public DateTime FechaRegistro { get; set; }

        [StringLength(6)]
        public string UsuarioModifica { get; set; }

        public DateTime? FechaModifica { get; set; }

        [StringLength(10)]
        public string IdExcel { get; set; }

        public int? IdLiderComercial { get; set; }

        [StringLength(2)]
        public string IdZona { get; set; }

        public int? CodigoLiderComercial { get; set; }

        [StringLength(30)]
        public string codCafePractice1 { get; set; }

        [StringLength(30)]
        public string codCafePractice2 { get; set; }

        [StringLength(20)]
        public string CadenaCP { get; set; }

        [StringLength(20)]
        public string FLOID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CIERRE_ANUAL> CIERRE_ANUAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENTE_BANCO> CLIENTE_BANCO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENTE_CERTIFICADO> CLIENTE_CERTIFICADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENTE_CONTACTO> CLIENTE_CONTACTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENTE_GARANTIA> CLIENTE_GARANTIA { get; set; }

        public virtual IDIOMA IDIOMA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENTE_LIMITE> CLIENTE_LIMITE { get; set; }

        public virtual TIPO_CLIENTE TIPO_CLIENTE { get; set; }

        public virtual TIPO_DOCUMENTO TIPO_DOCUMENTO { get; set; }

        public virtual TIPO_ORIGEN TIPO_ORIGEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTRATO_COMPRA> CONTRATO_COMPRA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTRATO_COMPRA_ZONA> CONTRATO_COMPRA_ZONA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GUIA_INGRESO_CAB> GUIA_INGRESO_CAB { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LABORATORIO> LABORATORIOs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICIO_PRP_CABECERA> SERVICIO_PRP_CABECERA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TICKET_PESADA> TICKET_PESADA { get; set; }
    }
}
