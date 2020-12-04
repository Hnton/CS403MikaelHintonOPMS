using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
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
                        on t.UserID equals c.EmployeeID
                        join e in _context.Employees
                        on c.EmployeeID equals e.Id into ThisList
                        from e in ThisList.DefaultIfEmpty()
                        select new
                        {
                            t.ID,
                            t.Approved,
                            t.StartDate,
                            t.EndDate,
                            t.ReasonDenied,
                            c.EmployeeID,
                            c.ClockInTime,
                            c.ClockOutTime,
                            c.Supervisor,
                            e.HourlyWage
                        }).Where(y => y.EmployeeID.Equals(User.Identity.GetUserId())).ToList()
                        .Select(x => new TimeSheetWithClockInOutsViewModels()
                        {
                            ID = x.ID,
                            Approved = x.Approved,
                            StartDate = x.StartDate,
                            EndDate = x.EndDate,
                            ReasonDenied = x.ReasonDenied,
                            EmployeeID = x.EmployeeID,
                            ClockInTime = x.ClockInTime,
                            ClockOutTime = x.ClockOutTime,
                            TimeSpan = (TimeSpan)(x.ClockOutTime - x.ClockInTime),
                            HourlyWage = x.HourlyWage
                        }); ;
            return View(list);
        }

        public IActionResult ManagerIndex()
        {




            var list = (from t in _context.TimeSheets
                        join c in _context.ClockInOut
                        on t.UserID equals c.EmployeeID
                        join e in _context.Employees
                        on c.EmployeeID equals e.Id into ThisList
                        from e in ThisList.DefaultIfEmpty()
                        select new
                        {
                            t.ID,
                            t.Approved,
                            t.StartDate,
                            t.EndDate,
                            t.ReasonDenied,
                            c.EmployeeID,
                            c.ClockInTime,
                            c.ClockOutTime,
                            c.Supervisor,
                            e.HourlyWage
                        }).Where(y => !y.EmployeeID.Equals(User.Identity.GetUserId())).Where(y => !y.EmployeeID.Equals("HR")).ToList()
                        .Select(x => new TimeSheetWithClockInOutsViewModels()
                        {
                            ID = x.ID,
                            Approved = x.Approved,
                            StartDate = x.StartDate,
                            EndDate = x.EndDate,
                            ReasonDenied = x.ReasonDenied,
                            EmployeeID = x.EmployeeID,
                            ClockInTime = x.ClockInTime,
                            ClockOutTime = x.ClockOutTime,
                            TimeSpan = (TimeSpan)(x.ClockOutTime - x.ClockInTime),
                            HourlyWage = x.HourlyWage
                        }); ;
            return View(list);
        }

        public IActionResult HRIndex()
        {




            var list = (from t in _context.TimeSheets
                        join c in _context.ClockInOut
                        on t.UserID equals c.EmployeeID
                        join e in _context.Employees
                        on c.EmployeeID equals e.Id into ThisList
                        from e in ThisList.DefaultIfEmpty()
                        select new
                        {
                            t.ID,
                            t.Approved,
                            t.StartDate,
                            t.EndDate,
                            t.ReasonDenied,
                            c.EmployeeID,
                            c.ClockInTime,
                            c.ClockOutTime,
                            c.Supervisor,
                            e.HourlyWage
                        }).ToList()
                        .Select(x => new TimeSheetWithClockInOutsViewModels()
                        {
                            ID = x.ID,
                            Approved = x.Approved,
                            StartDate = x.StartDate,
                            EndDate = x.EndDate,
                            ReasonDenied = x.ReasonDenied,
                            EmployeeID = x.EmployeeID,
                            ClockInTime = x.ClockInTime,
                            ClockOutTime = x.ClockOutTime,
                            TimeSpan = (TimeSpan)(x.ClockOutTime - x.ClockInTime),
                            HourlyWage = x.HourlyWage
                        }); ;
            return View(list);
        }

    }
}
