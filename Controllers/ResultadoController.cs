using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LaboratorioExame.Models;

namespace LaboratorioExame.Controllers
{
    public class ResultadoController : Controller
    {
        private readonly Contexto _context;

        public ResultadoController(Contexto context)
        {
            _context = context;
        }

        // GET: Resultado
        public async Task<IActionResult> Index()
        {
            var contexto = _context.Resultado.Include(r => r.Exame).Include(r => r.Paciente).Include(r => r.Profissional);
            return View(await contexto.ToListAsync());
        }

        // GET: Resultado/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Resultado == null)
            {
                return NotFound();
            }

            var resultado = await _context.Resultado
                .Include(r => r.Exame)
                .Include(r => r.Paciente)
                .Include(r => r.Profissional)
                .FirstOrDefaultAsync(m => m.ResultadoId == id);
            if (resultado == null)
            {
                return NotFound();
            }

            return View(resultado);
        }

        // GET: Resultado/Create
        public IActionResult Create()
        {
            ViewData["ExameId"] = new SelectList(_context.Exame, "ExameId", "ExameNome");
            ViewData["PacienteId"] = new SelectList(_context.Paciente, "PacienteId", "PacienteNome");
            ViewData["ProfissionalId"] = new SelectList(_context.Profissional, "ProfissionalId", "ProfissionaNome");
            return View();
        }

        // POST: Resultado/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ResultadoId,PacienteId,ExameId,ResultadoDescricao,DataRealizacao,ProfissionalId,ObservacaoResultado")] Resultado resultado)
        {
            if (ModelState.IsValid)
            {
                _context.Add(resultado);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ExameId"] = new SelectList(_context.Exame, "ExameId", "ExameNome", resultado.ExameId);
            ViewData["PacienteId"] = new SelectList(_context.Paciente, "PacienteId", "PacienteNome", resultado.PacienteId);
            ViewData["ProfissionalId"] = new SelectList(_context.Profissional, "ProfissionalId", "ProfissionaNome", resultado.ProfissionalId);
            return View(resultado);
        }

        // GET: Resultado/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Resultado == null)
            {
                return NotFound();
            }

            var resultado = await _context.Resultado.FindAsync(id);
            if (resultado == null)
            {
                return NotFound();
            }
            ViewData["ExameId"] = new SelectList(_context.Exame, "ExameId", "ExameNome", resultado.ExameId);
            ViewData["PacienteId"] = new SelectList(_context.Paciente, "PacienteId", "PacienteNome", resultado.PacienteId);
            ViewData["ProfissionalId"] = new SelectList(_context.Profissional, "ProfissionalId", "ProfissionaNome", resultado.ProfissionalId);
            return View(resultado);
        }

        // POST: Resultado/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ResultadoId,PacienteId,ExameId,ResultadoDescricao,DataRealizacao,ProfissionalId,ObservacaoResultado")] Resultado resultado)
        {
            if (id != resultado.ResultadoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(resultado);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ResultadoExists(resultado.ResultadoId))
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
            ViewData["ExameId"] = new SelectList(_context.Exame, "ExameId", "ExameNome", resultado.ExameId);
            ViewData["PacienteId"] = new SelectList(_context.Paciente, "PacienteId", "PacienteNome", resultado.PacienteId);
            ViewData["ProfissionalId"] = new SelectList(_context.Profissional, "ProfissionalId", "ProfissionaNome", resultado.ProfissionalId);
            return View(resultado);
        }

        // GET: Resultado/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Resultado == null)
            {
                return NotFound();
            }

            var resultado = await _context.Resultado
                .Include(r => r.Exame)
                .Include(r => r.Paciente)
                .Include(r => r.Profissional)
                .FirstOrDefaultAsync(m => m.ResultadoId == id);
            if (resultado == null)
            {
                return NotFound();
            }

            return View(resultado);
        }

        // POST: Resultado/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Resultado == null)
            {
                return Problem("Entity set 'Contexto.Resultado'  is null.");
            }
            var resultado = await _context.Resultado.FindAsync(id);
            if (resultado != null)
            {
                _context.Resultado.Remove(resultado);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ResultadoExists(int id)
        {
          return (_context.Resultado?.Any(e => e.ResultadoId == id)).GetValueOrDefault();
        }

        public async Task<IActionResult> Imprimir(int? id)
        {
            if (id == null || _context.Resultado == null)
            {
                return NotFound();
            }

            var resultado = await _context.Resultado
                .Include(r => r.Exame)
                .Include(r => r.Paciente)
                .Include(r => r.Profissional)
                .FirstOrDefaultAsync(m => m.ResultadoId == id);

            if(resultado == null)
            {
                return NotFound();
            }

            return View(resultado);
        }
    }
}
