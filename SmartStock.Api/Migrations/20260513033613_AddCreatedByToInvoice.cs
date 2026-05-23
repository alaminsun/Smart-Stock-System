using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartStock.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddCreatedByToInvoice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Invoices",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Invoices");
        }
    }
}
