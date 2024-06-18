using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using semana4.Datos;
using semana4.Models;
using semana4.ViewModels;

namespace semana4.Controllers
{
    public class FuncionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FuncionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Funcions
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index()
        {
            var funciones = await _context.Funcion.ToListAsync();

            var model = funciones.Select(funcion => new FuncionViewModel
            {
                Funcion = funcion,
                PeliculaTitulo = _context.Peliculas.FirstOrDefault(p => p.PeliculaId == funcion.IdPelicula)?.Titulo // Corrección aquí
            });

            return View(model);
        }

        // GET: Funcions/Details/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funcion = await _context.Funcion
                .FirstOrDefaultAsync(m => m.IdFuncion == id);
            if (funcion == null)
            {
                return NotFound();
            }

            return View(funcion);
        }

        // GET: Funcions/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            ViewData["IdPelicula"] = new SelectList(_context.Peliculas, "PeliculaId", "Titulo"); // Cargamos las películas con título
            return View();
        }

        // POST: Funcions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdFuncion,Dia,Horario,Lenguaje,IdPelicula")] Funcion funcion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(funcion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(funcion);
        }

        // GET: Funcions/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funcion = await _context.Funcion.FindAsync(id);
            if (funcion == null)
            {
                return NotFound();
            }
            ViewData["IdPelicula"] = new SelectList(_context.Peliculas, "PeliculaId", "Titulo", funcion.IdPelicula);

            return View(funcion);
        }

        // POST: Funcions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdFuncion,Dia,Horario,Lenguaje,IdPelicula")] Funcion funcion)
        {
            if (id != funcion.IdFuncion)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(funcion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FuncionExists(funcion.IdFuncion))
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
            return View(funcion);
        }

        // GET: Funcions/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funcion = await _context.Funcion
                .FirstOrDefaultAsync(m => m.IdFuncion == id);
            if (funcion == null)
            {
                return NotFound();
            }

            return View(funcion);
        }

        // POST: Funcions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var funcion = await _context.Funcion.FindAsync(id);
            if (funcion != null)
            {
                _context.Funcion.Remove(funcion);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FuncionExists(int id)
        {
            return _context.Funcion.Any(e => e.IdFuncion == id);
        }
    }
}
