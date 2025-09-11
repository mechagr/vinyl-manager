using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VinylManager.Data;
using VinylManager.Models;

namespace VinylManager.Controllers
{
    [Authorize]
    public class VinylsController : Controller
    {
        private readonly VinylContext _context;

        public VinylsController(VinylContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var vinyls = await _context.Vinyls
                .Include(v => v.Artist)
                .Include(v => v.Category)
                .ToListAsync();
            return View(vinyls);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var vinyl = await _context.Vinyls
                .Include(v => v.Artist)
                .Include(v => v.Category)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (vinyl == null) return NotFound();
            return View(vinyl);
        }

        public IActionResult Create()
        {
            ViewData["ArtistId"] = new SelectList(_context.Artists, "Id", "Name");
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Year,Condition,Notes,ArtistId,CategoryId")] Vinyl vinyl)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vinyl);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ArtistId"] = new SelectList(_context.Artists, "Id", "Name", vinyl.ArtistId);
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", vinyl.CategoryId);
            return View(vinyl);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var vinyl = await _context.Vinyls.FindAsync(id);
            if (vinyl == null) return NotFound();

            ViewData["ArtistId"] = new SelectList(_context.Artists, "Id", "Name", vinyl.ArtistId);
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", vinyl.CategoryId);
            return View(vinyl);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Year,Condition,Notes,ArtistId,CategoryId")] Vinyl vinyl)
        {
            if (id != vinyl.Id) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vinyl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VinylExists(vinyl.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ArtistId"] = new SelectList(_context.Artists, "Id", "Name", vinyl.ArtistId);
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", vinyl.CategoryId);
            return View(vinyl);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var vinyl = await _context.Vinyls
                .Include(v => v.Artist)
                .Include(v => v.Category)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (vinyl == null) return NotFound();
            return View(vinyl);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vinyl = await _context.Vinyls.FindAsync(id);
            if (vinyl != null)
            {
                _context.Vinyls.Remove(vinyl);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        private bool VinylExists(int id)
        {
            return _context.Vinyls.Any(e => e.Id == id);
        }
    }
}