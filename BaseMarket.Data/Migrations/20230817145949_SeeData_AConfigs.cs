using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseMarket.Data.Migrations
{
    public partial class SeeData_AConfigs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeDescription");

            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeKeyword");

            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeTitle");

            migrationBuilder.InsertData(
                table: "AppConfigs",
                columns: new[] { "Key", "Value" },
                values: new object[,]
                {
                    { "Home Description", "This is description of Web Market Online 1 " },
                    { "Home Keyword", "This is keyword of Web Market Online  1 " },
                    { "Home Title", "This is home page of Web Market Online 1" }
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 17, 21, 59, 49, 141, DateTimeKind.Local).AddTicks(8483), new DateTime(2023, 8, 17, 21, 59, 49, 141, DateTimeKind.Local).AddTicks(8493) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 17, 21, 59, 49, 141, DateTimeKind.Local).AddTicks(8496), new DateTime(2023, 8, 17, 21, 59, 49, 141, DateTimeKind.Local).AddTicks(8496) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 17, 21, 59, 49, 141, DateTimeKind.Local).AddTicks(8512), new DateTime(2023, 8, 17, 21, 59, 49, 141, DateTimeKind.Local).AddTicks(8512) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 17, 21, 59, 49, 141, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 8, 17, 21, 59, 49, 141, DateTimeKind.Local).AddTicks(8516) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "Home Description");

            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "Home Keyword");

            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "Home Title");

            migrationBuilder.InsertData(
                table: "AppConfigs",
                columns: new[] { "Key", "Value" },
                values: new object[,]
                {
                    { "HomeDescription", "This is description of Web Market Online 1 " },
                    { "HomeKeyword", "This is keyword of Web Market Online  1  " },
                    { "HomeTitle", "This is home page of Web Market Online 1 " }
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 17, 21, 56, 32, 399, DateTimeKind.Local).AddTicks(6783), new DateTime(2023, 8, 17, 21, 56, 32, 399, DateTimeKind.Local).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 17, 21, 56, 32, 399, DateTimeKind.Local).AddTicks(6795), new DateTime(2023, 8, 17, 21, 56, 32, 399, DateTimeKind.Local).AddTicks(6796) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 17, 21, 56, 32, 399, DateTimeKind.Local).AddTicks(6809), new DateTime(2023, 8, 17, 21, 56, 32, 399, DateTimeKind.Local).AddTicks(6810) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 17, 21, 56, 32, 399, DateTimeKind.Local).AddTicks(6815), new DateTime(2023, 8, 17, 21, 56, 32, 399, DateTimeKind.Local).AddTicks(6815) });
        }
    }
}
