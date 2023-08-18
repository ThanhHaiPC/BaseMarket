using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseMarket.Data.Migrations
{
    public partial class seedata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "Active", "Alias", "CategoryName", "Cover", "CreateDate", "Description", "DisplayOrder", "Image", "Levels", "MetaDes", "MetaKey", "MetaTitle", "ParentID", "SchemaMarkup", "Title", "UpdateDate" },
                values: new object[,]
                {
                    { 1, 1, "hoa-qua", "Hoa quả", "", new DateTime(2023, 8, 17, 21, 29, 37, 259, DateTimeKind.Local).AddTicks(7327), "Hoa quả mới nhập về rất ngon", 2, "", 2, "Hoa quả rất ngọt và ngon", "", "Hoa quả rất ngọt và ngon", 0, "", "", new DateTime(2023, 8, 17, 21, 29, 37, 259, DateTimeKind.Local).AddTicks(7336) },
                    { 2, 1, "thit", "Thịt ", "", new DateTime(2023, 8, 17, 21, 29, 37, 259, DateTimeKind.Local).AddTicks(7339), "Thịt mới nhập về rất ngon", 1, "", 1, "Thịt rất ngon và tốt cho sức khỏe ", "", "Thịt rất ngon và tốt cho sức khỏe ", 0, "", "", new DateTime(2023, 8, 17, 21, 29, 37, 259, DateTimeKind.Local).AddTicks(7340) }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductID", "Active", "Alias", "BestSellers", "CreateDate", "Description", "Discount", "HomeFlag", "Image", "MetaDes", "MetaKey", "MetaTitle", "Price", "ProductName", "ShortDesc", "Tags", "Title", "UnitStock", "UpdateDate", "Video" },
                values: new object[,]
                {
                    { 1, 1, "hoa-qua", 0, new DateTime(2023, 8, 17, 21, 29, 37, 259, DateTimeKind.Local).AddTicks(7359), "Trái táo giòn tan", 5000, 0, "", "Hoa quả rất ngọt và ngon", "", "Hoa quả rất ngọt và ngon", 15000, "Trái táo", "Trái táo giòn tan", "", "", 50, new DateTime(2023, 8, 17, 21, 29, 37, 259, DateTimeKind.Local).AddTicks(7359), "" },
                    { 2, 1, "hoa-qua", 0, new DateTime(2023, 8, 17, 21, 29, 37, 259, DateTimeKind.Local).AddTicks(7367), "Trái xoài giòn tan", 5000, 0, "", "Hoa quả rất ngọt và ngon", "", "Hoa quả rất ngọt và ngon", 30000, "Trái xoài", "Trái xoài giòn tan", "", "", 20, new DateTime(2023, 8, 17, 21, 29, 37, 259, DateTimeKind.Local).AddTicks(7367), "" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 2);
        }
    }
}
