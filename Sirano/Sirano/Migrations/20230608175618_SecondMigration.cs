using Microsoft.EntityFrameworkCore.Migrations;

namespace Sirano.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clothing_Product_id",
                table: "Clothing");

            migrationBuilder.DropForeignKey(
                name: "FK_Footwear_Product_id",
                table: "Footwear");

            migrationBuilder.DropForeignKey(
                name: "FK_Store_Product_productID",
                table: "Store");

            migrationBuilder.RenameColumn(
                name: "productID",
                table: "Store",
                newName: "ProductID");

            migrationBuilder.RenameColumn(
                name: "city",
                table: "Store",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "Store",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Store",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Store_productID",
                table: "Store",
                newName: "IX_Store_ProductID");

            migrationBuilder.RenameColumn(
                name: "rating",
                table: "Review",
                newName: "Rating");

            migrationBuilder.RenameColumn(
                name: "comment",
                table: "Review",
                newName: "Comment");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Review",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "phoneNumber",
                table: "RegisteredUser",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "RegisteredUser",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "fullName",
                table: "RegisteredUser",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "RegisteredUser",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "RegisteredUser",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "summary",
                table: "Product",
                newName: "Summary");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Product",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Product",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "men",
                table: "Product",
                newName: "Men");

            migrationBuilder.RenameColumn(
                name: "image",
                table: "Product",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "colour",
                table: "Product",
                newName: "Colour");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Product",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Order",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "paymentMethod",
                table: "Order",
                newName: "PaymentMethod");

            migrationBuilder.RenameColumn(
                name: "orderDate",
                table: "Order",
                newName: "OrderDate");

            migrationBuilder.RenameColumn(
                name: "deliveryDate",
                table: "Order",
                newName: "DeliveryDate");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Order",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "category",
                table: "Footwear",
                newName: "Category");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Footwear",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "category",
                table: "Clothing",
                newName: "Category");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Clothing",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Clothing_Product_Id",
                table: "Clothing",
                column: "Id",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Footwear_Product_Id",
                table: "Footwear",
                column: "Id",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Store_Product_ProductID",
                table: "Store",
                column: "ProductID",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clothing_Product_Id",
                table: "Clothing");

            migrationBuilder.DropForeignKey(
                name: "FK_Footwear_Product_Id",
                table: "Footwear");

            migrationBuilder.DropForeignKey(
                name: "FK_Store_Product_ProductID",
                table: "Store");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "Store",
                newName: "productID");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Store",
                newName: "city");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Store",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Store",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Store_ProductID",
                table: "Store",
                newName: "IX_Store_productID");

            migrationBuilder.RenameColumn(
                name: "Rating",
                table: "Review",
                newName: "rating");

            migrationBuilder.RenameColumn(
                name: "Comment",
                table: "Review",
                newName: "comment");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Review",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "RegisteredUser",
                newName: "phoneNumber");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "RegisteredUser",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "RegisteredUser",
                newName: "fullName");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "RegisteredUser",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "RegisteredUser",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "Summary",
                table: "Product",
                newName: "summary");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Product",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Product",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Men",
                table: "Product",
                newName: "men");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Product",
                newName: "image");

            migrationBuilder.RenameColumn(
                name: "Colour",
                table: "Product",
                newName: "colour");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Product",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Order",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "PaymentMethod",
                table: "Order",
                newName: "paymentMethod");

            migrationBuilder.RenameColumn(
                name: "OrderDate",
                table: "Order",
                newName: "orderDate");

            migrationBuilder.RenameColumn(
                name: "DeliveryDate",
                table: "Order",
                newName: "deliveryDate");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Order",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "Footwear",
                newName: "category");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Footwear",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "Clothing",
                newName: "category");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Clothing",
                newName: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Clothing_Product_id",
                table: "Clothing",
                column: "id",
                principalTable: "Product",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Footwear_Product_id",
                table: "Footwear",
                column: "id",
                principalTable: "Product",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Store_Product_productID",
                table: "Store",
                column: "productID",
                principalTable: "Product",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
