namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SOLICITUD_VISITA
    {
        [Key]
        [StringLength(9)]
        public string IdSolicitud { get; set; }

        [StringLength(200)]
        public string RazonSocial { get; set; }

        [StringLength(100)]
        public string NombreVisita { get; set; }

        [StringLength(100)]
        public string ApellidoVisita { get; set; }

        [StringLength(20)]
        public string NumDocumento { get; set; }

        public DateTime? FechaVisita { get; set; }

        public int? IdMotivoVisita { get; set; }

        public int? IdTipoVisita { get; set; }

        [StringLength(30)]
        public string NumPlaca { get; set; }

        [StringLength(30)]
        public string NumTracto { get; set; }

        [StringLength(20)]
        public string NumContenedor { get; set; }

        [StringLength(100)]
        public string NombreChofer { get; set; }

        [StringLength(100)]
        public string ApellidoChofer { get; set; }

        public string Comentario { get; set; }

        public int? IdEstado { get; set; }

        public int UsuarioRegistro { get; set; }

        public DateTime FechaRegistro { get; set; }

        public int? UsuarioIngreso { get; set; }

        public DateTime? FechaIngreso { get; set; }

        public int? UsuarioSalida { get; set; }

        public DateTime? FechaSalida { get; set; }

        public int? UsuarioCancela { get; set; }

        public DateTime? FechaCancela { get; set; }

        public virtual ESTADO ESTADO { get; set; }

        public virtual MOTIVO_VISITA MOTIVO_VISITA { get; set; }

        public virtual TIPO_VISITA TIPO_VISITA { get; set; }
    }
}
