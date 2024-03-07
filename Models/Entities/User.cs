using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FaturaYönetimSistemleri.Models.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string TCNo { get; set; }
        public required string Phone { get; set; }
        public bool ApartmentOwner { get; set; }
        public bool IsDelete { get; set; }
        public int? DaireId { get; set; }

        public virtual required ICollection<Apartment> Apartment { get; set; }
        public virtual required ICollection<Daire> Daire { get; set; }

        public required ICollection<Dues> Dues { get; set; }
        public required ICollection<Invoice> Invoice { get; set; }
    }
}