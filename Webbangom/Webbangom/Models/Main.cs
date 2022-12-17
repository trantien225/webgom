using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Webbangom.Models
{
    public class Main
    {
        [Key]
        public int DepID { get; set; }
        public string Name { get; set; }
        public string img { get; set; }
        public string note { get; set; }
    }
}