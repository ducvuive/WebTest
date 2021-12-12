using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Test.Models
{
    public partial class Boxuly
    {
        public Boxuly()
        {
            Sanpham = new HashSet<Sanpham>();
        }

        public string Mabxl { get; set; }
        public string Congnghecpu { get; set; }
        public int? Sonhan { get; set; }
        public int? Soluong { get; set; }
        public string Tocdocpu { get; set; }
        public string Tocdotoida { get; set; }
        public string Bonhodem { get; set; }

        public virtual ICollection<Sanpham> Sanpham { get; set; }
    }
}
