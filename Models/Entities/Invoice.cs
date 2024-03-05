using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FaturaYönetimSistemleri.Models.Entities
{
    public class Invoice
    {
        [Key]
        public int InvoiceID { get; set; }
        public required string InvoiceSerialNumber { get; set; } // Seri No
        public required string InvoiceSequenceNo { get; set; } // Sıra No
        public required string InvoiceCompanyName { get; set; }
        public int InvoicePrice { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string? InvoiceDescription { get; set; }
        public bool InvoiceStatus { get; set; } = false;

        public int UserID { get; set; }
        public virtual required User User { get; set; }
    }
}