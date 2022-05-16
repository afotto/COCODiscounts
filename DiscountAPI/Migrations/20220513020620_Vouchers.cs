using Microsoft.EntityFrameworkCore.Migrations;

namespace DiscountAPI.Migrations
{
    public partial class Vouchers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Voucher",
                columns: table => new
                {
                    Title = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdStore = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voucher", x => x.Title);
                });

            migrationBuilder.CreateTable(
                name: "ItemsVoucher",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleVoucher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Item = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoucherTitle = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsVoucher", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemsVoucher_Voucher_VoucherTitle",
                        column: x => x.VoucherTitle,
                        principalTable: "Voucher",
                        principalColumn: "Title",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemsVoucher_VoucherTitle",
                table: "ItemsVoucher",
                column: "VoucherTitle");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemsVoucher");

            migrationBuilder.DropTable(
                name: "Voucher");
        }
    }
}
