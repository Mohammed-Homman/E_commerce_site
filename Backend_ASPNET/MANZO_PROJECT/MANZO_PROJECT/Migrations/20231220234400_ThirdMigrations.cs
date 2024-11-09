using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MANZO_PROJECT.Migrations
{
    /// <inheritdoc />
    public partial class ThirdMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_User_UserId",
                table: "Product");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cover",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeliveryTime",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Desc",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Features",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Images",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Product",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "ProductId1",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RevisionNumber",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Sales",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ShortDesc",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ShortTitle",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Product",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Order",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductId1",
                table: "Product",
                column: "ProductId1");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ProductId",
                table: "Order",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Product_ProductId",
                table: "Order",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Product_ProductId1",
                table: "Product",
                column: "ProductId1",
                principalTable: "Product",
                principalColumn: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_User_UserId",
                table: "Product",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Product_ProductId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Product_ProductId1",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_User_UserId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_ProductId1",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Order_ProductId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Cover",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "DeliveryTime",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Desc",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Features",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Images",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ProductId1",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "RevisionNumber",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Sales",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ShortDesc",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ShortTitle",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Order");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Product",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_User_UserId",
                table: "Product",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId");
        }
    }
}
