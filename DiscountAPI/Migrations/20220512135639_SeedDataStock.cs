using Microsoft.EntityFrameworkCore.Migrations;

namespace DiscountAPI.Migrations
{
    public partial class SeedDataStock : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Stock",
                columns: new[] { "ProductStockId", "StoreStockId", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 10 },
                    { 2, 1, 20 },
                    { 3, 1, 10 },
                    { 4, 1, 12 },
                    { 10, 2, 30 },
                    { 18, 2, 5 },
                    { 13, 2, 30 },
                    { 22, 2, 5 },
                    { 5, 3, 11 },
                    { 6, 3, 15 },
                    { 3, 3, 10 },
                    { 8, 3, 12 },
                    { 4, 3, 9 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stock",
                keyColumns: new[] { "ProductStockId", "StoreStockId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Stock",
                keyColumns: new[] { "ProductStockId", "StoreStockId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Stock",
                keyColumns: new[] { "ProductStockId", "StoreStockId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Stock",
                keyColumns: new[] { "ProductStockId", "StoreStockId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "Stock",
                keyColumns: new[] { "ProductStockId", "StoreStockId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "Stock",
                keyColumns: new[] { "ProductStockId", "StoreStockId" },
                keyValues: new object[] { 13, 2 });

            migrationBuilder.DeleteData(
                table: "Stock",
                keyColumns: new[] { "ProductStockId", "StoreStockId" },
                keyValues: new object[] { 18, 2 });

            migrationBuilder.DeleteData(
                table: "Stock",
                keyColumns: new[] { "ProductStockId", "StoreStockId" },
                keyValues: new object[] { 22, 2 });

            migrationBuilder.DeleteData(
                table: "Stock",
                keyColumns: new[] { "ProductStockId", "StoreStockId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Stock",
                keyColumns: new[] { "ProductStockId", "StoreStockId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "Stock",
                keyColumns: new[] { "ProductStockId", "StoreStockId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "Stock",
                keyColumns: new[] { "ProductStockId", "StoreStockId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "Stock",
                keyColumns: new[] { "ProductStockId", "StoreStockId" },
                keyValues: new object[] { 8, 3 });
        }
    }
}
