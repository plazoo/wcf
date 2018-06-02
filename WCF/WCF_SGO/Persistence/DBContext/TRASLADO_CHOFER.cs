namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TRASLADO_CHOFER
    {
        [Key]
        public int IdChofer { get; set; }

        public int? IdEmpresaTransporte { get; set; }

        [StringLength(200)]
        public string NombreChofer { get; set; }

        [StringLength(200)]
        public string ApellidoChofer { get; set; }

        [StringLength(100)]
        public string Vehiculo { get; set; }

        [StringLength(100)]
        public string NroInscripcion { get; set; }

        [StringLength(100)]
        public string Licencia { get; set; }

        public int IdEstado { get; set; }

        public int? BlackList { get; set; }

        [StringLength(10)]
        public string UsuarioBL { get; set; }

        public DateTime? FechaBL { get; set; }

        [StringLength(8)]
        public string DniChofer { get; set; }

        [StringLength(250)]
        public string Comentario { get; set; }
    }
}
