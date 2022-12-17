using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Webbangom.Models
{
    public class Binh
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string MaSP { get; set; }
        public string Gia { get; set; }
        public string img { get; set; }
        public int DepId { get; set; }

        public virtual Main Main { get; set; }

    }
}