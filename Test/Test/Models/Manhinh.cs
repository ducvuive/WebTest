using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Test.Models
{
    public partial class Manhinh
    {
        public Manhinh()
        {
            Sanpham = new HashSet<Sanpham>();
        }

        public string Mamh { get; set; }
        public string Kichthuoc { get; set; }
        public string Dophangiai { get; set; }
        public string Tansoquet { get; set; }
        public string Congnghemh { get; set; }
        public string Camung { get; set; }

        public virtual ICollection<Sanpham> Sanpham { get; set; }
    }
}
