using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Test.Models
{
    public partial class Sukien
    {
        public Sukien()
        {
            Hoadon = new HashSet<Hoadon>();
        }

        public string Mask { get; set; }
        public string Tensk { get; set; }
        public int? Phantramgiamgia { get; set; }
        public DateTime? Ngaybd { get; set; }
        public DateTime? Ngaykt { get; set; }

        public virtual ICollection<Hoadon> Hoadon { get; set; }
    }
}
