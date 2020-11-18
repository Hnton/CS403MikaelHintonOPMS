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

            migrationBuilder.CreateTable(
                name: "ClockInOut",
                schema: "User",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    ClockInTime = table.Column<DateTime>(nullable: false),
                    ClockOutTime = table.Column<DateTime>(nullable: true),
                    TimeSheetID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClockInOut", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ClockInOut_TimeSheet_TimeSheetID",
                        column: x => x.TimeSheetID,
                        principalSchema: "User",
                        principalTable: "TimeSheet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ADMIN", "0ac8c81e-c298-4d55-b658-849ea36252df", "Admin", "ADMIN" },
                    { "EMPLOYEE", "7064961a-ff53-4b12-b553-45bf52a71556", "Employee", "EMPLOYEE" },
                    { "MANAGER", "b1f8887f-ccd8-4588-923a-234333e93425", "Manager", "MANAGER" },
                    { "HR", "f938175f-2a05-483f-b755-6b678396ae74", "HR", "HR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Active", "DepartmentID", "ExemptFromOvertime", "FirstName", "HourlyWage", "LastName" },
                values: new object[,]
                {
                    { "ADMIN", 0, "546b4452-28b2-4050-9baf-69d7896c5a32", "Employee", "Admin@Develop.com", true, false, null, "ADMIN@DEVELOP.COM", "ADMIN@DEVELOP.COM", "AQAAAAEAACcQAAAAEE6fNGBLk0gWXtI+YF/euDFjEP3ASy0lEumjpTNbqgowNOzt9/dY3UByIFgSIFf1bA==", null, false, "e5a932c1-3d01-4ca3-95c6-e9e2da5eebf0", false, "Admin@develop.com", true, null, false, "Admin", 30.0, "Admin" },
                    { "HR", 0, "04570a7e-8b17-4e3f-8425-a2296f45b07c", "Employee", "HR@develop.com", true, false, null, "HR@DEVELOP.COM", "HR@DEVELOP.COM", "AQAAAAEAACcQAAAAEE6fNGBLk0gWXtI+YF/euDFjEP3ASy0lEumjpTNbqgowNOzt9/dY3UByIFgSIFf1bA==", null, false, "c4f57f1d-6300-4411-ac78-e6d1cc104374", false, "HR@develop.com", true, null, false, "HR", 30.0, "HR" },
                    { "EMPLOYEE", 0, "3fced326-333e-4370-87b2-27d54f0b8dbd", "Employee", "EMPLOYEE@develop.com", true, false, null, "EMPLOYEE@DEVELOP.COM", "EMPLOYEE@DEVELOP.COM", "AQAAAAEAACcQAAAAEE6fNGBLk0gWXtI+YF/euDFjEP3ASy0lEumjpTNbqgowNOzt9/dY3UByIFgSIFf1bA==", null, false, "0634fd6f-5b39-444c-b3fe-4b98064f6bf3", false, "EMPLOYEE@develop.com", true, null, false, "EMPLOYEE", 30.0, "EMPLOYEE" },
                    { "MANAGER", 0, "f8ff18ed-196a-4cac-9e96-7d808c5dc7ea", "Employee", "MANAGER@develop.com", true, false, null, "MANAGER@DEVELOP.COM", "MANAGER@DEVELOP.COM", "AQAAAAEAACcQAAAAEE6fNGBLk0gWXtI+YF/euDFjEP3ASy0lEumjpTNbqgowNOzt9/dY3UByIFgSIFf1bA==", null, false, "1f2b37a7-ea1c-40ac-92c1-09dd593b23c2", false, "MANAGER@develop.com", true, null, false, "MANAGER", 30.0, "MANAGER" }
                });

            migrationBuilder.InsertData(
                schema: "User",
                table: "Addresses",
                columns: new[] { "ID", "City", "State", "StreetAddress", "TimeStamp", "ZIP" },
                values: new object[,]
                {
                    { 1, "Parkersburg", "West Virginia", "300 Campus Dr.", new DateTime(2020, 11, 18, 16, 20, 11, 484, DateTimeKind.Local).AddTicks(2744), "26101" },
                    { 2, "Ripley", "West Virginia", "105 Academy Dr.", new DateTime(2020, 11, 18, 16, 20, 11, 484, DateTimeKind.Local).AddTicks(2840), "25271" }
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
                    { 1, true, 1, "West Virginia University at Parkersburg", new DateTime(2020, 11, 18, 16, 20, 11, 484, DateTimeKind.Local).AddTicks(4313) },
                    { 2, true, 2, "WVUP Jackson County Center", new DateTime(2020, 11, 18, 16, 20, 11, 484, DateTimeKind.Local).AddTicks(4362) }
                });

            migrationBuilder.InsertData(
                schema: "User",
                table: "Divisions",
                columns: new[] { "ID", "Active", "DivisionName", "SupervisorID", "TimeStamp" },
                values: new object[,]
                {
                    { 1, true, "Science, Technology, Engineering & Math", "ADMIN", new DateTime(2020, 11, 18, 16, 20, 11, 485, DateTimeKind.Local).AddTicks(1944) },
                    { 2, true, "Information Technology", "ADMIN", new DateTime(2020, 11, 18, 16, 20, 11, 485, DateTimeKind.Local).AddTicks(2226) },
                    { 3, true, "Business", "ADMIN", new DateTime(2020, 11, 18, 16, 20, 11, 485, DateTimeKind.Local).AddTicks(2247) },
                    { 4, true, "Maintenance", "ADMIN", new DateTime(2020, 11, 18, 16, 20, 11, 485, DateTimeKind.Local).AddTicks(2253) },
                    { 5, true, "Academic and Student Affairs", "ADMIN", new DateTime(2020, 11, 18, 16, 20, 11, 485, DateTimeKind.Local).AddTicks(2259) },
                    { 6, true, "Office of the President", "ADMIN", new DateTime(2020, 11, 18, 16, 20, 11, 485, DateTimeKind.Local).AddTicks(2264) },
                    { 7, true, "Humanities and Fine Arts", "ADMIN", new DateTime(2020, 11, 18, 16, 20, 11, 485, DateTimeKind.Local).AddTicks(2270) }
                });

            migrationBuilder.InsertData(
                schema: "User",
                table: "Departments",
                columns: new[] { "ID", "Active", "DepartmentName", "DivisionID", "TimeStamp" },
                values: new object[,]
                {
                    { 1, true, "Computer Science", 1, new DateTime(2020, 11, 18, 16, 20, 11, 485, DateTimeKind.Local).AddTicks(3833) },
                    { 7, true, "STEM", 1, new DateTime(2020, 11, 18, 16, 20, 11, 485, DateTimeKind.Local).AddTicks(3909) },
                    { 2, true, "Information Technology", 2, new DateTime(2020, 11, 18, 16, 20, 11, 485, DateTimeKind.Local).AddTicks(3880) },
                    { 3, true, "Business", 3, new DateTime(2020, 11, 18, 16, 20, 11, 485, DateTimeKind.Local).AddTicks(3887) },
                    { 4, true, "Maintenance", 4, new DateTime(2020, 11, 18, 16, 20, 11, 485, DateTimeKind.Local).AddTicks(3892) },
                    { 5, true, "Office of Academic Affairs", 5, new DateTime(2020, 11, 18, 16, 20, 11, 485, DateTimeKind.Local).AddTicks(3898) },
                    { 6, true, "Office of the President", 6, new DateTime(2020, 11, 18, 16, 20, 11, 485, DateTimeKind.Local).AddTicks(3903) },
                    { 8, true, "Humanities and Fine Arts", 7, new DateTime(2020, 11, 18, 16, 20, 11, 485, DateTimeKind.Local).AddTicks(3914) }
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
