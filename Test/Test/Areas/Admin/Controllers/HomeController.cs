using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn_CuaHangLaptop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ChiTietSanPham()
        {
            return View();
        }
        public IActionResult CongKetNoi()
        {
            return View();
        }
        public IActionResult CPU()
        {
            return View();
        }
        public IActionResult DanhMuc()
        {
            return View();
        }
        public IActionResult ManHinh()
        {
            return View();
        }
        public IActionResult RAM()
        {
            return View();
        }
    }

}
