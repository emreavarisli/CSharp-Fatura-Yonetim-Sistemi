using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using FaturaYönetimSistemleri.Models.Entities;

namespace FaturaYönetimSistemleri.Models.DB
{
    public class Context : DbContext
    {
        public required DbSet<Admin> Admins { get; set; }
        public required DbSet<Apartment> Apartments { get; set; }
        public required DbSet<Dues> Dues { get; set; }
        public required DbSet<Invoice> Invoice { get; set; }
        public required DbSet<User> Users { get; set; }
        public required DbSet<Message> Messages { get; set; }
    }
}