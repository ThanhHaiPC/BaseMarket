using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseMarket.Data.Migrations
{
    public partial class AddProductImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.CreateTable(
                name: "ProductImage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImage_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductImage_ProductID",
                table: "ProductImage",
                column: "ProductID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImage");

          

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "ffb4345f-5e93-4d3d-a90c-75a9a8209c56");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("c1b3efbd-1e1f-47b5-b5d6-9062046f0166"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "280a06f8-2bf7-47d3-833e-7bff4a8fac6a", "AQAAAAEAACcQAAAAELRLmq/TRykQuCbpr4Ub1bbM+8pRetwzovJs6cqzDpQhxkHHh1O0c18I+ZeeUQcriQ==" });

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
                columns: new[] { "CreateDate", "Image", "UpdateDate", "Video" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 4, 59, 125, DateTimeKind.Local).AddTicks(8217), "", new DateTime(2023, 8, 18, 17, 4, 59, 125, DateTimeKind.Local).AddTicks(8217), "" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 2,
                columns: new[] { "CreateDate", "Image", "UpdateDate", "Video" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 4, 59, 125, DateTimeKind.Local).AddTicks(8220), "", new DateTime(2023, 8, 18, 17, 4, 59, 125, DateTimeKind.Local).AddTicks(8220), "" });
        }
    }
}
