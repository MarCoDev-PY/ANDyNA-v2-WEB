using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ANDyNA_v2.Data;
using ANDyNA_v2.Models;

namespace ANDyNA_v2
{
    public class CanchasController : Controller
    {
        private readonly ANDyNA_v2Context _context;

        public CanchasController(ANDyNA_v2Context context)
        {
            _context = context;
        }

        // GET: Canchas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Canchas.ToListAsync());
        }

        // GET: Canchas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var canchas = await _context.Canchas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (canchas == null)
            {
                return NotFound();
            }

            return View(canchas);
        }

        // GET: Canchas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Canchas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,costo,HoraInicio,HoraFinal,Detalles,Fecha,Horas")] Canchas canchas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(canchas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(canchas);
        }

        // GET: Canchas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var canchas = await _context.Canchas.FindAsync(id);
            if (canchas == null)
            {
                return NotFound();
            }
            return View(canchas);
        }

        // POST: Canchas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,costo,HoraInicio,HoraFinal,Detalles,Fecha,Horas")] Canchas canchas)
        {
            if (id != canchas.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(canchas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CanchasExists(canchas.Id))
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
            return View(canchas);
        }

        // GET: Canchas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var canchas = await _context.Canchas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (canchas == null)
            {
                return NotFound();
            }

            return View(canchas);
        }

        // POST: Canchas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var canchas = await _context.Canchas.FindAsync(id);
            if (canchas != null)
            {
                _context.Canchas.Remove(canchas);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CanchasExists(int id)
        {
            return _context.Canchas.Any(e => e.Id == id);
        }
    }
}
