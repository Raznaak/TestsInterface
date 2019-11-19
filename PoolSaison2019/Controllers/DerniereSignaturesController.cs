using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PoolSaison2019.Data;
using PoolSaison2019.Models;

namespace PoolSaison2019.Controllers
{
    public class DerniereSignaturesController : Controller
    {
        private IRepository<DerniereSignature> _derniereSignatureRepository;

        public DerniereSignaturesController(IRepository<DerniereSignature> derniereSignatureRepository)
        {
            _derniereSignatureRepository = derniereSignatureRepository;
        }

        // GET: DerniereSignatures
        public async Task<IActionResult> Index()
        {
            return View(await _derniereSignatureRepository.GetAll());
        }
        /*
        // GET: DerniereSignatures/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var derniereSignature = await _context.DerniereSignature
                .FirstOrDefaultAsync(m => m.Id == id);
            if (derniereSignature == null)
            {
                return NotFound();
            }

            return View(derniereSignature);
        }

        // GET: DerniereSignatures/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DerniereSignatures/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nom,Equipe,Salaire,Id")] DerniereSignature derniereSignature)
        {
            if (ModelState.IsValid)
            {
                _context.Add(derniereSignature);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(derniereSignature);
        }

        // GET: DerniereSignatures/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var derniereSignature = await _context.DerniereSignature.FindAsync(id);
            if (derniereSignature == null)
            {
                return NotFound();
            }
            return View(derniereSignature);
        }

        // POST: DerniereSignatures/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Nom,Equipe,Salaire,Id")] DerniereSignature derniereSignature)
        {
            if (id != derniereSignature.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(derniereSignature);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DerniereSignatureExists(derniereSignature.Id))
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
            return View(derniereSignature);
        }

        // GET: DerniereSignatures/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var derniereSignature = await _context.DerniereSignature
                .FirstOrDefaultAsync(m => m.Id == id);
            if (derniereSignature == null)
            {
                return NotFound();
            }

            return View(derniereSignature);
        }

        // POST: DerniereSignatures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var derniereSignature = await _context.DerniereSignature.FindAsync(id);
            _context.DerniereSignature.Remove(derniereSignature);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DerniereSignatureExists(int id)
        {
            return _context.DerniereSignature.Any(e => e.Id == id);
        }*/
    }
}
