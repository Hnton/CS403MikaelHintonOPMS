﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OPMSProto20202109.Data;

namespace OPMSProto20202109.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201129213612_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "ADMIN",
                            ConcurrencyStamp = "81257cc9-dd9c-4390-8d64-bd2fec9385a4",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "EMPLOYEE",
                            ConcurrencyStamp = "d1fc2e83-f077-4c16-99a7-31a84a1ef8c8",
                            Name = "Employee",
                            NormalizedName = "EMPLOYEE"
                        },
                        new
                        {
                            Id = "MANAGER",
                            ConcurrencyStamp = "8474a616-f0f6-4201-aac7-c5754e6b1f6c",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = "HR",
                            ConcurrencyStamp = "4d92c4e1-5bb8-4559-8db4-8fc6295cdbe7",
                            Name = "HR",
                            NormalizedName = "HR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "ADMIN",
                            RoleId = "ADMIN"
                        },
                        new
                        {
                            UserId = "HR",
                            RoleId = "HR"
                        },
                        new
                        {
                            UserId = "EMPLOYEE",
                            RoleId = "EMPLOYEE"
                        },
                        new
                        {
                            UserId = "MANAGER",
                            RoleId = "MANAGER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("OPMSProto20202109.Models.Address", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.Property<string>("ZIP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Addresses","User");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            City = "Parkersburg",
                            State = "West Virginia",
                            StreetAddress = "300 Campus Dr.",
                            TimeStamp = new DateTime(2020, 11, 29, 16, 36, 12, 396, DateTimeKind.Local).AddTicks(1614),
                            ZIP = "26101"
                        },
                        new
                        {
                            ID = 2,
                            City = "Ripley",
                            State = "West Virginia",
                            StreetAddress = "105 Academy Dr.",
                            TimeStamp = new DateTime(2020, 11, 29, 16, 36, 12, 396, DateTimeKind.Local).AddTicks(1701),
                            ZIP = "25271"
                        });
                });

            modelBuilder.Entity("OPMSProto20202109.Models.Campus", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int>("AddressID")
                        .HasColumnType("int");

                    b.Property<string>("CampusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("AddressID");

                    b.ToTable("Campuses","User");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Active = true,
                            AddressID = 1,
                            CampusName = "West Virginia University at Parkersburg",
                            TimeStamp = new DateTime(2020, 11, 29, 16, 36, 12, 396, DateTimeKind.Local).AddTicks(3135)
                        },
                        new
                        {
                            ID = 2,
                            Active = true,
                            AddressID = 2,
                            CampusName = "WVUP Jackson County Center",
                            TimeStamp = new DateTime(2020, 11, 29, 16, 36, 12, 396, DateTimeKind.Local).AddTicks(3183)
                        });
                });

            modelBuilder.Entity("OPMSProto20202109.Models.ClockInOut", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ClockInTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ClockOutTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmployeeID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("TimeSheetID")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("TimeSheetID");

                    b.ToTable("ClockInOut","User");
                });

            modelBuilder.Entity("OPMSProto20202109.Models.Department", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DivisionID")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("DivisionID");

                    b.ToTable("Departments","User");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Active = true,
                            DepartmentName = "Computer Science",
                            DivisionID = 1,
                            TimeStamp = new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(2297)
                        },
                        new
                        {
                            ID = 2,
                            Active = true,
                            DepartmentName = "Information Technology",
                            DivisionID = 2,
                            TimeStamp = new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(2393)
                        },
                        new
                        {
                            ID = 3,
                            Active = true,
                            DepartmentName = "Business",
                            DivisionID = 3,
                            TimeStamp = new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(2400)
                        },
                        new
                        {
                            ID = 4,
                            Active = true,
                            DepartmentName = "Maintenance",
                            DivisionID = 4,
                            TimeStamp = new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(2405)
                        },
                        new
                        {
                            ID = 5,
                            Active = true,
                            DepartmentName = "Office of Academic Affairs",
                            DivisionID = 5,
                            TimeStamp = new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(2411)
                        },
                        new
                        {
                            ID = 6,
                            Active = true,
                            DepartmentName = "Office of the President",
                            DivisionID = 6,
                            TimeStamp = new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(2416)
                        },
                        new
                        {
                            ID = 7,
                            Active = true,
                            DepartmentName = "STEM",
                            DivisionID = 1,
                            TimeStamp = new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(2422)
                        },
                        new
                        {
                            ID = 8,
                            Active = true,
                            DepartmentName = "Humanities and Fine Arts",
                            DivisionID = 7,
                            TimeStamp = new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(2427)
                        });
                });

            modelBuilder.Entity("OPMSProto20202109.Models.Division", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("DivisionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupervisorID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("SupervisorID");

                    b.ToTable("Divisions","User");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Active = true,
                            DivisionName = "Science, Technology, Engineering & Math",
                            SupervisorID = "ADMIN",
                            TimeStamp = new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(419)
                        },
                        new
                        {
                            ID = 2,
                            Active = true,
                            DivisionName = "Information Technology",
                            SupervisorID = "ADMIN",
                            TimeStamp = new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(716)
                        },
                        new
                        {
                            ID = 3,
                            Active = true,
                            DivisionName = "Business",
                            SupervisorID = "ADMIN",
                            TimeStamp = new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(734)
                        },
                        new
                        {
                            ID = 4,
                            Active = true,
                            DivisionName = "Maintenance",
                            SupervisorID = "ADMIN",
                            TimeStamp = new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(739)
                        },
                        new
                        {
                            ID = 5,
                            Active = true,
                            DivisionName = "Academic and Student Affairs",
                            SupervisorID = "ADMIN",
                            TimeStamp = new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(745)
                        },
                        new
                        {
                            ID = 6,
                            Active = true,
                            DivisionName = "Office of the President",
                            SupervisorID = "ADMIN",
                            TimeStamp = new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(751)
                        },
                        new
                        {
                            ID = 7,
                            Active = true,
                            DivisionName = "Humanities and Fine Arts",
                            SupervisorID = "ADMIN",
                            TimeStamp = new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(756)
                        });
                });

            modelBuilder.Entity("OPMSProto20202109.Models.TimeSheet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Approved")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("ExemptFromOvertime")
                        .HasColumnType("bit");

                    b.Property<string>("ReasonDenied")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("TimeSheet","User");
                });

            modelBuilder.Entity("OPMSProto20202109.Areas.Data.Employee", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int?>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<bool>("ExemptFromOvertime")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("HourlyWage")
                        .HasColumnType("float");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Employees","User");

                    b.HasDiscriminator().HasValue("Employee");

                    b.HasData(
                        new
                        {
                            Id = "ADMIN",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fb5e21aa-8275-4c3a-94f4-b41dd9c55518",
                            Email = "Admin@Develop.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@DEVELOP.COM",
                            NormalizedUserName = "ADMIN@DEVELOP.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEE6fNGBLk0gWXtI+YF/euDFjEP3ASy0lEumjpTNbqgowNOzt9/dY3UByIFgSIFf1bA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6ba4f1cb-a39e-4fbf-b81f-b348887296da",
                            TwoFactorEnabled = false,
                            UserName = "Admin@develop.com",
                            Active = true,
                            ExemptFromOvertime = false,
                            FirstName = "Admin",
                            HourlyWage = 30.0,
                            LastName = "Admin"
                        },
                        new
                        {
                            Id = "HR",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "efa35758-cb17-43b1-af08-5e9cfefeda14",
                            Email = "HR@develop.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "HR@DEVELOP.COM",
                            NormalizedUserName = "HR@DEVELOP.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEE6fNGBLk0gWXtI+YF/euDFjEP3ASy0lEumjpTNbqgowNOzt9/dY3UByIFgSIFf1bA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d80afc1a-d3e6-4396-83ad-33188034b8a3",
                            TwoFactorEnabled = false,
                            UserName = "HR@develop.com",
                            Active = true,
                            ExemptFromOvertime = false,
                            FirstName = "HR",
                            HourlyWage = 30.0,
                            LastName = "HR"
                        },
                        new
                        {
                            Id = "EMPLOYEE",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "689f9d1f-21b6-4f43-b9e5-b79aac1e9b0c",
                            Email = "EMPLOYEE@develop.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "EMPLOYEE@DEVELOP.COM",
                            NormalizedUserName = "EMPLOYEE@DEVELOP.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEE6fNGBLk0gWXtI+YF/euDFjEP3ASy0lEumjpTNbqgowNOzt9/dY3UByIFgSIFf1bA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "578ce881-d7f2-42c0-b08c-0ef4d236c9ee",
                            TwoFactorEnabled = false,
                            UserName = "EMPLOYEE@develop.com",
                            Active = true,
                            ExemptFromOvertime = false,
                            FirstName = "EMPLOYEE",
                            HourlyWage = 30.0,
                            LastName = "EMPLOYEE"
                        },
                        new
                        {
                            Id = "MANAGER",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "bdea9b05-f148-4750-82e1-94ef0a4fa05c",
                            Email = "MANAGER@develop.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "MANAGER@DEVELOP.COM",
                            NormalizedUserName = "MANAGER@DEVELOP.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEE6fNGBLk0gWXtI+YF/euDFjEP3ASy0lEumjpTNbqgowNOzt9/dY3UByIFgSIFf1bA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "592ee882-b9a3-4b16-a94c-42acb3ba3f71",
                            TwoFactorEnabled = false,
                            UserName = "MANAGER@develop.com",
                            Active = true,
                            ExemptFromOvertime = false,
                            FirstName = "MANAGER",
                            HourlyWage = 30.0,
                            LastName = "MANAGER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OPMSProto20202109.Models.Campus", b =>
                {
                    b.HasOne("OPMSProto20202109.Models.Address", "Address")
                        .WithMany("Campuses")
                        .HasForeignKey("AddressID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OPMSProto20202109.Models.ClockInOut", b =>
                {
                    b.HasOne("OPMSProto20202109.Areas.Data.Employee", "Supervisor")
                        .WithMany()
                        .HasForeignKey("EmployeeID");

                    b.HasOne("OPMSProto20202109.Models.TimeSheet", "TimeSheet")
                        .WithMany("ClockIns")
                        .HasForeignKey("TimeSheetID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OPMSProto20202109.Models.Department", b =>
                {
                    b.HasOne("OPMSProto20202109.Models.Division", "Division")
                        .WithMany("Departments")
                        .HasForeignKey("DivisionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OPMSProto20202109.Models.Division", b =>
                {
                    b.HasOne("OPMSProto20202109.Areas.Data.Employee", "Supervisor")
                        .WithMany("Divisions")
                        .HasForeignKey("SupervisorID");
                });

            modelBuilder.Entity("OPMSProto20202109.Models.TimeSheet", b =>
                {
                    b.HasOne("OPMSProto20202109.Areas.Data.Employee", "User")
                        .WithMany("TimeSheets")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OPMSProto20202109.Areas.Data.Employee", b =>
                {
                    b.HasOne("OPMSProto20202109.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentID");
                });
#pragma warning restore 612, 618
        }
    }
}
