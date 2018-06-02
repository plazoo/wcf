namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CLIENTE_BANCO
    {
        [Key]
        public int IdClienteBanco { get; set; }

        public int IdCliente { get; set; }

        public int IdBanco { get; set; }

        public int IdMoneda { get; set; }

        [Required]
        [StringLength(100)]
        public string NroCuenta { get; set; }

        [StringLength(100)]
        public string NroCuentaInterbancario { get; set; }

        [StringLength(50)]
        public string CodigoSwift { get; set; }

        [Required]
        [StringLength(100)]
        public string Detraccion { get; set; }

        public int IdEstado { get; set; }

        [Required]
        [StringLength(6)]
        public string UsuarioRegistro { get; set; }

        public DateTime FechaRegistro { get; set; }

        public virtual BANCO BANCO { get; set; }

        public virtual CLIENTE CLIENTE { get; set; }

        public virtual TIPO_MONEDA TIPO_MONEDA { get; set; }
    }
}
