using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FaturaYönetimSistemleri.Models.Entities
{
    public class Daire
    {
        [Key]
        public int DaireId { get; set; }

        public required string DaireNo { get; set; }
        public required string Floor { get; set; }
        public required string DaireBlock { get; set; }
        public required string HomeType { get; set; }
        public bool Status { get; set; } = false;

        public int? UserId { get; set; }
        public int? ApartmentId { get; set; }
        public virtual required User User { get; set; }
        public virtual required Apartment Apartment { get; set; }
    }
}