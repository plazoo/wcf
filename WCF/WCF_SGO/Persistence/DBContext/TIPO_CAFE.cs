namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TIPO_CAFE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPO_CAFE()
        {
            CONTRATO_COMPRA_ZONA = new HashSet<CONTRATO_COMPRA_ZONA>();
            LABORATORIOs = new HashSet<LABORATORIO>();
            TIPO_CALIDAD_LABORATORIO = new HashSet<TIPO_CALIDAD_LABORATORIO>();
        }

        [Key]
        public int IdTipoCafe { get; set; }

        [StringLength(100)]
        public string Descripcion { get; set; }

        public int IdEstado { get; set; }

        [Required]
        [StringLength(6)]
        public string UsuarioRegistro { get; set; }

        public DateTime FechaRegistro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTRATO_COMPRA_ZONA> CONTRATO_COMPRA_ZONA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LABORATORIO> LABORATORIOs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TIPO_CALIDAD_LABORATORIO> TIPO_CALIDAD_LABORATORIO { get; set; }
    }
}
