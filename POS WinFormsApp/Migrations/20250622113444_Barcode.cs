using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POS_project.Migrations
{
    /// <inheritdoc />
    public partial class Barcode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalAmount",
                table: "Sales",
                newName: "total_price");

            migrationBuilder.RenameColumn(
                name: "SaleDate",
                table: "Sales",
                newName: "order_date");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "SaleItems",
                newName: "id");

            migrationBuilder.AddColumn<decimal>(
                name: "amount",
                table: "Sales",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "change",
                table: "Sales",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "customer_id",
                table: "Sales",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "category",
                table: "SaleItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "customer_id",
                table: "SaleItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "order_date",
                table: "SaleItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "barcode",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customer_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prod_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    total_price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    change = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    order_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropColumn(
                name: "amount",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "change",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "customer_id",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "category",
                table: "SaleItems");

            migrationBuilder.DropColumn(
                name: "customer_id",
                table: "SaleItems");

            migrationBuilder.DropColumn(
                name: "order_date",
                table: "SaleItems");

            migrationBuilder.DropColumn(
                name: "barcode",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "total_price",
                table: "Sales",
                newName: "TotalAmount");

            migrationBuilder.RenameColumn(
                name: "order_date",
                table: "Sales",
                newName: "SaleDate");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "SaleItems",
                newName: "Id");
        }
    }
}
