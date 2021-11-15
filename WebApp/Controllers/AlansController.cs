using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class AlansController : Controller
    {
        private readonly WebAppContext _context;

        public AlansController(WebAppContext context)
        {
            _context = context;
        }

        // GET: Alans
        public async Task<IActionResult> Index()
        {
            return View(await _context.Alan.ToListAsync());
        }

        // GET: Alans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alan = await _context.Alan
                .FirstOrDefaultAsync(m => m.AlanID == id);
            if (alan == null)
            {
                return NotFound();
            }

            return View(alan);
        }

        // GET: Alans/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Alans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AlanID,AlanAdi,AlanTipi")] Alan alan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(alan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(alan);
        }

        // GET: Alans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alan = await _context.Alan.FindAsync(id);
            if (alan == null)
            {
                return NotFound();
            }
            return View(alan);
        }

        // POST: Alans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AlanID,AlanAdi,AlanTipi")] Alan alan)
        {
            if (id != alan.AlanID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(alan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlanExists(alan.AlanID))
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
            return View(alan);
        }

        // GET: Alans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alan = await _context.Alan
                .FirstOrDefaultAsync(m => m.AlanID == id);
            if (alan == null)
            {
                return NotFound();
            }

            return View(alan);
        }

        // POST: Alans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var alan = await _context.Alan.FindAsync(id);
            _context.Alan.Remove(alan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlanExists(int id)
        {
            return _context.Alan.Any(e => e.AlanID == id);
        }
    }
}
