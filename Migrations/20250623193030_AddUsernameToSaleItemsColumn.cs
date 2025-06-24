using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POS_project.Migrations
{
    /// <inheritdoc />
    public partial class AddUsernameToSaleItemsColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "SaleItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Username",
                table: "SaleItems");
        }
    }
}
