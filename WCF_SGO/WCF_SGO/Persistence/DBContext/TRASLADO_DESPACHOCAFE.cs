namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TRASLADO_DESPACHOCAFE
    {
        [Key]
        public int IdDespachoCafe { get; set; }

        public int? IdTraslado { get; set; }

        public DateTime? FechaSalida { get; set; }

        [StringLength(8)]
        public string HoraSalida { get; set; }

        public DateTime? FechaLlegada { get; set; }

        [StringLength(8)]
        public string HoraLlegada { get; set; }

        [StringLength(200)]
        public string GeoUrl { get; set; }

        [StringLength(20)]
        public string UsuarioGeo { get; set; }

        [StringLength(20)]
        public string ContrasenaGeo { get; set; }

        [StringLength(10)]
        public string NroMovilConductor { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public int? UsuarioRegistro { get; set; }

        public DateTime? FechaActualiza { get; set; }

        public int? UsuarioActualiza { get; set; }
    }
}
