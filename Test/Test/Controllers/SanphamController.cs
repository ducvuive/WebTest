using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Test.Data;
using Test.Models;
namespace Test.Controllers
{
    public class SanphamController : Controller
    {
        private readonly LapTopContext _context;

        public SanphamController(LapTopContext context)
        {
            _context = context;
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
    }
}
