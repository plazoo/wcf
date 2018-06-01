namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CLIENTE_CERTIFICADO
    {
        [Key]
        public int IdClienteCertificado { get; set; }

        public int IdCliente { get; set; }

        public int IdCertificadoVSP { get; set; }

        public decimal Limite { get; set; }

        public int Sobregiro { get; set; }

        public int IdEstado { get; set; }

        [Required]
        [StringLength(6)]
        public string UsuarioRegistro { get; set; }

        public DateTime FechaRegistro { get; set; }

        public virtual CERTIFICADO_VSP CERTIFICADO_VSP { get; set; }

        public virtual CLIENTE CLIENTE { get; set; }
    }
}
