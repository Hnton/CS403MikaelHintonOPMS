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
    [Migration("20201123204935_init4")]
    partial class init4
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
                            ConcurrencyStamp = "a4147303-b873-44d9-b7aa-196211d223d1",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "EMPLOYEE",
                            ConcurrencyStamp = "162da478-f28e-44f3-8aaf-c7df71db5be2",
                            Name = "Employee",
                            NormalizedName = "EMPLOYEE"
                        },
                        new
                        {
                            Id = "MANAGER",
                            ConcurrencyStamp = "4f19634c-f1ba-40eb-8f32-41926563e359",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = "HR",
                            ConcurrencyStamp = "1b65bfe0-7551-42a3-bac4-4b5d3a9202d5",
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
                            TimeStamp = new DateTime(2020, 11, 23, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(1170),
                            ZIP = "26101"
                        },
                        new
                        {
                            ID = 2,
                            City = "Ripley",
                            State = "West Virginia",
                            StreetAddress = "105 Academy Dr.",
                            TimeStamp = new DateTime(2020, 11, 23, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(1260),
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
                            TimeStamp = new DateTime(2020, 11, 23, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(2725)
                        },
                        new
                        {
                            ID = 2,
                            Active = true,
                            AddressID = 2,
                            CampusName = "WVUP Jackson County Center",
                            TimeStamp = new DateTime(2020, 11, 23, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(2771)
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
                            TimeStamp = new DateTime(2020, 11, 23, 15, 49, 34, 896, DateTimeKind.Local).AddTicks(1817)
                        },
                        new
                        {
                            ID = 2,
                            Active = true,
                            DepartmentName = "Information Technology",
                            DivisionID = 2,
                            TimeStamp = new DateTime(2020, 11, 23, 15, 49, 34, 896, DateTimeKind.Local).AddTicks(1860)
                        },
                        new
                        {
                            ID = 3,
                            Active = true,
                            DepartmentName = "Business",
                            DivisionID = 3,
                            TimeStamp = new DateTime(2020, 11, 23, 15, 49, 34, 896, DateTimeKind.Local).AddTicks(1867)
                        },
                        new
                        {
                            ID = 4,
                            Active = true,
                            DepartmentName = "Maintenance",
                            DivisionID = 4,
                            TimeStamp = new DateTime(2020, 11, 23, 15, 49, 34, 896, DateTimeKind.Local).AddTicks(1872)
                        },
                        new
                        {
                            ID = 5,
                            Active = true,
                            DepartmentName = "Office of Academic Affairs",
                            DivisionID = 5,
                            TimeStamp = new DateTime(2020, 11, 23, 15, 49, 34, 896, DateTimeKind.Local).AddTicks(1878)
                        },
                        new
                        {
                            ID = 6,
                            Active = true,
                            DepartmentName = "Office of the President",
                            DivisionID = 6,
                            TimeStamp = new DateTime(2020, 11, 23, 15, 49, 34, 896, DateTimeKind.Local).AddTicks(1884)
                        },
                        new
                        {
                            ID = 7,
                            Active = true,
                            DepartmentName = "STEM",
                            DivisionID = 1,
                            TimeStamp = new DateTime(2020, 11, 23, 15, 49, 34, 896, DateTimeKind.Local).AddTicks(1889)
                        },
                        new
                        {
                            ID = 8,
                            Active = true,
                            DepartmentName = "Humanities and Fine Arts",
                            DivisionID = 7,
                            TimeStamp = new DateTime(2020, 11, 23, 15, 49, 34, 896, DateTimeKind.Local).AddTicks(1895)
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
                            TimeStamp = new DateTime(2020, 11, 23, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(9997)
                        },
                        new
                        {
                            ID = 2,
                            Active = true,
                            DivisionName = "Information Technology",
                            SupervisorID = "ADMIN",
                            TimeStamp = new DateTime(2020, 11, 23, 15, 49, 34, 896, DateTimeKind.Local).AddTicks(275)
                        },
                        new
                        {
                            ID = 3,
                            Active = true,
                            DivisionName = "Business",
                            SupervisorID = "ADMIN",
                            TimeStamp = new DateTime(2020, 11, 23, 15, 49, 34, 896, DateTimeKind.Local).AddTicks(296)
                        },
                        new
                        {
                            ID = 4,
                            Active = true,
                            DivisionName = "Maintenance",
                            SupervisorID = "ADMIN",
                            TimeStamp = new DateTime(2020, 11, 23, 15, 49, 34, 896, DateTimeKind.Local).AddTicks(302)
                        },
                        new
                        {
                            ID = 5,
                            Active = true,
                            DivisionName = "Academic and Student Affairs",
                            SupervisorID = "ADMIN",
                            TimeStamp = new DateTime(2020, 11, 23, 15, 49, 34, 896, DateTimeKind.Local).AddTicks(308)
                        },
                        new
                        {
                            ID = 6,
                            Active = true,
                            DivisionName = "Office of the President",
                            SupervisorID = "ADMIN",
                            TimeStamp = new DateTime(2020, 11, 23, 15, 49, 34, 896, DateTimeKind.Local).AddTicks(313)
                        },
                        new
                        {
                            ID = 7,
                            Active = true,
                            DivisionName = "Humanities and Fine Arts",
                            SupervisorID = "ADMIN",
                            TimeStamp = new DateTime(2020, 11, 23, 15, 49, 34, 896, DateTimeKind.Local).AddTicks(319)
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
                            ConcurrencyStamp = "b6d263b2-54d5-4685-8b1c-47bddc76c903",
                            Email = "Admin@Develop.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@DEVELOP.COM",
                            NormalizedUserName = "ADMIN@DEVELOP.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEE6fNGBLk0gWXtI+YF/euDFjEP3ASy0lEumjpTNbqgowNOzt9/dY3UByIFgSIFf1bA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "460b033a-3b32-421e-9777-34d3075e8f6e",
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
                            ConcurrencyStamp = "8f322e9d-4122-408a-adff-edfcc6cf086c",
                            Email = "HR@develop.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "HR@DEVELOP.COM",
                            NormalizedUserName = "HR@DEVELOP.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEE6fNGBLk0gWXtI+YF/euDFjEP3ASy0lEumjpTNbqgowNOzt9/dY3UByIFgSIFf1bA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "570cb8f9-890d-4a31-88fd-facb720bdec8",
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
                            ConcurrencyStamp = "bdf82d0a-5633-40d0-bdc6-d640f2ed114b",
                            Email = "EMPLOYEE@develop.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "EMPLOYEE@DEVELOP.COM",
                            NormalizedUserName = "EMPLOYEE@DEVELOP.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEE6fNGBLk0gWXtI+YF/euDFjEP3ASy0lEumjpTNbqgowNOzt9/dY3UByIFgSIFf1bA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "253bdb23-fb7b-4e36-8386-59dba78bf7e6",
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
                            ConcurrencyStamp = "b1ab7d9f-7122-44c9-a578-11ee86a26a31",
                            Email = "MANAGER@develop.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "MANAGER@DEVELOP.COM",
                            NormalizedUserName = "MANAGER@DEVELOP.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEE6fNGBLk0gWXtI+YF/euDFjEP3ASy0lEumjpTNbqgowNOzt9/dY3UByIFgSIFf1bA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "83885efe-25ad-43eb-a09d-ff7656a70783",
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
