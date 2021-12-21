﻿using System;
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
    public class HoadonController : Controller
    {
        private readonly LapTopContext _context;

        public HoadonController(LapTopContext context)
        {
            _context = context;
        }

        // GET: Hoadon
        public async Task<IActionResult> Index()
        {
            var lapTopContext = _context.Hoadon.Include(h => h.MakhNavigation)/*.Include(h => h.ManvNavigation).Include(h => h.MaskNavigation)*/;
            return View(await lapTopContext.ToListAsync());
        }

        // GET: Hoadon/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoadon = await _context.Hoadon
                .Include(h => h.MakhNavigation)
                //.Include(h => h.ManvNavigation)
                .Include(h => h.MaskNavigation)
                .FirstOrDefaultAsync(m => m.Mahd == id);
            if (hoadon == null)
            {
                return NotFound();
            }

            return View(hoadon);
        }

        // GET: Hoadon/Create
        public IActionResult Create()
        {
            ViewData["Makh"] = new SelectList(_context.Khachhang, "Makh", "Makh");
            //ViewData["Manv"] = new SelectList(_context.Nhanvien, "Manv", "Manv");
            ViewData["Mask"] = new SelectList(_context.Sukien, "Mask", "Mask");
            return View();
        }

        // POST: Hoadon/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Mahd,Makh,Mask,Ngayhd,Nguoinhan,Sdt,Diachigiaohang,Tongtien,Thanhtien,Trangthai")] Hoadon hoadon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hoadon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Makh"] = new SelectList(_context.Khachhang, "Makh", "Makh", hoadon.Makh);
            //ViewData["Manv"] = new SelectList(_context.Nhanvien, "Manv", "Manv", hoadon.Manv);
            ViewData["Mask"] = new SelectList(_context.Sukien, "Mask", "Mask", hoadon.Mask);
            return View(hoadon);
        }

        // GET: Hoadon/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoadon = await _context.Hoadon.FindAsync(id);
            if (hoadon == null)
            {
                return NotFound();
            }
            ViewData["Makh"] = new SelectList(_context.Khachhang, "Makh", "Makh", hoadon.Makh);
            //ViewData["Manv"] = new SelectList(_context.Nhanvien, "Manv", "Manv", hoadon.Manv);
            ViewData["Mask"] = new SelectList(_context.Sukien, "Mask", "Mask", hoadon.Mask);
            return View(hoadon);
        }

        // POST: Hoadon/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Mahd,Makh,Mask,Ngayhd,Nguoinhan,Sdt,Diachigiaohang,Tongtien,Thanhtien,Trangthai")] Hoadon hoadon)
        {
            if (id != hoadon.Mahd)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hoadon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HoadonExists(hoadon.Mahd))
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
            ViewData["Makh"] = new SelectList(_context.Khachhang, "Makh", "Makh", hoadon.Makh);
            //ViewData["Manv"] = new SelectList(_context.Nhanvien, "Manv", "Manv", hoadon.Manv);
            ViewData["Mask"] = new SelectList(_context.Sukien, "Mask", "Mask", hoadon.Mask);
            return View(hoadon);
        }

        // GET: Hoadon/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoadon = await _context.Hoadon
                .Include(h => h.MakhNavigation)
                //.Include(h => h.ManvNavigation)
                .Include(h => h.MaskNavigation)
                .FirstOrDefaultAsync(m => m.Mahd == id);
            if (hoadon == null)
            {
                return NotFound();
            }

            return View(hoadon);
        }

        // POST: Hoadon/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hoadon = await _context.Hoadon.FindAsync(id);
            _context.Hoadon.Remove(hoadon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HoadonExists(int id)
        {
            return _context.Hoadon.Any(e => e.Mahd == id);
        }
    }
}
