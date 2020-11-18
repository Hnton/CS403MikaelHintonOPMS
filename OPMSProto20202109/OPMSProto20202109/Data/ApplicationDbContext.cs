using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OPMSProto20202109.Areas.Data;
using OPMSProto20202109.Models;

namespace OPMSProto20202109.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //     => options.UseSqlite("Data Source=sqlitedemo.db");

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Campus> Campuses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ClockInOut> ClockInOut { get; set; }
        public DbSet<TimeSheet> TimeSheets { get; set; }
    }
}
