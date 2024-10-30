using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cabrera_Soledad_examen_progreso_1.Data;
using Cabrera_Soledad_examen_progreso_1.Models;

namespace Cabrera_Soledad_examen_progreso_1.Controllers
{
    public class SCabrerasController : Controller
    {
        private readonly Cabrera_Soledad_examen_progreso_1Context _context;

        public SCabrerasController(Cabrera_Soledad_examen_progreso_1Context context)
        {
            _context = context;
        }

        // GET: SCabreras
        public async Task<IActionResult> Index()
        {
            var cabrera_Soledad_examen_progreso_1Context = _context.SCabrera.Include(s => s.Celular);
            return View(await cabrera_Soledad_examen_progreso_1Context.ToListAsync());
        }

        // GET: SCabreras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sCabrera = await _context.SCabrera
                .Include(s => s.Celular)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sCabrera == null)
            {
                return NotFound();
            }

            return View(sCabrera);
        }

        // GET: SCabreras/Create
        public IActionResult Create()
        {
            ViewData["IdCelular"] = new SelectList(_context.Celular, "Id", "Id");
            return View();
        }

        // POST: SCabreras/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Edad,Nombre,SabeIngles,Promedio,Cumpleanios,IdCelular")] SCabrera sCabrera)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sCabrera);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCelular"] = new SelectList(_context.Celular, "Id", "Id", sCabrera.IdCelular);
            return View(sCabrera);
        }

        // GET: SCabreras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sCabrera = await _context.SCabrera.FindAsync(id);
            if (sCabrera == null)
            {
                return NotFound();
            }
            ViewData["IdCelular"] = new SelectList(_context.Celular, "Id", "Id", sCabrera.IdCelular);
            return View(sCabrera);
        }

        // POST: SCabreras/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Edad,Nombre,SabeIngles,Promedio,Cumpleanios,IdCelular")] SCabrera sCabrera)
        {
            if (id != sCabrera.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sCabrera);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SCabreraExists(sCabrera.Id))
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
            ViewData["IdCelular"] = new SelectList(_context.Celular, "Id", "Id", sCabrera.IdCelular);
            return View(sCabrera);
        }

        // GET: SCabreras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sCabrera = await _context.SCabrera
                .Include(s => s.Celular)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sCabrera == null)
            {
                return NotFound();
            }

            return View(sCabrera);
        }

        // POST: SCabreras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sCabrera = await _context.SCabrera.FindAsync(id);
            if (sCabrera != null)
            {
                _context.SCabrera.Remove(sCabrera);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SCabreraExists(int id)
        {
            return _context.SCabrera.Any(e => e.Id == id);
        }
    }
}
