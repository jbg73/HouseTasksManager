using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HouseTasksManager.Data;
using HouseTasksManager.Models;
using Microsoft.AspNetCore.Authorization;

namespace HouseTasksManager.Controllers
{
    public class HouseTasksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HouseTasksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: HouseTasks
        public async Task<IActionResult> Index()
        {
            return View(await _context.HouseTask.ToListAsync());
        }

        public async Task<IActionResult> IndexAssigned()
        {
            return View(await _context.HouseTask.ToListAsync());
        }

        public async Task<IActionResult> TaskCompleted([Bind("Id,Description,Value,Assigned,Owner,Finished")] int id)
        {
            var houseTask = await _context.HouseTask.FirstOrDefaultAsync(m => m.Id == id);
            houseTask.Finished = true;
            await _context.SaveChangesAsync();
            return View("IndexAssigned", await _context.HouseTask.ToListAsync());
        }

        public async Task<IActionResult> TaskAssigned([Bind("Id,Description,Value,Assigned,Owner,Finished")] int id)
        {
            var houseTask = await _context.HouseTask.FirstOrDefaultAsync(m => m.Id == id);
            houseTask.Assigned = true;
            houseTask.Owner = @User.Identity.Name;
            await _context.SaveChangesAsync();
            return View("Index", await _context.HouseTask.ToListAsync());
        }

        public async Task<IActionResult> IndexCompleted()
        {
            return View(await _context.HouseTask.ToListAsync());
        }

        // GET/Profile
        public async Task<IActionResult> Profile()
        {
            return View(await _context.HouseTask.ToListAsync());
        }

        // GET: HouseTasks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var houseTask = await _context.HouseTask
                .FirstOrDefaultAsync(m => m.Id == id);
            if (houseTask == null)
            {
                return NotFound();
            }

            return View(houseTask);
        }

        // GET: HouseTasks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HouseTasks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create([Bind("Id,Description,Value,Assigned,Owner,Finished")] HouseTask houseTask)
        {
            if (ModelState.IsValid)
            {
                _context.Add(houseTask);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(houseTask);
        }


        // GET: HouseTasks/Edit/5
        public async Task<IActionResult> Edit([Bind("Id,Description,Value,Assigned,Owner,Finished")] int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var houseTask = await _context.HouseTask.FindAsync(id);
            if (houseTask == null)
            {
                return NotFound();
            }
            return View(houseTask);
        }

        // POST: HouseTasks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Description,Value,Assigned,Owner,Finished")] HouseTask houseTask)
        {
            if (id != houseTask.Id)
            {
                return NotFound();
            }
            if (houseTask.Assigned)
            {
                houseTask.Owner = User.Identity.Name;
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(houseTask);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HouseTaskExists(houseTask.Id))
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
            return View(houseTask);
        }

        // GET: HouseTasks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var houseTask = await _context.HouseTask
                .FirstOrDefaultAsync(m => m.Id == id);
            if (houseTask == null)
            {
                return NotFound();
            }

            return View(houseTask);
        }

        // POST: HouseTasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var houseTask = await _context.HouseTask.FindAsync(id);
            _context.HouseTask.Remove(houseTask);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool HouseTaskExists(int id)
        {
            return _context.HouseTask.Any(e => e.Id == id);
        }
    }
}
