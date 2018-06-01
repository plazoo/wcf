namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CLIENTE_GARANTIA
    {
        [Key]
        public int IdGarantia { get; set; }

        public int IdCliente { get; set; }

        public int IdRegion { get; set; }

        public int IdMoneda { get; set; }

        public decimal MontoGarantia { get; set; }

        [Required]
        [StringLength(25)]
        public string NroPartida { get; set; }

        public int IdMonedaTasacion { get; set; }

        public decimal MontoTasacion { get; set; }

        public int IdTipoInmueble { get; set; }

        public DateTime FechaHipoteca { get; set; }

        public int IdSituacionHipoteca { get; set; }

        public decimal? CoordenadaX { get; set; }

        public decimal? CoordenadaY { get; set; }

        public int IdEstado { get; set; }

        [Required]
        [StringLength(6)]
        public string UsuarioRegistro { get; set; }

        public DateTime FechaRegistro { get; set; }

        public int? IdTituloValor { get; set; }

        public int? IdTipoGarantia { get; set; }

        [StringLength(250)]
        public string DireccionGarantia { get; set; }

        public virtual CLIENTE CLIENTE { get; set; }

        public virtual TIPO_GARANTIA TIPO_GARANTIA { get; set; }

        public virtual TIPO_TITULO_VALOR TIPO_TITULO_VALOR { get; set; }

        public virtual REGION REGION { get; set; }

        public virtual SITUACION_HIPOTECA SITUACION_HIPOTECA { get; set; }

        public virtual TIPO_INMUEBLE TIPO_INMUEBLE { get; set; }

        public virtual TIPO_MONEDA TIPO_MONEDA { get; set; }

        public virtual TIPO_MONEDA TIPO_MONEDA1 { get; set; }
    }
}
