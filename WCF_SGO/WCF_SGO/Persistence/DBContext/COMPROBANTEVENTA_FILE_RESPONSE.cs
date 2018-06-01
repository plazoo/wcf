namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COMPROBANTEVENTA_FILE_RESPONSE
    {
        [Key]
        public int IdComprobanteFileResponse { get; set; }

        public int IdComprobanteFile { get; set; }

        [Required]
        [StringLength(15)]
        public string ProcessReceptionId { get; set; }

        [Required]
        [StringLength(10)]
        public string IssueDate { get; set; }

        [Required]
        [StringLength(11)]
        public string IssueTime { get; set; }

        [Required]
        [StringLength(10)]
        public string ResponseDate { get; set; }

        [Required]
        [StringLength(11)]
        public string ResponseTime { get; set; }

        public string ResponseNote { get; set; }

        [Required]
        [StringLength(11)]
        public string SenderParty_RUC { get; set; }

        [Required]
        [StringLength(11)]
        public string ReceiverParty_RUC { get; set; }

        [Required]
        [StringLength(11)]
        public string RecipientParty_RUC { get; set; }

        [Required]
        [StringLength(4)]
        public string ResponseCode { get; set; }

        [Required]
        [StringLength(23)]
        public string DocumentSentId { get; set; }

        [Required]
        [StringLength(23)]
        public string ProcessedDocumentId { get; set; }

        [Required]
        [StringLength(100)]
        public string ResponseDescription { get; set; }

        [StringLength(344)]
        public string SignatureValue { get; set; }

        [Required]
        [StringLength(90)]
        public string DigestValue { get; set; }

        [Required]
        [StringLength(50)]
        public string ResponseFileName { get; set; }

        [StringLength(20)]
        public string ResponseTicket { get; set; }

        [Required]
        [StringLength(1)]
        public string ResponseStatus { get; set; }

        public DateTime? FechaRegistra { get; set; }

        public int? UsuarioRegistra { get; set; }

        [StringLength(8000)]
        public string Trama { get; set; }

        public int? IdEstado { get; set; }

        public virtual COMPROBANTEVENTA_FILE COMPROBANTEVENTA_FILE { get; set; }
    }
}
