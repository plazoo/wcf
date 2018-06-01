namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CBANCO_TRABAJADOR
    {
        [Key]
        public int IdCuentaBancoTrabajador { get; set; }

        [StringLength(30)]
        public string NroCuentaCheque { get; set; }

        [StringLength(30)]
        public string CodigoInterbancario { get; set; }

        public int? TipoTransaccion { get; set; }

        public int? IdTrabajador { get; set; }

        public int? IdEstado { get; set; }

        public virtual TRABAJADOR_PRP TRABAJADOR_PRP { get; set; }
    }
}
