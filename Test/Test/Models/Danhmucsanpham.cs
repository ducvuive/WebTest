using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Test.Models
{
    public partial class Danhmucsanpham
    {
        public Danhmucsanpham()
        {
            Sanpham = new HashSet<Sanpham>();
        }

        public string Madm { get; set; }
        public string Tendm { get; set; }

        public virtual ICollection<Sanpham> Sanpham { get; set; }
    }
}
