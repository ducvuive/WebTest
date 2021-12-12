using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Test.Models
{
    public partial class Khachhang
    {
        public Khachhang()
        {
            Hoadon = new HashSet<Hoadon>();
        }

        public string Makh { get; set; }
        public string Tendangnhap { get; set; }
        public string Tenkh { get; set; }
        public string Sodt { get; set; }
        public string Email { get; set; }
        public string Gioitinh { get; set; }

        public virtual Taikhoan TendangnhapNavigation { get; set; }
        public virtual ICollection<Hoadon> Hoadon { get; set; }
    }
}
