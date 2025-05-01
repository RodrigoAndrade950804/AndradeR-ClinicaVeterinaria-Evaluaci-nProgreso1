using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AndradeR_ClinicaVeterinaria_EvaluaciónProgreso1.Models;

namespace AndradeR_ClinicaVeterinaria_EvaluaciónProgreso1.Controllers
{
    public class VisitaVeterinariaController : Controller
    {
        private readonly AndradeR_SQL _context;

        public VisitaVeterinariaController(AndradeR_SQL context)
        {
            _context = context;
        }

        // GET: VisitaVeterinaria
        public async Task<IActionResult> Index()
        {
            return View(await _context.VisitaVeterinaria.ToListAsync());
        }

        // GET: VisitaVeterinaria/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var visitaVeterinaria = await _context.VisitaVeterinaria
                .FirstOrDefaultAsync(m => m.VisitaId == id);
            if (visitaVeterinaria == null)
            {
                return NotFound();
            }

            return View(visitaVeterinaria);
        }

        // GET: VisitaVeterinaria/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VisitaVeterinaria/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VisitaId,FechaVisita,Motivo,RequiereMedicación")] VisitaVeterinaria visitaVeterinaria)
        {
            if (ModelState.IsValid)
            {
                _context.Add(visitaVeterinaria);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(visitaVeterinaria);
        }

        // GET: VisitaVeterinaria/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var visitaVeterinaria = await _context.VisitaVeterinaria.FindAsync(id);
            if (visitaVeterinaria == null)
            {
                return NotFound();
            }
            return View(visitaVeterinaria);
        }

        // POST: VisitaVeterinaria/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VisitaId,FechaVisita,Motivo,RequiereMedicación")] VisitaVeterinaria visitaVeterinaria)
        {
            if (id != visitaVeterinaria.VisitaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(visitaVeterinaria);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VisitaVeterinariaExists(visitaVeterinaria.VisitaId))
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
            return View(visitaVeterinaria);
        }

        // GET: VisitaVeterinaria/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var visitaVeterinaria = await _context.VisitaVeterinaria
                .FirstOrDefaultAsync(m => m.VisitaId == id);
            if (visitaVeterinaria == null)
            {
                return NotFound();
            }

            return View(visitaVeterinaria);
        }

        // POST: VisitaVeterinaria/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var visitaVeterinaria = await _context.VisitaVeterinaria.FindAsync(id);
            if (visitaVeterinaria != null)
            {
                _context.VisitaVeterinaria.Remove(visitaVeterinaria);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VisitaVeterinariaExists(int id)
        {
            return _context.VisitaVeterinaria.Any(e => e.VisitaId == id);
        }
    }
}
