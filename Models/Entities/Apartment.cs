using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FaturaYönetimSistemleri.Models.Entities
{
    public class Apartment
    {
        [Key]
        public int ApartmentId { get; set; }
        public required string ApartmentName { get; set; }
        public required string Il { get; set; }
        public required string Ilce { get; set; }
        public required string Sokak { get; set; }
        public bool Status { get; set; } = false;
        public int? UserId { get; set; }
        public virtual required User User { get; set; }
    }
}