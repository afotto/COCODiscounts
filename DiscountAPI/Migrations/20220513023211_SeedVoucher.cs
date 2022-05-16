using Microsoft.EntityFrameworkCore.Migrations;

namespace DiscountAPI.Migrations
{
    public partial class SeedVoucher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ItemsVoucher",
                columns: new[] { "Id", "Item", "TitleVoucher", "VoucherTitle" },
                values: new object[,]
                {
                    { 1, "20% off on Wednesdays and Thursdays", "COCOG730CNSG8ZVX", null },
                    { 2, "on Cleaning products", "COCOG730CNSG8ZVX", null },
                    { 3, "from Jan 27th to Feb 13th", "COCOG730CNSG8ZVX", null }
                });

            migrationBuilder.InsertData(
                table: "Voucher",
                columns: new[] { "Title", "IdStore" },
                values: new object[] { "COCOG730CNSG8ZVX", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ItemsVoucher",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ItemsVoucher",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ItemsVoucher",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Voucher",
                keyColumn: "Title",
                keyValue: "COCOG730CNSG8ZVX");
        }
    }
}
