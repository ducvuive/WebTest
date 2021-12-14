using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using Test.Data;
using Test.Models;

namespace Test.Controllers
{
    public class SanphamController : Controller
    {
        private readonly LapTopContext _context;

        private readonly IConfiguration _configuration;
        public SanphamController(LapTopContext context, IConfiguration config)
        {
            _context = context;
            _configuration = config;
        }

        // GET: Sanpham
        public async Task<IActionResult> Index()
        {
            var lapTopContext = _context.Sanpham.Include(s => s.BoxulyNavigation).Include(s => s.CongketnoiNavigation).Include(s => s.DanhmucNavigation).Include(s => s.ManhinhNavigation).Include(s => s.RamNavigation);
            return View(await lapTopContext.ToListAsync());
        }

        // GET: Sanpham/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanpham = await _context.Sanpham
                .Include(s => s.BoxulyNavigation)
                .Include(s => s.CongketnoiNavigation)
                .Include(s => s.DanhmucNavigation)
                .Include(s => s.ManhinhNavigation)
                .Include(s => s.RamNavigation)
                .FirstOrDefaultAsync(m => m.Masp == id);
            if (sanpham == null)
            {
                return NotFound();
            }

            return View(sanpham);
        }

        // GET: Sanpham/Create
        public IActionResult Create()
        {
            ViewData["Boxuly"] = new SelectList(_context.Boxuly, "Mabxl", "Mabxl");
            ViewData["Congketnoi"] = new SelectList(_context.Congketnoi, "Mackn", "Mackn");
            ViewData["Danhmuc"] = new SelectList(_context.Danhmucsanpham, "Madm", "Madm");
            ViewData["Manhinh"] = new SelectList(_context.Manhinh, "Mamh", "Mamh");
            ViewData["Ram"] = new SelectList(_context.Bonhoram, "Maram", "Maram");
            return View();
        }

        // POST: Sanpham/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Masp,Manhinh,Boxuly,Ram,Congketnoi,Danhmuc,Tensp,Soluong,Mausac,Ocung,Cardmanhinh,Dacbiet,Hdh,Thietke,KichthuocTrongluong,Webcam,Pin,Ramat,Mota,Dongia,Hinhanh")] Sanpham sanpham)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sanpham);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Boxuly"] = new SelectList(_context.Boxuly, "Mabxl", "Mabxl", sanpham.Boxuly);
            ViewData["Congketnoi"] = new SelectList(_context.Congketnoi, "Mackn", "Mackn", sanpham.Congketnoi);
            ViewData["Danhmuc"] = new SelectList(_context.Danhmucsanpham, "Madm", "Madm", sanpham.Danhmuc);
            ViewData["Manhinh"] = new SelectList(_context.Manhinh, "Mamh", "Mamh", sanpham.Manhinh);
            ViewData["Ram"] = new SelectList(_context.Bonhoram, "Maram", "Maram", sanpham.Ram);
            return View(sanpham);
        }

        // GET: Sanpham/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanpham = await _context.Sanpham.FindAsync(id);
            if (sanpham == null)
            {
                return NotFound();
            }
            ViewData["Boxuly"] = new SelectList(_context.Boxuly, "Mabxl", "Mabxl", sanpham.Boxuly);
            ViewData["Congketnoi"] = new SelectList(_context.Congketnoi, "Mackn", "Mackn", sanpham.Congketnoi);
            ViewData["Danhmuc"] = new SelectList(_context.Danhmucsanpham, "Madm", "Madm", sanpham.Danhmuc);
            ViewData["Manhinh"] = new SelectList(_context.Manhinh, "Mamh", "Mamh", sanpham.Manhinh);
            ViewData["Ram"] = new SelectList(_context.Bonhoram, "Maram", "Maram", sanpham.Ram);
            return View(sanpham);
        }

        // POST: Sanpham/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Masp,Manhinh,Boxuly,Ram,Congketnoi,Danhmuc,Tensp,Soluong,Mausac,Ocung,Cardmanhinh,Dacbiet,Hdh,Thietke,KichthuocTrongluong,Webcam,Pin,Ramat,Mota,Dongia,Hinhanh")] Sanpham sanpham)
        {
            if (id != sanpham.Masp)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sanpham);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SanphamExists(sanpham.Masp))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Boxuly"] = new SelectList(_context.Boxuly, "Mabxl", "Mabxl", sanpham.Boxuly);
            ViewData["Congketnoi"] = new SelectList(_context.Congketnoi, "Mackn", "Mackn", sanpham.Congketnoi);
            ViewData["Danhmuc"] = new SelectList(_context.Danhmucsanpham, "Madm", "Madm", sanpham.Danhmuc);
            ViewData["Manhinh"] = new SelectList(_context.Manhinh, "Mamh", "Mamh", sanpham.Manhinh);
            ViewData["Ram"] = new SelectList(_context.Bonhoram, "Maram", "Maram", sanpham.Ram);
            return View(sanpham);
        }

        // GET: Sanpham/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanpham = await _context.Sanpham
                .Include(s => s.BoxulyNavigation)
                .Include(s => s.CongketnoiNavigation)
                .Include(s => s.DanhmucNavigation)
                .Include(s => s.ManhinhNavigation)
                .Include(s => s.RamNavigation)
                .FirstOrDefaultAsync(m => m.Masp == id);
            if (sanpham == null)
            {
                return NotFound();
            }

            return View(sanpham);
        }

        // POST: Sanpham/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var sanpham = await _context.Sanpham.FindAsync(id);
            _context.Sanpham.Remove(sanpham);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SanphamExists(string id)
        {
            return _context.Sanpham.Any(e => e.Masp == id);
        }

        private List<Sanpham> LayDSSPTheoTrang(int page)
        {
            List<Sanpham> list = new List<Sanpham>();
            string connStr = _configuration.GetConnectionString("DefaultConnection");
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string query = "select * from SanPham LIMIT @page,12";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@page", (page - 1) * 12);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new Sanpham()
                    {
                        Masp = reader["MaSP"].ToString(),
                        Manhinh = reader["ManHinh"].ToString(),
                        Boxuly = reader["BoXuLy"].ToString(),
                        Ram = reader["RAM"].ToString(),
                        Congketnoi = reader["CongKetNoi"].ToString(),
                        Danhmuc = reader["DanhMuc"].ToString(),
                        Tensp = reader["TenSP"].ToString(),
                        Soluong = Convert.ToInt32(reader["SoLuong"]),
                        Mausac = reader["MauSac"].ToString(),
                        Ocung = reader["OCung"].ToString(),
                        Cardmanhinh = reader["CardManHinh"].ToString(),
                        Dacbiet = reader["DacBiet"]?.ToString(),
                        Hdh = reader["HDH"].ToString(),
                        Thietke = reader["ThietKe"].ToString(),
                        KichthuocTrongluong = reader["KichThuoc_TrongLuong"].ToString(),
                        Webcam = reader["Webcam"]?.ToString(),
                        Pin = reader["Pin"].ToString(),
                        Ramat = Convert.ToInt32(reader["RaMat"]),
                        Mota = reader["MoTa"].ToString(),
                        Dongia = Convert.ToInt64(reader["DonGia"]),
                        Hinhanh = reader["HinhAnh"].ToString(),
                    });

                }
            }

            return list;

        }

        private List<Sanpham> LayDSSPTheoDanhMuc(string madm)
        {
            List<Sanpham> list = new List<Sanpham>();
            string connStr = _configuration.GetConnectionString("DefaultConnection");
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string query = "select * from SanPham where DANHMUC = @madm";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@madm", madm);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new Sanpham()
                    {
                        Masp = reader["MaSP"].ToString(),
                        Manhinh = reader["ManHinh"].ToString(),
                        Boxuly = reader["BoXuLy"].ToString(),
                        Ram = reader["RAM"].ToString(),
                        Congketnoi = reader["CongKetNoi"].ToString(),
                        Danhmuc = reader["DanhMuc"].ToString(),
                        Tensp = reader["TenSP"].ToString(),
                        Soluong = Convert.ToInt32(reader["SoLuong"]),
                        Mausac = reader["MauSac"].ToString(),
                        Ocung = reader["OCung"].ToString(),
                        Cardmanhinh = reader["CardManHinh"].ToString(),
                        Dacbiet = reader["DacBiet"]?.ToString(),
                        Hdh = reader["HDH"].ToString(),
                        Thietke = reader["ThietKe"].ToString(),
                        KichthuocTrongluong = reader["KichThuoc_TrongLuong"].ToString(),
                        Webcam = reader["Webcam"]?.ToString(),
                        Pin = reader["Pin"].ToString(),
                        Ramat = Convert.ToInt32(reader["RaMat"]),
                        Mota = reader["MoTa"].ToString(),
                        Dongia = Convert.ToInt64(reader["DonGia"]),
                        Hinhanh = reader["HinhAnh"].ToString(),
                    });

                }
            }

            return list;

        }

        private List<Sanpham> LayDSSPTheoDanhMucTheoTrang(string madm, int page)
        {
            List<Sanpham> list = new List<Sanpham>();
            string connStr = _configuration.GetConnectionString("DefaultConnection");
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string query = "select * from SanPham where DANHMUC = @madm LIMIT @page,6 ;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@madm", madm);
            cmd.Parameters.AddWithValue("@page", page * 6);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new Sanpham()
                    {
                        Masp = reader["MaSP"].ToString(),
                        Manhinh = reader["ManHinh"].ToString(),
                        Boxuly = reader["BoXuLy"].ToString(),
                        Ram = reader["RAM"].ToString(),
                        Congketnoi = reader["CongKetNoi"].ToString(),
                        Danhmuc = reader["DanhMuc"].ToString(),
                        Tensp = reader["TenSP"].ToString(),
                        Soluong = Convert.ToInt32(reader["SoLuong"]),
                        Mausac = reader["MauSac"].ToString(),
                        Ocung = reader["OCung"].ToString(),
                        Cardmanhinh = reader["CardManHinh"].ToString(),
                        Dacbiet = reader["DacBiet"]?.ToString(),
                        Hdh = reader["HDH"].ToString(),
                        Thietke = reader["ThietKe"].ToString(),
                        KichthuocTrongluong = reader["KichThuoc_TrongLuong"].ToString(),
                        Webcam = reader["Webcam"]?.ToString(),
                        Pin = reader["Pin"].ToString(),
                        Ramat = Convert.ToInt32(reader["RaMat"]),
                        Mota = reader["MoTa"].ToString(),
                        Dongia = Convert.ToInt64(reader["DonGia"]),
                        Hinhanh = reader["HinhAnh"].ToString(),
                    });

                }
            }

            return list;

        }

        // GET: Sanpham
        public async Task<IActionResult> Shop(string madm, int page)
        {
            var lapTopContext = _context.Sanpham.Include(s => s.BoxulyNavigation).Include(s => s.CongketnoiNavigation).Include(s => s.DanhmucNavigation).Include(s => s.ManhinhNavigation).Include(s => s.RamNavigation);
            List<Sanpham> spList = new List<Sanpham>();
            double totalPage;
            if (string.IsNullOrEmpty(madm))
            {
                spList = lapTopContext.ToList();
                float temp = spList.Count() / (float)12;
                totalPage = Math.Ceiling(temp);
                if (page == 0)
                {
                    spList = spList.Take(12).ToList();
                }
                else
                {
                    spList = LayDSSPTheoTrang(page);
                }
            }
            else
            {
                spList = LayDSSPTheoDanhMuc(madm);
                float temp = spList.Count() / (float)12;
                totalPage = Math.Ceiling(temp);
                if (page == 0)
                {
                    spList = spList.Take(12).ToList();
                }
                else
                {
                    spList = LayDSSPTheoDanhMucTheoTrang(madm, page);
                }
            }

            ViewBag.dmSP = _context.Danhmucsanpham.ToList();
            ViewBag.totalPage = totalPage;
            ViewBag.pageCurrent = page;
            return View(spList);

        }

        // GET: Sanpham/Details/5
        public async Task<IActionResult> ProductSingle(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanpham = _context.Sanpham.Find(id);

            ViewData["BXL"] = _context.Boxuly.Find(sanpham.Boxuly);
            ViewData["RAM"] = _context.Bonhoram.Find(sanpham.Ram);
            ViewData["MH"] = _context.Manhinh.Find(sanpham.Manhinh);
            ViewData["CKN"] = _context.Congketnoi.Find(sanpham.Congketnoi);
            ViewData["SanPham"] = sanpham;
            if (sanpham == null)
            {
                return NotFound();
            }

            return View(sanpham);
        }
    }
}
