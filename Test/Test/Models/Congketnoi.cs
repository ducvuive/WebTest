using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Test.Models
{
    public partial class Congketnoi
    {
        public Congketnoi()
        {
            Sanpham = new HashSet<Sanpham>();
        }

        public string Mackn { get; set; }
        public string Conggiaotiep { get; set; }
        public string Ketnoikhongday { get; set; }
        public string Khedocthenho { get; set; }
        public string Webcam { get; set; }
        public string Tinhnangkhac { get; set; }
        public string Denbanphim { get; set; }

        public virtual ICollection<Sanpham> Sanpham { get; set; }
    }
}
