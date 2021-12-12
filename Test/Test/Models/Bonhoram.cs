using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Test.Models
{
    public partial class Bonhoram
    {
        public Bonhoram()
        {
            Sanpham = new HashSet<Sanpham>();
        }

        public string Maram { get; set; }
        public string Dungluongram { get; set; }
        public string Loairam { get; set; }
        public string Busram { get; set; }
        public string Hotrotoida { get; set; }

        public virtual ICollection<Sanpham> Sanpham { get; set; }
    }
}
