using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuintrixWeb.Data;
using QuintrixWeb.Models;

namespace QuintrixWeb.Controllers
{
    public class NewPlayersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NewPlayersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: NewPlayers

        


        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.NewPlayers.Include(n => n.State);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: NewPlayers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.NewPlayers == null)
            {
                return NotFound();
            }

            var newPlayer = await _context.NewPlayers
                .Include(n => n.State)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (newPlayer == null)
            {
                return NotFound();
            }

            return View(newPlayer);
        }

        // GET: NewPlayers/Create
        public IActionResult Create()
        {
            ViewData["StateId"] = new SelectList(_context.State, "Id", "Abbreviation");
            return View();
        }

        // POST: NewPlayers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Level,Email,StateId")] NewPlayer newPlayer)
        {
  
            if (ModelState.IsValid)
            {
                _context.Add(newPlayer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StateId"] = new SelectList(_context.State, "Id", "Abbreviation", newPlayer.StateId);
            return View(newPlayer);
        }

        // GET: NewPlayers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.NewPlayers == null)
            {
                return NotFound();
            }

            var newPlayer = await _context.NewPlayers.FindAsync(id);
            if (newPlayer == null)
            {
                return NotFound();
            }
            ViewData["StateId"] = new SelectList(_context.State, "Id", "Abbreviation", newPlayer.StateId);
            return View(newPlayer);
        }

        // POST: NewPlayers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Level,Email,StateId")] NewPlayer newPlayer)
        {
            if (id != newPlayer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(newPlayer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NewPlayerExists(newPlayer.Id))
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
            ViewData["StateId"] = new SelectList(_context.State, "Id", "Abbreviation", newPlayer.StateId);
            return View(newPlayer);
        }

        // GET: NewPlayers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.NewPlayers == null)
            {
                return NotFound();
            }

            var newPlayer = await _context.NewPlayers
                .Include(n => n.State)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (newPlayer == null)
            {
                return NotFound();
            }

            return View(newPlayer);
        }

        // POST: NewPlayers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.NewPlayers == null)
            {
                return Problem("Entity set 'ApplicationDbContext.NewPlayers'  is null.");
            }
            var newPlayer = await _context.NewPlayers.FindAsync(id);
            if (newPlayer != null)
            {
                _context.NewPlayers.Remove(newPlayer);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NewPlayerExists(int id)
        {
          return (_context.NewPlayers?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
