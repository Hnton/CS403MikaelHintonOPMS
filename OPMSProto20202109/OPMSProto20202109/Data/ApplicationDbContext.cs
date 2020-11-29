using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OPMSProto20202109.Areas.Data;
using OPMSProto20202109.Models;
using OPMSProto20202109.Models.ViewModels;

namespace OPMSProto20202109.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            var PasswordHash = new PasswordHasher();

            // CREATE ROLES
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "ADMIN",
                    Name = "Admin",
                    NormalizedName = "Admin".ToUpper()
                },
                new IdentityRole
                {
                    Id = "EMPLOYEE",
                    Name = "Employee",
                    NormalizedName = "Employee".ToUpper()
                },
                new IdentityRole
                {
                    Id = "MANAGER",
                    Name = "Manager",
                    NormalizedName = "Manager".ToUpper()
                },
                new IdentityRole
                {
                    Id = "HR",
                    Name = "HR",
                    NormalizedName = "HR".ToUpper()
                }
                );

            // CREATE ADDRESSES
            builder.Entity<Address>().HasData(
                new Address
                {
                    ID = 1,
                    City = "Parkersburg",
                    State = "West Virginia",
                    StreetAddress = "300 Campus Dr.",
                    ZIP = "26101",
                    TimeStamp = DateTime.Now
                },
                new Address
                {
                    ID = 2,
                    City = "Ripley",
                    State = "West Virginia",
                    StreetAddress = "105 Academy Dr.",
                    ZIP = "25271",
                    TimeStamp = DateTime.Now
                });

            // CREATE CAMPUSES
            builder.Entity<Campus>().HasData(
                new Campus
                {
                    ID = 1,
                    CampusName = "West Virginia University at Parkersburg",
                    AddressID = 1,
                    Active = true,
                    TimeStamp = DateTime.Now,

                },
                new Campus
                {
                    ID = 2,
                    CampusName = "WVUP Jackson County Center",
                    AddressID = 2,
                    Active = true,
                    TimeStamp = DateTime.Now,
                });

            // CREATE ADMIN ACCOUNT
            var admin = new Employee
            {
                Id = "ADMIN",
                UserName = "Admin@develop.com",
                NormalizedUserName = "Admin@develop.com".ToUpper(),
                Email = "Admin@Develop.com",
                NormalizedEmail = "Admin@Develop.com".ToUpper(),
                EmailConfirmed = true,
                FirstName = "Admin",
                LastName = "Admin",
                Active = true,
                ExemptFromOvertime = false,
                HourlyWage = 30.00,
                PasswordHash = "AQAAAAEAACcQAAAAEE6fNGBLk0gWXtI+YF/euDFjEP3ASy0lEumjpTNbqgowNOzt9/dY3UByIFgSIFf1bA=="
            };

            builder.Entity<Employee>().HasData(admin);

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "ADMIN",
                UserId = "ADMIN"
            });

            // CREATE HR ACCOUNT
            var hr = new Employee
            {
                Id = "HR",
                UserName = "HR@develop.com",
                NormalizedUserName = "HR@develop.com".ToUpper(),
                Email = "HR@develop.com",
                NormalizedEmail = "HR@develop.com".ToUpper(),
                EmailConfirmed = true,
                FirstName = "HR",
                LastName = "HR",
                Active = true,
                ExemptFromOvertime = false,
                HourlyWage = 30.00,
                PasswordHash = "AQAAAAEAACcQAAAAEE6fNGBLk0gWXtI+YF/euDFjEP3ASy0lEumjpTNbqgowNOzt9/dY3UByIFgSIFf1bA=="
            };

            builder.Entity<Employee>().HasData(hr);

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "HR",
                UserId = "HR"
            });

            // CREATE EMPLOYEE ACCOUNT
            var employee = new Employee
            {
                Id = "EMPLOYEE",
                UserName = "EMPLOYEE@develop.com",
                NormalizedUserName = "EMPLOYEE@develop.com".ToUpper(),
                Email = "EMPLOYEE@develop.com",
                NormalizedEmail = "EMPLOYEE@develop.com".ToUpper(),
                EmailConfirmed = true,
                FirstName = "EMPLOYEE",
                LastName = "EMPLOYEE",
                Active = true,
                ExemptFromOvertime = false,
                HourlyWage = 30.00,
                PasswordHash = "AQAAAAEAACcQAAAAEE6fNGBLk0gWXtI+YF/euDFjEP3ASy0lEumjpTNbqgowNOzt9/dY3UByIFgSIFf1bA=="
            };

            builder.Entity<Employee>().HasData(employee);

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "EMPLOYEE",
                UserId = "EMPLOYEE"
            });

            // CREATE MANAGER ACCOUNT
            var manager = new Employee
            {
                Id = "MANAGER",
                UserName = "MANAGER@develop.com",
                NormalizedUserName = "MANAGER@develop.com".ToUpper(),
                Email = "MANAGER@develop.com",
                NormalizedEmail = "MANAGER@develop.com".ToUpper(),
                EmailConfirmed = true,
                FirstName = "MANAGER",
                LastName = "MANAGER",
                Active = true,
                ExemptFromOvertime = false,
                HourlyWage = 30.00,
                PasswordHash = "AQAAAAEAACcQAAAAEE6fNGBLk0gWXtI+YF/euDFjEP3ASy0lEumjpTNbqgowNOzt9/dY3UByIFgSIFf1bA=="
            };

            builder.Entity<Employee>().HasData(manager);

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "MANAGER",
                UserId = "MANAGER"
            });



            //CREATE DIVISIONS
            builder.Entity<Division>().HasData(
                new Division
                {
                    ID = 1,
                    DivisionName = "Science, Technology, Engineering & Math",
                    Active = true,
                    TimeStamp = DateTime.Now,
                    SupervisorID = "ADMIN"
                },
               new Division
               {
                   ID = 2,
                   DivisionName = "Information Technology",
                   Active = true,
                   TimeStamp = DateTime.Now,
                   SupervisorID = "ADMIN"
               },
               new Division
               {
                   ID = 3,
                   DivisionName = "Business",
                   Active = true,
                   TimeStamp = DateTime.Now,
                   SupervisorID = "ADMIN"
               },
               new Division
               {
                   ID = 4,
                   DivisionName = "Maintenance",
                   Active = true,
                   TimeStamp = DateTime.Now,
                   SupervisorID = "ADMIN"
               },
               new Division
               {
                   ID = 5,
                   DivisionName = "Academic and Student Affairs",
                   Active = true,
                   TimeStamp = DateTime.Now,
                   SupervisorID = "ADMIN"
               },
                new Division
                {
                    ID = 6,
                    DivisionName = "Office of the President",
                    Active = true,
                    TimeStamp = DateTime.Now,
                    SupervisorID = "ADMIN"
                }, new Division
                {
                    ID = 7,
                    DivisionName = "Humanities and Fine Arts",
                    Active = true,
                    TimeStamp = DateTime.Now,
                    SupervisorID = "ADMIN"
                }
                );

            // CREATE DEPARTMENT
            builder.Entity<Department>().HasData(
                 new Department
                 {
                     ID = 1,
                     DepartmentName = "Computer Science",
                     DivisionID = 1,
                     Active = true,
                     TimeStamp = DateTime.Now
                 },
                new Department
                {
                    ID = 2,
                    DepartmentName = "Information Technology",
                    DivisionID = 2,
                    Active = true,
                    TimeStamp = DateTime.Now
                },
                new Department
                {
                    ID = 3,
                    DepartmentName = "Business",
                    DivisionID = 3,
                    Active = true,
                    TimeStamp = DateTime.Now
                },
                new Department
                {
                    ID = 4,
                    DepartmentName = "Maintenance",
                    DivisionID = 4,
                    Active = true,
                    TimeStamp = DateTime.Now
                },
                new Department
                {
                    ID = 5,
                    DepartmentName = "Office of Academic Affairs",
                    DivisionID = 5,
                    Active = true,
                    TimeStamp = DateTime.Now
                },
                new Department
                {
                    ID = 6,
                    DepartmentName = "Office of the President",
                    DivisionID = 6,
                    Active = true,
                    TimeStamp = DateTime.Now
                },
                new Department
                {
                    ID = 7,
                    DepartmentName = "STEM",
                    DivisionID = 1,
                    Active = true,
                    TimeStamp = DateTime.Now
                },
                 new Department
                 {
                     ID = 8,
                     DepartmentName = "Humanities and Fine Arts",
                     DivisionID = 7,
                     Active = true,
                     TimeStamp = DateTime.Now
                 }
                );




            base.OnModelCreating(builder);
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
