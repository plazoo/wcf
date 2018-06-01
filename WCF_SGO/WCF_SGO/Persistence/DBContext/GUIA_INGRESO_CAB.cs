namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GUIA_INGRESO_CAB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GUIA_INGRESO_CAB()
        {
            GUIA_INGRESO_DET = new HashSet<GUIA_INGRESO_DET>();
            SERVICIO_PRP_RESULTADO = new HashSet<SERVICIO_PRP_RESULTADO>();
        }

        [Key]
        public int IdGuia { get; set; }

        public int IdGuiaIngreso { get; set; }

        [Required]
        [StringLength(2)]
        public string IdLocal { get; set; }

        public int IdCliente { get; set; }

        public int? IdContactoCliente { get; set; }

        public int IdTipoCafe { get; set; }

        public int Cosecha { get; set; }

        [StringLength(20)]
        public string RumaDestino { get; set; }

        public decimal? PromedioRendimiento { get; set; }

        public decimal? PromedioHumedad { get; set; }

        public decimal? PromedioTaza { get; set; }

        public int TotalSaco { get; set; }

        public decimal TotalKgBruto { get; set; }

        public decimal TotalTara { get; set; }

        public decimal TotalDsctoAgua { get; set; }

        public decimal TotalKgNeto { get; set; }

        public int IdEstado { get; set; }

        [Required]
        [StringLength(6)]
        public string UsuarioRegistro { get; set; }

        public DateTime FechaRegistro { get; set; }

        [StringLength(6)]
        public string UsuarioModifica { get; set; }

        public DateTime? FechaModifica { get; set; }

        public int Impresion { get; set; }

        public int ChkLiquidacion { get; set; }

        public int? IdProceso { get; set; }

        public int IdTransito { get; set; }

        [StringLength(200)]
        public string IdCertificadoVSP { get; set; }

        [StringLength(200)]
        public string DescCertificacion { get; set; }

        [StringLength(10)]
        public string ModalidadIngreso { get; set; }

        public int? IdDivision { get; set; }

        public int? IdGuiaReferencia { get; set; }

        public int? IdProductor { get; set; }

        public int? IdIngresoPRP { get; set; }

        public int? IdOficinaOrigen { get; set; }

        public int? IdTraslado { get; set; }

        [StringLength(200)]
        public string GuiaRemisionExterna { get; set; }

        public int? IdClienteTrazabilidad { get; set; }

        public int? IdTrasladoFila { get; set; }

        public int? IdSSAsignado { get; set; }

        [StringLength(800)]
        public string Observacion { get; set; }

        public int? IdContrato { get; set; }

        public virtual CLIENTE CLIENTE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GUIA_INGRESO_DET> GUIA_INGRESO_DET { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICIO_PRP_RESULTADO> SERVICIO_PRP_RESULTADO { get; set; }
    }
}
