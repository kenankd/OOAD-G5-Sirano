using Microsoft.EntityFrameworkCore.Migrations;

namespace Sirano.Data.Migrations
{
    public partial class LastMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CVV",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CardNumber",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cardholder",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExpirationMonth",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExpirationYear",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CVV",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "CardNumber",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Cardholder",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "ExpirationMonth",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "ExpirationYear",
                table: "Order");
        }
    }
}
