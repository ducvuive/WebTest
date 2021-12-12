using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Test.Models
{
    public partial class Sanpham
    {
        public Sanpham()
        {
            Cthd = new HashSet<Cthd>();
        }

        public string Masp { get; set; }
        public string Manhinh { get; set; }
        public string Boxuly { get; set; }
        public string Ram { get; set; }
        public string Congketnoi { get; set; }
        public string Danhmuc { get; set; }
        public string Tensp { get; set; }
        public int? Soluong { get; set; }
        public string Mausac { get; set; }
        public string Ocung { get; set; }
        public string Cardmanhinh { get; set; }
        public string Dacbiet { get; set; }
        public string Hdh { get; set; }
        public string Thietke { get; set; }
        public string KichthuocTrongluong { get; set; }
        public string Webcam { get; set; }
        public string Pin { get; set; }
        public int? Ramat { get; set; }
        public string Mota { get; set; }
        public long? Dongia { get; set; }
        public string Hinhanh { get; set; }

        public virtual Boxuly BoxulyNavigation { get; set; }
        public virtual Congketnoi CongketnoiNavigation { get; set; }
        public virtual Danhmucsanpham DanhmucNavigation { get; set; }
        public virtual Manhinh ManhinhNavigation { get; set; }
        public virtual Bonhoram RamNavigation { get; set; }
        public virtual ICollection<Cthd> Cthd { get; set; }
    }
}
