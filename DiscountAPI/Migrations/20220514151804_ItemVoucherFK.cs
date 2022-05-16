using Microsoft.EntityFrameworkCore.Migrations;

namespace DiscountAPI.Migrations
{
    public partial class ItemVoucherFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemsVoucher_Voucher_VoucherTitle",
                table: "ItemsVoucher");

            migrationBuilder.DropIndex(
                name: "IX_ItemsVoucher_VoucherTitle",
                table: "ItemsVoucher");

            migrationBuilder.DropColumn(
                name: "VoucherTitle",
                table: "ItemsVoucher");

            migrationBuilder.AlterColumn<string>(
                name: "TitleVoucher",
                table: "ItemsVoucher",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsVoucher_TitleVoucher",
                table: "ItemsVoucher",
                column: "TitleVoucher");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemsVoucher_Voucher_TitleVoucher",
                table: "ItemsVoucher",
                column: "TitleVoucher",
                principalTable: "Voucher",
                principalColumn: "Title",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemsVoucher_Voucher_TitleVoucher",
                table: "ItemsVoucher");

            migrationBuilder.DropIndex(
                name: "IX_ItemsVoucher_TitleVoucher",
                table: "ItemsVoucher");

            migrationBuilder.AlterColumn<string>(
                name: "TitleVoucher",
                table: "ItemsVoucher",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VoucherTitle",
                table: "ItemsVoucher",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemsVoucher_VoucherTitle",
                table: "ItemsVoucher",
                column: "VoucherTitle");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemsVoucher_Voucher_VoucherTitle",
                table: "ItemsVoucher",
                column: "VoucherTitle",
                principalTable: "Voucher",
                principalColumn: "Title",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
