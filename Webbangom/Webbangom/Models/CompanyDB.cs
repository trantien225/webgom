using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Webbangom.Models
{
    public class CompanyDB:DbContext
    {
        public CompanyDB() : base("MyCS") { }
        public DbSet<Main> Mains { get; set; }
        public DbSet<Amtra> Amtras { get; set; }
        public DbSet<Binh> Binhs { get; set; }
        public DbSet<Dia> Dias { get; set; }
    }
}