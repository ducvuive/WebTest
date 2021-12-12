using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Test.Models
{
    public partial class Hoadon
    {
        public Hoadon()
        {
            Cthd = new HashSet<Cthd>();
        }

        public string Mahd { get; set; }
        public string Makh { get; set; }
        public string Manv { get; set; }
        public string Mask { get; set; }
        public DateTime? Ngayhd { get; set; }
        public string Diachigiaohang { get; set; }
        public int? Tongtien { get; set; }
        public int? Thanhtien { get; set; }

        public virtual Khachhang MakhNavigation { get; set; }
        public virtual Nhanvien ManvNavigation { get; set; }
        public virtual Sukien MaskNavigation { get; set; }
        public virtual ICollection<Cthd> Cthd { get; set; }
    }
}
