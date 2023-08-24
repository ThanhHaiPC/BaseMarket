using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseMarket.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "50193e44-6b05-4cce-b625-c4bdd69f0da7");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("c1b3efbd-1e1f-47b5-b5d6-9062046f0166"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bc9e3bf5-f6e2-42d4-814f-2939f11c8371", "AQAAAAEAACcQAAAAELr4qj8BN5fAQvdOsaalLvUqfai/s/onkss4kKC7RZonhB/u5W67Pzo046k5ooyfLA==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 24, 15, 20, 6, 910, DateTimeKind.Local).AddTicks(6293), new DateTime(2023, 8, 24, 15, 20, 6, 910, DateTimeKind.Local).AddTicks(6303) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 24, 15, 20, 6, 910, DateTimeKind.Local).AddTicks(6305), new DateTime(2023, 8, 24, 15, 20, 6, 910, DateTimeKind.Local).AddTicks(6306) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 24, 15, 20, 6, 910, DateTimeKind.Local).AddTicks(6321), new DateTime(2023, 8, 24, 15, 20, 6, 910, DateTimeKind.Local).AddTicks(6322) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 24, 15, 20, 6, 910, DateTimeKind.Local).AddTicks(6324), new DateTime(2023, 8, 24, 15, 20, 6, 910, DateTimeKind.Local).AddTicks(6325) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "d0e6244f-adea-409e-bfcd-29b9ce6bf43f");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("c1b3efbd-1e1f-47b5-b5d6-9062046f0166"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "01cc60d0-075c-4d40-ac80-3db4cfe405db", "AQAAAAEAACcQAAAAEO4v84/3tDZ9fDyXoQ4S//qFKquVI2CDzksoUkoEZJyBVAghUsBuq45UIoR6VUwsvA==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 24, 14, 31, 21, 545, DateTimeKind.Local).AddTicks(3302), new DateTime(2023, 8, 24, 14, 31, 21, 545, DateTimeKind.Local).AddTicks(3312) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 24, 14, 31, 21, 545, DateTimeKind.Local).AddTicks(3315), new DateTime(2023, 8, 24, 14, 31, 21, 545, DateTimeKind.Local).AddTicks(3316) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 24, 14, 31, 21, 545, DateTimeKind.Local).AddTicks(3329), new DateTime(2023, 8, 24, 14, 31, 21, 545, DateTimeKind.Local).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 24, 14, 31, 21, 545, DateTimeKind.Local).AddTicks(3332), new DateTime(2023, 8, 24, 14, 31, 21, 545, DateTimeKind.Local).AddTicks(3332) });
        }
    }
}
