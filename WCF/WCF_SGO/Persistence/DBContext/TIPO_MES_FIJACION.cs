namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TIPO_MES_FIJACION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPO_MES_FIJACION()
        {
            CONTRATO_COMPRA_UNFIXED = new HashSet<CONTRATO_COMPRA_UNFIXED>();
            PRECIO_BOLSA = new HashSet<PRECIO_BOLSA>();
        }

        [Key]
        public int IdMesFijacion { get; set; }

        [StringLength(5)]
        public string Descripcion { get; set; }

        public int? Mes { get; set; }

        public int? Anio { get; set; }

        public int IdEstado { get; set; }

        [Required]
        [StringLength(6)]
        public string UsuarioRegistro { get; set; }

        public DateTime FechaRegistro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTRATO_COMPRA_UNFIXED> CONTRATO_COMPRA_UNFIXED { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRECIO_BOLSA> PRECIO_BOLSA { get; set; }
    }
}
