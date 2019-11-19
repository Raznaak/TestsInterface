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
    public class JoueursController : Controller
    {
        private IRepository<Joueur> _joueurRepository;

        public JoueursController(IRepository<Joueur> joueurRepository)
        {
            _joueurRepository = joueurRepository;
        }

        // GET: Joueurs
        public async Task<IActionResult> Index()
        {
            return View(await _joueurRepository.GetAll());
        }
        /*
        // GET: Joueurs/Details/5
        public async Task<IActionResult> Details(int? id)
        {/*
            if (id == null)
            {
                return NotFound();
            }

            var joueur = await _context.Joueur
                .FirstOrDefaultAsync(m => m.Id == id);
            if (joueur == null)
            {
                return NotFound();
            }
            
            return View(joueur);
        }
        /*
        // GET: Joueurs/Create
        public IActionResult Create()
        {
            return View();
        }
        /*
        // POST: Joueurs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nom,Equipe,Position,Salaire")] Joueur joueur)
        {
            /*if (ModelState.IsValid)
            {
                _context.Add(joueur);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(joueur);
        }
    /*
        // GET: Joueurs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            /*if (id == null)
            {
                return NotFound();
            }

            var joueur = await _context.Joueur.FindAsync(id);
            if (joueur == null)
            {
                return NotFound();
            }
            return View(joueur);
        }
        /*
        // POST: Joueurs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nom,Equipe,Position,Salaire")] Joueur joueur)
        {
            if (id != joueur.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(joueur);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JoueurExists(joueur.Id))
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
            return View(joueur);
        }
        /*
        // GET: Joueurs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var joueur = await _context.Joueur
                .FirstOrDefaultAsync(m => m.Id == id);
            if (joueur == null)
            {
                return NotFound();
            }

            return View(joueur);
        }
        /*
        // POST: Joueurs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var joueur = await _context.Joueur.FindAsync(id);
            _context.Joueur.Remove(joueur);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        /*
        private bool JoueurExists(int id)
        {
            return _context.Joueur.Any(e => e.Id == id);
            return true;
        }*/
    }
}
