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
    public class DanhmucsanphamController : Controller
    {
        private readonly LapTopContext _context;

        public DanhmucsanphamController(LapTopContext context)
        {
            _context = context;
        }

        // GET: Danhmucsanpham
        public async Task<IActionResult> Index()
        {
            return View(await _context.Danhmucsanpham.ToListAsync());
        }

        // GET: Danhmucsanpham/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var danhmucsanpham = await _context.Danhmucsanpham
                .FirstOrDefaultAsync(m => m.Madm == id);
            if (danhmucsanpham == null)
            {
                return NotFound();
            }

            return View(danhmucsanpham);
        }

        // GET: Danhmucsanpham/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Danhmucsanpham/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Madm,Tendm")] Danhmucsanpham danhmucsanpham)
        {
            if (ModelState.IsValid)
            {
                _context.Add(danhmucsanpham);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(danhmucsanpham);
        }

        // GET: Danhmucsanpham/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var danhmucsanpham = await _context.Danhmucsanpham.FindAsync(id);
            if (danhmucsanpham == null)
            {
                return NotFound();
            }
            return View(danhmucsanpham);
        }

        // POST: Danhmucsanpham/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Madm,Tendm")] Danhmucsanpham danhmucsanpham)
        {
            if (id != danhmucsanpham.Madm)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(danhmucsanpham);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DanhmucsanphamExists(danhmucsanpham.Madm))
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
            return View(danhmucsanpham);
        }

        // GET: Danhmucsanpham/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var danhmucsanpham = await _context.Danhmucsanpham
                .FirstOrDefaultAsync(m => m.Madm == id);
            if (danhmucsanpham == null)
            {
                return NotFound();
            }

            return View(danhmucsanpham);
        }

        // POST: Danhmucsanpham/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var danhmucsanpham = await _context.Danhmucsanpham.FindAsync(id);
            _context.Danhmucsanpham.Remove(danhmucsanpham);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DanhmucsanphamExists(string id)
        {
            return _context.Danhmucsanpham.Any(e => e.Madm == id);
        }
    }
}
