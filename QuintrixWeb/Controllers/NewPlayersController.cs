using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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


        private async Task UpdateStateAndResetModelState(NewPlayer newPlayer)
        {
            ModelState.Clear();
            var state = _context.State.SingleOrDefault(x => x.Id == newPlayer.StateId);
            newPlayer.State = state;
            TryValidateModel(newPlayer);
        }


        [Authorize]
        // GET: NewPlayers
        public async Task<IActionResult> Index(string userId)
        {
           

            var applicationDbContext = _context.NewPlayers.Include(n => n.State);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: NewPlayers/Details/5
        public async Task<IActionResult> Details(int? id, string userId)
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
        public IActionResult Create(string userId)
        {
            ViewData["StateId"] = new SelectList(_context.State, "Id", "Abbreviation");
            return View();
        }

        // POST: NewPlayers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Level,Email,StateId")] NewPlayer newPlayer, string userId)
        {

            await UpdateStateAndResetModelState(newPlayer);
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
        public async Task<IActionResult> Edit(int? id, string userId)
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
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Level,Email,StateId")] NewPlayer newPlayer, string userId)
        {
            if (id != newPlayer.Id)
            {
                return NotFound();
            }
            await UpdateStateAndResetModelState(newPlayer);

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
        public async Task<IActionResult> Delete(int? id, string userId)
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
        public async Task<IActionResult> DeleteConfirmed(int id, string userId)
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
          return (_context.NewPlayers?.Any(e => e.Id == id )).GetValueOrDefault();
        }
    }
}
