using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OPMSProto20202109.Migrations
{
    public partial class init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmployeeID",
                schema: "User",
                table: "ClockInOut",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ADMIN",
                column: "ConcurrencyStamp",
                value: "a4147303-b873-44d9-b7aa-196211d223d1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "EMPLOYEE",
                column: "ConcurrencyStamp",
                value: "162da478-f28e-44f3-8aaf-c7df71db5be2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "HR",
                column: "ConcurrencyStamp",
                value: "1b65bfe0-7551-42a3-bac4-4b5d3a9202d5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "MANAGER",
                column: "ConcurrencyStamp",
                value: "4f19634c-f1ba-40eb-8f32-41926563e359");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ADMIN",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b6d263b2-54d5-4685-8b1c-47bddc76c903", "460b033a-3b32-421e-9777-34d3075e8f6e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "EMPLOYEE",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bdf82d0a-5633-40d0-bdc6-d640f2ed114b", "253bdb23-fb7b-4e36-8386-59dba78bf7e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "HR",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8f322e9d-4122-408a-adff-edfcc6cf086c", "570cb8f9-890d-4a31-88fd-facb720bdec8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "MANAGER",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b1ab7d9f-7122-44c9-a578-11ee86a26a31", "83885efe-25ad-43eb-a09d-ff7656a70783" });

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Addresses",
                keyColumn: "ID",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 23, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(1170));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Addresses",
                keyColumn: "ID",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 23, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Campuses",
                keyColumn: "ID",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 23, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(2725));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Campuses",
                keyColumn: "ID",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 23, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(2771));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Departments",
                keyColumn: "ID",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 23, 15, 49, 34, 896, DateTimeKind.Local).AddTicks(1817));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Departments",
                keyColumn: "ID",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 23, 15, 49, 34, 896, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Departments",
                keyColumn: "ID",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 23, 15, 49, 34, 896, DateTimeKind.Local).AddTicks(1867));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Departments",
                keyColumn: "ID",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 23, 15, 49, 34, 896, DateTimeKind.Local).AddTicks(1872));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Departments",
                keyColumn: "ID",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 23, 15, 49, 34, 896, DateTimeKind.Local).AddTicks(1878));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Departments",
                keyColumn: "ID",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 23, 15, 49, 34, 896, DateTimeKind.Local).AddTicks(1884));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Departments",
                keyColumn: "ID",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 23, 15, 49, 34, 896, DateTimeKind.Local).AddTicks(1889));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Departments",
                keyColumn: "ID",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 23, 15, 49, 34, 896, DateTimeKind.Local).AddTicks(1895));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Divisions",
                keyColumn: "ID",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 23, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(9997));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Divisions",
                keyColumn: "ID",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 23, 15, 49, 34, 896, DateTimeKind.Local).AddTicks(275));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Divisions",
                keyColumn: "ID",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 23, 15, 49, 34, 896, DateTimeKind.Local).AddTicks(296));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Divisions",
                keyColumn: "ID",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 23, 15, 49, 34, 896, DateTimeKind.Local).AddTicks(302));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Divisions",
                keyColumn: "ID",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 23, 15, 49, 34, 896, DateTimeKind.Local).AddTicks(308));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Divisions",
                keyColumn: "ID",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 23, 15, 49, 34, 896, DateTimeKind.Local).AddTicks(313));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Divisions",
                keyColumn: "ID",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 23, 15, 49, 34, 896, DateTimeKind.Local).AddTicks(319));

            migrationBuilder.CreateIndex(
                name: "IX_ClockInOut_EmployeeID",
                schema: "User",
                table: "ClockInOut",
                column: "EmployeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_ClockInOut_AspNetUsers_EmployeeID",
                schema: "User",
                table: "ClockInOut",
                column: "EmployeeID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClockInOut_AspNetUsers_EmployeeID",
                schema: "User",
                table: "ClockInOut");

            migrationBuilder.DropIndex(
                name: "IX_ClockInOut_EmployeeID",
                schema: "User",
                table: "ClockInOut");

            migrationBuilder.DropColumn(
                name: "EmployeeID",
                schema: "User",
                table: "ClockInOut");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ADMIN",
                column: "ConcurrencyStamp",
                value: "0ac8c81e-c298-4d55-b658-849ea36252df");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "EMPLOYEE",
                column: "ConcurrencyStamp",
                value: "7064961a-ff53-4b12-b553-45bf52a71556");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "HR",
                column: "ConcurrencyStamp",
                value: "f938175f-2a05-483f-b755-6b678396ae74");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "MANAGER",
                column: "ConcurrencyStamp",
                value: "b1f8887f-ccd8-4588-923a-234333e93425");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ADMIN",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "546b4452-28b2-4050-9baf-69d7896c5a32", "e5a932c1-3d01-4ca3-95c6-e9e2da5eebf0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "EMPLOYEE",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3fced326-333e-4370-87b2-27d54f0b8dbd", "0634fd6f-5b39-444c-b3fe-4b98064f6bf3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "HR",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "04570a7e-8b17-4e3f-8425-a2296f45b07c", "c4f57f1d-6300-4411-ac78-e6d1cc104374" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "MANAGER",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f8ff18ed-196a-4cac-9e96-7d808c5dc7ea", "1f2b37a7-ea1c-40ac-92c1-09dd593b23c2" });

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Addresses",
                keyColumn: "ID",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 18, 16, 20, 11, 484, DateTimeKind.Local).AddTicks(2744));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Addresses",
                keyColumn: "ID",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 18, 16, 20, 11, 484, DateTimeKind.Local).AddTicks(2840));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Campuses",
                keyColumn: "ID",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 18, 16, 20, 11, 484, DateTimeKind.Local).AddTicks(4313));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Campuses",
                keyColumn: "ID",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 18, 16, 20, 11, 484, DateTimeKind.Local).AddTicks(4362));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Departments",
                keyColumn: "ID",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 18, 16, 20, 11, 485, DateTimeKind.Local).AddTicks(3833));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Departments",
                keyColumn: "ID",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 18, 16, 20, 11, 485, DateTimeKind.Local).AddTicks(3880));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Departments",
                keyColumn: "ID",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 18, 16, 20, 11, 485, DateTimeKind.Local).AddTicks(3887));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Departments",
                keyColumn: "ID",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 18, 16, 20, 11, 485, DateTimeKind.Local).AddTicks(3892));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Departments",
                keyColumn: "ID",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 18, 16, 20, 11, 485, DateTimeKind.Local).AddTicks(3898));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Departments",
                keyColumn: "ID",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 18, 16, 20, 11, 485, DateTimeKind.Local).AddTicks(3903));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Departments",
                keyColumn: "ID",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 18, 16, 20, 11, 485, DateTimeKind.Local).AddTicks(3909));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Departments",
                keyColumn: "ID",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 18, 16, 20, 11, 485, DateTimeKind.Local).AddTicks(3914));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Divisions",
                keyColumn: "ID",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 18, 16, 20, 11, 485, DateTimeKind.Local).AddTicks(1944));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Divisions",
                keyColumn: "ID",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 18, 16, 20, 11, 485, DateTimeKind.Local).AddTicks(2226));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Divisions",
                keyColumn: "ID",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 18, 16, 20, 11, 485, DateTimeKind.Local).AddTicks(2247));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Divisions",
                keyColumn: "ID",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 18, 16, 20, 11, 485, DateTimeKind.Local).AddTicks(2253));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Divisions",
                keyColumn: "ID",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 18, 16, 20, 11, 485, DateTimeKind.Local).AddTicks(2259));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Divisions",
                keyColumn: "ID",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 18, 16, 20, 11, 485, DateTimeKind.Local).AddTicks(2264));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Divisions",
                keyColumn: "ID",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 18, 16, 20, 11, 485, DateTimeKind.Local).AddTicks(2270));
        }
    }
}
