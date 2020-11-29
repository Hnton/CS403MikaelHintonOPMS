using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OPMSProto20202109.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ADMIN",
                column: "ConcurrencyStamp",
                value: "e776c596-b44a-4d0c-b7a1-87043805ff8e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "EMPLOYEE",
                column: "ConcurrencyStamp",
                value: "a9c97cf6-7d5e-465d-94d7-27cd0e59b3ec");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "HR",
                column: "ConcurrencyStamp",
                value: "d3cefd1f-7d5e-4b7c-9efa-dca666351841");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "MANAGER",
                column: "ConcurrencyStamp",
                value: "2733daad-48ad-45e1-83f0-f711ac0a29e7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ADMIN",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3f2dc300-cf52-47e4-b846-e2bd4dd50e71", "cbe2b09a-b111-4155-aa7b-0dd0dc374ff0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "EMPLOYEE",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1e113ee5-9b4a-44ce-a2cd-cabd08ff5e8b", "4be7c7a4-4797-4977-a5a1-d9001564dc0f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "HR",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6d1a7d9a-0413-4db5-be07-5932a590fe1e", "61d9e540-72c5-4065-b383-43b96b60ffa3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "MANAGER",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a6bed6c4-1ab3-4bad-a0f5-513159041468", "a780b54f-6fd7-495d-ab6a-0d1cbc54b255" });

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Addresses",
                keyColumn: "ID",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 29, 16, 56, 15, 96, DateTimeKind.Local).AddTicks(1682));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Addresses",
                keyColumn: "ID",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 29, 16, 56, 15, 96, DateTimeKind.Local).AddTicks(1768));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Campuses",
                keyColumn: "ID",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 29, 16, 56, 15, 96, DateTimeKind.Local).AddTicks(3109));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Campuses",
                keyColumn: "ID",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 29, 16, 56, 15, 96, DateTimeKind.Local).AddTicks(3157));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Departments",
                keyColumn: "ID",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 29, 16, 56, 15, 97, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Departments",
                keyColumn: "ID",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 29, 16, 56, 15, 97, DateTimeKind.Local).AddTicks(2582));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Departments",
                keyColumn: "ID",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 29, 16, 56, 15, 97, DateTimeKind.Local).AddTicks(2589));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Departments",
                keyColumn: "ID",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 29, 16, 56, 15, 97, DateTimeKind.Local).AddTicks(2594));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Departments",
                keyColumn: "ID",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 29, 16, 56, 15, 97, DateTimeKind.Local).AddTicks(2600));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Departments",
                keyColumn: "ID",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 29, 16, 56, 15, 97, DateTimeKind.Local).AddTicks(2606));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Departments",
                keyColumn: "ID",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 29, 16, 56, 15, 97, DateTimeKind.Local).AddTicks(2611));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Departments",
                keyColumn: "ID",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 29, 16, 56, 15, 97, DateTimeKind.Local).AddTicks(2617));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Divisions",
                keyColumn: "ID",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 29, 16, 56, 15, 97, DateTimeKind.Local).AddTicks(618));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Divisions",
                keyColumn: "ID",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 29, 16, 56, 15, 97, DateTimeKind.Local).AddTicks(904));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Divisions",
                keyColumn: "ID",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 29, 16, 56, 15, 97, DateTimeKind.Local).AddTicks(927));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Divisions",
                keyColumn: "ID",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 29, 16, 56, 15, 97, DateTimeKind.Local).AddTicks(933));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Divisions",
                keyColumn: "ID",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 29, 16, 56, 15, 97, DateTimeKind.Local).AddTicks(939));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Divisions",
                keyColumn: "ID",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 29, 16, 56, 15, 97, DateTimeKind.Local).AddTicks(945));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Divisions",
                keyColumn: "ID",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 29, 16, 56, 15, 97, DateTimeKind.Local).AddTicks(951));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ADMIN",
                column: "ConcurrencyStamp",
                value: "81257cc9-dd9c-4390-8d64-bd2fec9385a4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "EMPLOYEE",
                column: "ConcurrencyStamp",
                value: "d1fc2e83-f077-4c16-99a7-31a84a1ef8c8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "HR",
                column: "ConcurrencyStamp",
                value: "4d92c4e1-5bb8-4559-8db4-8fc6295cdbe7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "MANAGER",
                column: "ConcurrencyStamp",
                value: "8474a616-f0f6-4201-aac7-c5754e6b1f6c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ADMIN",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fb5e21aa-8275-4c3a-94f4-b41dd9c55518", "6ba4f1cb-a39e-4fbf-b81f-b348887296da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "EMPLOYEE",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "689f9d1f-21b6-4f43-b9e5-b79aac1e9b0c", "578ce881-d7f2-42c0-b08c-0ef4d236c9ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "HR",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "efa35758-cb17-43b1-af08-5e9cfefeda14", "d80afc1a-d3e6-4396-83ad-33188034b8a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "MANAGER",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bdea9b05-f148-4750-82e1-94ef0a4fa05c", "592ee882-b9a3-4b16-a94c-42acb3ba3f71" });

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Addresses",
                keyColumn: "ID",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 29, 16, 36, 12, 396, DateTimeKind.Local).AddTicks(1614));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Addresses",
                keyColumn: "ID",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 29, 16, 36, 12, 396, DateTimeKind.Local).AddTicks(1701));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Campuses",
                keyColumn: "ID",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 29, 16, 36, 12, 396, DateTimeKind.Local).AddTicks(3135));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Campuses",
                keyColumn: "ID",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 29, 16, 36, 12, 396, DateTimeKind.Local).AddTicks(3183));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Departments",
                keyColumn: "ID",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(2297));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Departments",
                keyColumn: "ID",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(2393));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Departments",
                keyColumn: "ID",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Departments",
                keyColumn: "ID",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(2405));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Departments",
                keyColumn: "ID",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(2411));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Departments",
                keyColumn: "ID",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(2416));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Departments",
                keyColumn: "ID",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(2422));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Departments",
                keyColumn: "ID",
                keyValue: 8,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(2427));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Divisions",
                keyColumn: "ID",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Divisions",
                keyColumn: "ID",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(716));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Divisions",
                keyColumn: "ID",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(734));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Divisions",
                keyColumn: "ID",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(739));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Divisions",
                keyColumn: "ID",
                keyValue: 5,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(745));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Divisions",
                keyColumn: "ID",
                keyValue: 6,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "Divisions",
                keyColumn: "ID",
                keyValue: 7,
                column: "TimeStamp",
                value: new DateTime(2020, 11, 29, 16, 36, 12, 397, DateTimeKind.Local).AddTicks(756));
        }
    }
}
