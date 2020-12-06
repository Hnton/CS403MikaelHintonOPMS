using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OPMSProto20202109.Data;
using OPMSProto20202109.Models;
using OPMSProto20202109.Models.ViewModels;

namespace OPMSProto20202109.Controllers
{
    public class CampusAndAddressController : Controller
    {

        private ApplicationDbContext _context;
        public CampusAndAddressController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CampusAndAddress
        public ActionResult Index()
        {
            var list = (from c in _context.Campuses
                        join a in _context.Addresses
                        on c.ID equals a.ID into ThisList
                        from a in ThisList.DefaultIfEmpty()
                        select new
                        {
                            CampusName = c.CampusName,
                            Active = c.Active,
                            City = a.City,
                            State = a.State,
                            StreetAddress = a.StreetAddress,
                            ZIP = a.ZIP

                        }).ToList()
                         .Select(x => new CampusAndAddressViewModels()
                         {
                             CampusName = x.CampusName,
                             Active = x.Active,
                             City = x.City,
                             State = x.State,
                             StreetAddress = x.StreetAddress,
                             ZIP = x.ZIP
                         });

            return View(list);
        }

        // GET: Campus/Create
        public ActionResult CreateCampusAndAddress()
        {
            ViewBag.AddressID = new SelectList(_context.Addresses, "ID", "City");
            return View();
        }

        // POST: Campus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateCampusAndAddress(Campus campus, Address address)
        {
            if (ModelState.IsValid)
            {
                _context.Addresses.Add(address);
                _context.Campuses.Add(campus);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AddressID = new SelectList(_context.Addresses, "ID", "City", campus.AddressID);
            return View(campus);
        }
    }
}