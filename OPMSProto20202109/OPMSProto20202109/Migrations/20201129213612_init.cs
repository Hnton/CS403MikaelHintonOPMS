using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OPMSProto20202109.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "User");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                schema: "User",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    State = table.Column<string>(nullable: false),
                    StreetAddress = table.Column<string>(nullable: false),
                    ZIP = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Campuses",
                schema: "User",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    CampusName = table.Column<string>(nullable: false),
                    AddressID = table.Column<int>(nullable: false),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campuses", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Campuses_Addresses_AddressID",
                        column: x => x.AddressID,
                        principalSchema: "User",
                        principalTable: "Addresses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                });

            migrationBuilder.CreateTable(
                name: "ClockInOut",
                schema: "User",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    EmployeeID = table.Column<string>(nullable: true),
                    ClockInTime = table.Column<DateTime>(nullable: false),
                    ClockOutTime = table.Column<DateTime>(nullable: true),
                    TimeSheetID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClockInOut", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Divisions",
                schema: "User",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    DivisionName = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    SupervisorID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divisions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                schema: "User",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    DepartmentName = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    DivisionID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Departments_Divisions_DivisionID",
                        column: x => x.DivisionID,
                        principalSchema: "User",
                        principalTable: "Divisions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: true),
                    DepartmentID = table.Column<int>(nullable: true),
                    ExemptFromOvertime = table.Column<bool>(nullable: true),
                    HourlyWage = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Departments_DepartmentID",
                        column: x => x.DepartmentID,
                        principalSchema: "User",
                        principalTable: "Departments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TimeSheet",
                schema: "User",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    UserID = table.Column<string>(nullable: false),
                    Approved = table.Column<int>(nullable: false),
                    ReasonDenied = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    ExemptFromOvertime = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeSheet", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TimeSheet_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ADMIN", "81257cc9-dd9c-4390-8d64-bd2fec9385a4", "Admin", "ADMIN" },
                    { "EMPLOYEE", "d1fc2e83-f077-4c16-99a7-31a84a1ef8c8", "Employee", "EMPLOYEE" },
                    { "MANAGER", "8474a616-f0f6-4201-aac7-c5754e6b1f6c", "Manager", "MANAGER" },
                    { "HR", "4d92c4e1-5bb8-4559-8db4-8fc6295cdbe7", "HR", "HR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Active", "DepartmentID", "ExemptFromOvertime", "FirstName", "HourlyWage", "LastName" },
                values: new object[,]
                {
                    { "ADMIN", 0, "fb5e21aa-8275-4c3a-94f4-b41dd9c55518", "Employee", "Admin@Develop.com", true, false, null, "ADMIN@DEVELOP.COM", "ADMIN@DEVELOP.COM", "AQAAAAEAACcQAAAAEE6fNGBLk0gWXtI+YF/euDFjEP3ASy0lEumjpTNbqgowNOzt9/dY3UByIFgSIFf1bA==", null, false, "6ba4f1cb-a39e-4fbf-b81f-b348887296da", false, "Admin@develop.com", true, null, false, "Admin", 30.0, "Admin" },
                    { "HR", 0, "efa35758-cb17-43b1-af08-5e9cfefeda14", "Employee", "HR@develop.com", true, false, null, "HR@DEVELOP.COM", "HR@DEVELOP.COM", "AQAAAAEAACcQAAAAEE6fNGBLk0gWXtI+YF/euDFjEP3ASy0lEumjpTNbqgowNOzt9/dY3UByIFgSIFf1bA==", null, false, "d80afc1a-d3e6-4396-83ad-33188034b8a3", false, "HR@develop.com", true, null, false, "HR", 30.0, "HR" },
                    { "EMPLOYEE", 0, "689f9d1f-21b6-4f43-b9e5-b79aac1e9b0c", "Employee", "EMPLOYEE@develop.com", true, false, null, "EMPLOYEE@DEVELOP.COM", "EMPLOYEE@DEVELOP.COM", "AQAAAAEAACcQAAAAEE6fNGBLk0gWXtI+YF/euDFjEP3ASy0lEumjpTNbqgowNOzt9/dY3UByIFgSIFf1bA==", null, false, "578ce881-d7f2-42c0-b08c-0ef4d236c9ee", false, "EMPLOYEE@develop.com", true, null, false, "EMPLOYEE", 30.0, "EMPLOYEE" },
                    { "MANAGER", 0, "bdea9b05-f148-4750-82e1-94ef0a4fa05c", "Employee", "MANAGER@develop.com", true, false, null, "MANAGER@DEVELOP.COM", "MANAGER@DEVELOP.COM", "AQAAAAEAACcQAAAAEE6fNGBLk0gWXtI+YF/euDFjEP3ASy0lEumjpTNbqgowNOzt9/dY3UByIFgSIFf1bA==", null, false, "592ee882-b9a3-4b16-a94c-42acb3ba3f71", false, "MANAGER@develop.com", true, null, false, "MANAGER", 30.0, "MANAGER" }
                });

            migrationBuilder.InsertData(
                schema: "User",
                table: "Addresses",
                columns: new[] { "ID", "City", "State", "StreetAddress", "TimeStamp", "ZIP" },
                values: new object[,]
                {
                    { 1, "Parkersburg", "West Virginia", "300 Campus Dr.", new DateTime(2020, 11, 29, 16, 36, 12, 396, DateTimeKind.Local).AddTicks(1614), "26101" },
                    { 2, "Ripley", "West Virginia", "105 Academy Dr.", new DateTime(2020, 11, 29, 16, 36, 12, 396, DateTimeKind.Local).AddTicks(1701), "25271" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "ADMIN", "ADMIN" },
                    { "HR", "HR" },
                    { "EMPLOYEE", "EMPLOYEE" },
                    { "MANAGER", "MANAGER" }
                });

            migrationBuilder.InsertData(
                schema: "User",
                table: "Campuses",
                columns: new[] { "ID", "Active", "AddressID", "CampusName", "TimeStamp" },
                values: new object[,]
                {
                    { 1, true, 1, "West Virginia University at Parkersburg", new DateTime(2020, 11, 29, 16, 36, 12, 396, DateTimeKind.Local).AddTicks(3135) },
                    { 2, true, 2, "WVUP Jackson County Center", new DateTime(2020, 11, 29, 16, 36, 12, 396, DateTimeKind.Local).AddTicks(3183) }
                });

            migrationBuilder.InsertData(
                schema: "User",
                table: "Divisions",
                columns: new[] { "ID", "Active", "DivisionName", "SupervisorID", "TimeStamp" },
                values: new object[,]
                {
                    { 1, true, "Science, Technology, Engineering & Math", "ADMIN", new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(419) },
                    { 2, true, "Information Technology", "ADMIN", new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(716) },
                    { 3, true, "Business", "ADMIN", new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(734) },
                    { 4, true, "Maintenance", "ADMIN", new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(739) },
                    { 5, true, "Academic and Student Affairs", "ADMIN", new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(745) },
                    { 6, true, "Office of the President", "ADMIN", new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(751) },
                    { 7, true, "Humanities and Fine Arts", "ADMIN", new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(756) }
                });

            migrationBuilder.InsertData(
                schema: "User",
                table: "Departments",
                columns: new[] { "ID", "Active", "DepartmentName", "DivisionID", "TimeStamp" },
                values: new object[,]
                {
                    { 1, true, "Computer Science", 1, new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(2297) },
                    { 7, true, "STEM", 1, new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(2422) },
                    { 2, true, "Information Technology", 2, new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(2393) },
                    { 3, true, "Business", 3, new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(2400) },
                    { 4, true, "Maintenance", 4, new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(2405) },
                    { 5, true, "Office of Academic Affairs", 5, new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(2411) },
                    { 6, true, "Office of the President", 6, new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(2416) },
                    { 8, true, "Humanities and Fine Arts", 7, new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(2427) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DepartmentID",
                table: "AspNetUsers",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Campuses_AddressID",
                schema: "User",
                table: "Campuses",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_ClockInOut_EmployeeID",
                schema: "User",
                table: "ClockInOut",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_ClockInOut_TimeSheetID",
                schema: "User",
                table: "ClockInOut",
                column: "TimeSheetID");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_DivisionID",
                schema: "User",
                table: "Departments",
                column: "DivisionID");

            migrationBuilder.CreateIndex(
                name: "IX_Divisions_SupervisorID",
                schema: "User",
                table: "Divisions",
                column: "SupervisorID");

            migrationBuilder.CreateIndex(
                name: "IX_TimeSheet_UserID",
                schema: "User",
                table: "TimeSheet",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClockInOut_AspNetUsers_EmployeeID",
                schema: "User",
                table: "ClockInOut",
                column: "EmployeeID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClockInOut_TimeSheet_TimeSheetID",
                schema: "User",
                table: "ClockInOut",
                column: "TimeSheetID",
                principalSchema: "User",
                principalTable: "TimeSheet",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Divisions_AspNetUsers_SupervisorID",
                schema: "User",
                table: "Divisions",
                column: "SupervisorID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Divisions_AspNetUsers_SupervisorID",
                schema: "User",
                table: "Divisions");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Campuses",
                schema: "User");

            migrationBuilder.DropTable(
                name: "ClockInOut",
                schema: "User");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Addresses",
                schema: "User");

            migrationBuilder.DropTable(
                name: "TimeSheet",
                schema: "User");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Departments",
                schema: "User");

            migrationBuilder.DropTable(
                name: "Divisions",
                schema: "User");
        }
    }
}
