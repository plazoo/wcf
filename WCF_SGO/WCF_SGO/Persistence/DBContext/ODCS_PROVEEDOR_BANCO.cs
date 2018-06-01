namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ODCS_PROVEEDOR_BANCO
    {
        [Key]
        [Column(Order = 0)]
        public int IdProveedorBanco { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdProveedor { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdBanco { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdMoneda { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(100)]
        public string NroCuenta { get; set; }

        [StringLength(100)]
        public string NroCuentaInterbancario { get; set; }

        [StringLength(50)]
        public string CodigoSwift { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(100)]
        public string Detraccion { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdEstado { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(6)]
        public string UsuarioRegistro { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime FechaRegistro { get; set; }
    }
}
