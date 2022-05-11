using Microsoft.EntityFrameworkCore.Migrations;

namespace DiscountAPI.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Sodas" },
                    { 2, "Cleaning" },
                    { 3, "Food" },
                    { 4, "Bathroom" }
                });

            migrationBuilder.InsertData(
                table: "Store",
                columns: new[] { "Id", "CloseTime", "Name", "OpenTime" },
                values: new object[,]
                {
                    { 1, 22, "COCO Downtown", 9 },
                    { 2, 22, "COCO Bay", 9 },
                    { 3, 22, "COCO Mall", 9 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Cold Ice Tea", "Cold Ice Tea", 10.0 },
                    { 20, 4, "Generic soap", "Generic soap", 48.0 },
                    { 19, 4, "Pure steel toilet paper", "Pure steel toilet paper", 46.0 },
                    { 18, 3, "Milanga ganga napo", "Milanga ganga napo", 44.0 },
                    { 17, 3, "Milanga ganga", "Milanga ganga", 42.0 },
                    { 16, 3, "Ravioloches x48", "Ravioloches x48", 40.0 },
                    { 15, 3, "Ravioloches x12", "Ravioloches x12", 38.0 },
                    { 14, 3, "LACTEL bread", "LACTEL bread", 36.0 },
                    { 13, 3, "Garlic-o-bread 2000", "Garlic-o-bread 2000", 34.0 },
                    { 12, 3, "Windmill Cookies", "Windmill Cookies", 32.0 },
                    { 11, 3, "Salsa Cookies", "Salsa Cookies", 30.0 },
                    { 10, 2, "Generic mop", "Generic mop", 28.0 },
                    { 9, 2, "Sponge, Bob", "Sponge, Bob", 26.0 },
                    { 8, 2, "Virulanita", "Virulanita", 24.0 },
                    { 7, 2, "Atlantis detergent", "Atlantis detergent", 22.0 },
                    { 6, 1, "Diet Slurm", "Diet Slurm", 20.0 },
                    { 5, 1, "Slurm", "Slurm", 18.0 },
                    { 4, 1, "Sprute", "Sprute", 16.0 },
                    { 3, 1, "Nuke-Cola", "Nuke-Cola", 14.0 },
                    { 2, 1, "Coffee flavoured milk", "Coffee flavoured milk", 12.0 },
                    { 21, 4, "PANTONE shampoo", "PANTONE shampoo", 50.0 },
                    { 22, 4, "Cabbagegate toothpaste", "Cabbagegate toothpaste", 52.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
