using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseMarket.Data.Migrations
{
    public partial class SeeingdataUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppRole",
                columns: new[] { "Id", "ConcurrencyStamp", "CreateDate", "Name", "NormalizedName", "ShortDesc", "UpdateDate" },
                values: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "ffb4345f-5e93-4d3d-a90c-75a9a8209c56", new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin", "admin", "Administrator role", new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "ConcurrencyStamp", "CreateDate", "Email", "EmailConfirmed", "Fullname", "LastLogin", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateDate", "UserName" },
                values: new object[] { new Guid("c1b3efbd-1e1f-47b5-b5d6-9062046f0166"), 0, "Biên Hòa Đồng Nai", "", "280a06f8-2bf7-47d3-833e-7bff4a8fac6a", new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "ThanhHaiPC2002@gmail.com", true, "Phạm Thanh Hải", new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "ThanhHaiPC2002@gmail.com", "admin", "AQAAAAEAACcQAAAAELRLmq/TRykQuCbpr4Ub1bbM+8pRetwzovJs6cqzDpQhxkHHh1O0c18I+ZeeUQcriQ==", "0967021502", null, false, "", false, new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), new Guid("c1b3efbd-1e1f-47b5-b5d6-9062046f0166") });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 4, 59, 125, DateTimeKind.Local).AddTicks(8188), new DateTime(2023, 8, 18, 17, 4, 59, 125, DateTimeKind.Local).AddTicks(8198) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 4, 59, 125, DateTimeKind.Local).AddTicks(8200), new DateTime(2023, 8, 18, 17, 4, 59, 125, DateTimeKind.Local).AddTicks(8200) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 4, 59, 125, DateTimeKind.Local).AddTicks(8217), new DateTime(2023, 8, 18, 17, 4, 59, 125, DateTimeKind.Local).AddTicks(8217) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 4, 59, 125, DateTimeKind.Local).AddTicks(8220), new DateTime(2023, 8, 18, 17, 4, 59, 125, DateTimeKind.Local).AddTicks(8220) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"));

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("c1b3efbd-1e1f-47b5-b5d6-9062046f0166"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), new Guid("c1b3efbd-1e1f-47b5-b5d6-9062046f0166") });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 2, 54, 109, DateTimeKind.Local).AddTicks(337), new DateTime(2023, 8, 18, 17, 2, 54, 109, DateTimeKind.Local).AddTicks(347) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 2, 54, 109, DateTimeKind.Local).AddTicks(349), new DateTime(2023, 8, 18, 17, 2, 54, 109, DateTimeKind.Local).AddTicks(350) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 2, 54, 109, DateTimeKind.Local).AddTicks(363), new DateTime(2023, 8, 18, 17, 2, 54, 109, DateTimeKind.Local).AddTicks(364) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 2, 54, 109, DateTimeKind.Local).AddTicks(367), new DateTime(2023, 8, 18, 17, 2, 54, 109, DateTimeKind.Local).AddTicks(367) });
        }
    }
}
