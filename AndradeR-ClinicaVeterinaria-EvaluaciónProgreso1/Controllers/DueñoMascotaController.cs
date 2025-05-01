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
    public class DueñoMascotaController : Controller
    {
        private readonly AndradeR_SQL _context;

        public DueñoMascotaController(AndradeR_SQL context)
        {
            _context = context;
        }

        // GET: DueñoMascota
        public async Task<IActionResult> Index()
        {
            return View(await _context.DueñoMascota.ToListAsync());
        }

        // GET: DueñoMascota/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dueñoMascota = await _context.DueñoMascota
                .FirstOrDefaultAsync(m => m.DueñoId == id);
            if (dueñoMascota == null)
            {
                return NotFound();
            }

            return View(dueñoMascota);
        }

        // GET: DueñoMascota/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DueñoMascota/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DueñoId,Nombre,SaldoPendiente,EsClienteFrecuente,FechaRegistro")] DueñoMascota dueñoMascota)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dueñoMascota);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dueñoMascota);
        }

        // GET: DueñoMascota/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dueñoMascota = await _context.DueñoMascota.FindAsync(id);
            if (dueñoMascota == null)
            {
                return NotFound();
            }
            return View(dueñoMascota);
        }

        // POST: DueñoMascota/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DueñoId,Nombre,SaldoPendiente,EsClienteFrecuente,FechaRegistro")] DueñoMascota dueñoMascota)
        {
            if (id != dueñoMascota.DueñoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dueñoMascota);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DueñoMascotaExists(dueñoMascota.DueñoId))
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
            return View(dueñoMascota);
        }

        // GET: DueñoMascota/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dueñoMascota = await _context.DueñoMascota
                .FirstOrDefaultAsync(m => m.DueñoId == id);
            if (dueñoMascota == null)
            {
                return NotFound();
            }

            return View(dueñoMascota);
        }

        // POST: DueñoMascota/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dueñoMascota = await _context.DueñoMascota.FindAsync(id);
            if (dueñoMascota != null)
            {
                _context.DueñoMascota.Remove(dueñoMascota);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DueñoMascotaExists(int id)
        {
            return _context.DueñoMascota.Any(e => e.DueñoId == id);
        }
    }
}
