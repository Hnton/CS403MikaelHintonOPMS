using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OPMSProto20202109.Data;
using OPMSProto20202109.Models.ViewModels;

namespace OPMSProto20202109.Controllers
{
    public class TimeSheetWithClockInOutsController : Controller
    {
        private ApplicationDbContext _context;
        public TimeSheetWithClockInOutsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var list = (from t in _context.TimeSheets
                        join c in _context.ClockInOut
                        on t.UserID equals c.EmployeeID into ThisList
                        from c in ThisList.DefaultIfEmpty()
                        select new
                        {
                            t.Approved,
                            t.StartDate,
                            t.EndDate,
                            t.ReasonDenied,
                            c.EmployeeID,
                            c.ClockInTime,
                            c.ClockOutTime,
                            c.Supervisor
                        }).ToList()
                        .Select(x => new TimeSheetWithClockInOutsViewModels()
                         {
                             Approved = x.Approved,
                             StartDate = x.StartDate,
                             EndDate = x.EndDate,
                             ReasonDenied = x.ReasonDenied,
                             EmployeeID = x.EmployeeID,
                             ClockInTime = x.ClockInTime,
                             ClockOutTime = x.ClockOutTime,

                        });

            return View(list);
        }
    }
}
