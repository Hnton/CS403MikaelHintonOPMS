using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OPMSProto20202109.Data;
using OPMSProto20202109.Models;

namespace OPMSProto20202109.Controllers
{
    public class ClockInOutsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClockInOutsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ClockInOuts
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ClockInOut.Include(c => c.Supervisor).Include(c => c.TimeSheet).Where(i => i.EmployeeID.Equals(User.Identity.GetUserId()));
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ClockInOuts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clockInOut = await _context.ClockInOut
                .Include(c => c.Supervisor)
                .Include(c => c.TimeSheet)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (clockInOut == null)
            {
                return NotFound();
            }

            return View(clockInOut);
        }

        // GET: ClockInOuts/Create
        public IActionResult Create()
        {
            ViewData["EmployeeID"] = new SelectList(_context.Employees, "Id", "Email");
            ViewData["TimeSheetID"] = new SelectList(_context.TimeSheets, "ID", "UserID");
            return View();
        }

        // POST: ClockInOuts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmployeeID,ClockInTime,ClockOutTime,TimeSheetID,ID,TimeStamp")] ClockInOut clockInOut)
        {
            clockInOut.TimeStamp = DateTime.Now;
            clockInOut.ClockInTime = DateTime.Now;

            clockInOut.EmployeeID = User.Identity.GetUserId();
            if (ModelState.IsValid)
            {
                _context.Add(clockInOut);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            //ViewData["EmployeeID"] = new SelectList(_context.Employees, "Id", "Email", clockInOut.EmployeeID);
            ViewData["TimeSheetID"] = new SelectList(_context.TimeSheets, "ID", "UserID", clockInOut.TimeSheetID);
            return View(clockInOut);
        }



        // GET: ClockInOuts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clockInOut = await _context.ClockInOut.FindAsync(id);
            if (clockInOut == null)
            {
                return NotFound();
            }
            //ViewData["EmployeeID"] = new SelectList(_context.Employees, "Id", "Email", clockInOut.EmployeeID);
            ViewData["TimeSheetID"] = new SelectList(_context.TimeSheets, "ID", "UserID", clockInOut.TimeSheetID);
            return View(clockInOut);
        }

        // POST: ClockInOuts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmployeeID,ClockInTime,ClockOutTime,TimeSheetID,ID,TimeStamp")] ClockInOut clockInOut)
        {
            clockInOut.EmployeeID = User.Identity.GetUserId();
            clockInOut.TimeStamp = DateTime.Now;
            if (id != clockInOut.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clockInOut);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClockInOutExists(clockInOut.ID))
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
            ViewData["EmployeeID"] = new SelectList(_context.Employees, "Id", "Email", clockInOut.EmployeeID);
            ViewData["TimeSheetID"] = new SelectList(_context.TimeSheets, "ID", "UserID", clockInOut.TimeSheetID);
            return View(clockInOut);
        }

        // GET: ClockInOuts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clockInOut = await _context.ClockInOut
                .Include(c => c.Supervisor)
                .Include(c => c.TimeSheet)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (clockInOut == null)
            {
                return NotFound();
            }

            return View(clockInOut);
        }

        // POST: ClockInOuts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clockInOut = await _context.ClockInOut.FindAsync(id);
            _context.ClockInOut.Remove(clockInOut);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClockInOutExists(int id)
        {
            return _context.ClockInOut.Any(e => e.ID == id);
        }

        // GET: ClockInOuts/Edit/5
        public async Task<IActionResult> ClockOut(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clockInOut = await _context.ClockInOut.FindAsync(id);
            if (clockInOut == null)
            {
                return NotFound();
            }
            clockInOut.ClockOutTime = DateTime.Now;
            //ViewData["EmployeeID"] = new SelectList(_context.Employees, "Id", "Email", clockInOut.EmployeeID);
            ViewData["TimeSheetID"] = new SelectList(_context.TimeSheets, "ID", "UserID", clockInOut.TimeSheetID);
            return View(clockInOut);
        }

        // POST: ClockInOuts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ClockOut(int id, [Bind("EmployeeID,ClockInTime,ClockOutTime,TimeSheetID,ID,TimeStamp")] ClockInOut clockInOut)
        {
            clockInOut.EmployeeID = User.Identity.GetUserId();
            clockInOut.TimeStamp = DateTime.Now;
            if (id != clockInOut.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clockInOut);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClockInOutExists(clockInOut.ID))
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
            ViewData["EmployeeID"] = new SelectList(_context.Employees, "Id", "Email", clockInOut.EmployeeID);
            ViewData["TimeSheetID"] = new SelectList(_context.TimeSheets, "ID", "UserID", clockInOut.TimeSheetID);
            return View(clockInOut);
        }

    }
}
