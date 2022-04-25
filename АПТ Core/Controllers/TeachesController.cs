using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using АПТ_Core.Data;
using АПТ_Core.Models;

namespace АПТ_Core.Controllers
{
    public class TeachesController : Controller
    {
        private readonly TehContext _context;

        public TeachesController(TehContext context)
        {
            _context = context;
        }

        // GET: Teaches
        public async Task<IActionResult> Index()
        {
            return View(await _context.Teach.ToListAsync());
        }

        // GET: Teaches/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teach = await _context.Teach
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teach == null)
            {
                return NotFound();
            }

            return View(teach);
        }

        // GET: Teaches/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Teaches/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Fam,Im,Gr,Rost,BirthDay,ZarPlata")] Teach teach)
        {
            if (ModelState.IsValid)
            {
                _context.Add(teach);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(teach);
        }

        // GET: Teaches/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teach = await _context.Teach.FindAsync(id);
            if (teach == null)
            {
                return NotFound();
            }
            return View(teach);
        }

        // POST: Teaches/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Fam,Im,Gr,Rost,BirthDay,ZarPlata")] Teach teach)
        {
            if (id != teach.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(teach);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeachExists(teach.Id))
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
            return View(teach);
        }

        // GET: Teaches/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teach = await _context.Teach
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teach == null)
            {
                return NotFound();
            }

            return View(teach);
        }

        // POST: Teaches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var teach = await _context.Teach.FindAsync(id);
            _context.Teach.Remove(teach);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeachExists(int id)
        {
            return _context.Teach.Any(e => e.Id == id);
        }
    }
}
