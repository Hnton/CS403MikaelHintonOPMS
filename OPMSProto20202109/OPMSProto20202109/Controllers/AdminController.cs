using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OPMSProto20202109.Areas.Data;
using OPMSProto20202109.Data;

namespace OPMSProto20202109.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private ApplicationDbContext _context;
        private ApplicationDbContext CONTEXT;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
            CONTEXT = context;
        }

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        //// Display Employee with Department,Room, and Role
        //public ActionResult EmployeeWithDepartmentRoomRole()
        //{

        //    var list = (from e in context.Employees
        //                from roles in e.Roles
        //                join d in context.Departments on e.DepartmentID equals d.ID
        //                join m in context.Rooms on e.RoomID equals m.ID
        //                join r in context.Roles on roles.RoleId equals r.Id
        //                into ThisList
        //                from r in ThisList.DefaultIfEmpty()
        //                select new
        //                {
        //                    EmployeeName = e.FirstName + " " + e.LastName,
        //                    Email = e.Email,
        //                    Active = e.Active,
        //                    DepartmentName = d.DepartmentName,
        //                    RoomName = m.RoomName,
        //                    RoomCode = m.RoomCode,
        //                    RoleName = r.Name
        //                }).ToList()
        //                .Select(x => new EmployeeWithDepartmentRoomRoleViewModels()
        //                {
        //                    EmployeeName = x.EmployeeName,
        //                    Email = x.Email,
        //                    Active = x.Active,
        //                    DepartmentName = x.DepartmentName,
        //                    RoomName = x.RoomName,
        //                    RoomCode = x.RoomCode,
        //                    RoleName = x.RoleName
        //                });


        //    return View(list);

        //}

        public ActionResult ListUsers()
        {
            var query = _context.Employees.ToList();

            return View(query);
        }

        public ActionResult DeleteUsers(string id)
        {
            var user = _context.Users.Where(u => u.Id == id).FirstOrDefault();
            return View(user);
        }

        [HttpPost]
        public ActionResult DeleteUsers(Employee appuser)
        {
            var user = _context.Users.Where(u => u.Id == appuser.Id).FirstOrDefault();
            _context.Users.Remove(user);
            _context.SaveChanges();
            //var user = context.Users.Where(u => u.Id == id.ToString()).FirstOrDefault();
            return RedirectToAction("ListUsers");
        }

        public ActionResult EditUsers(string id)
        {
            var context = CONTEXT;
            var user = context.Users.Where(u => u.Id == id).FirstOrDefault();
            ViewBag.DepartmentID = new SelectList(context.Departments, "ID", "DepartmentName");
            ViewBag.Name = new SelectList(context.Roles.Where(u => !u.Name.Contains("Admin")).ToList(), "Name", "Name");
            return View(user);
        }

        [HttpPost]
        public ActionResult EditUsers(Employee appuser)
        {
            var user = _context.Employees.Where(u => u.Id == appuser.Id).FirstOrDefault();
            ViewBag.DepartmentID = new SelectList(_context.Departments, "ID", "DepartmentName", appuser.DepartmentID);
            ViewBag.Name = new SelectList(_context.Roles.Where(u => !u.Name.Contains("Admin"))
                                          .ToList(), "Name", "Name");
            //context.Entry(appuser).State = EntityState.Modified;
            user.Email = appuser.Email;
            user.FirstName = appuser.FirstName;
            user.LastName = appuser.LastName;
            user.Active = appuser.Active;
            user.DepartmentID = appuser.DepartmentID;
            user.ExemptFromOvertime = appuser.ExemptFromOvertime;
            user.HourlyWage = appuser.HourlyWage;
            _context.SaveChanges();
            //var user = context.Users.Where(u => u.Id == id.ToString()).FirstOrDefault();
            return RedirectToAction("ListUsers");
        }

        // GET: Roles
        public ActionResult ListRoles()
        {
            var Roles = _context.Roles.ToList();
            return View(Roles);
        }
    }


}
