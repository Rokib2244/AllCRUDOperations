using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketBookingSystem2.Migrations.Training
{
    public partial class AddContctFieldInCustomerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "ContactNumber",
                table: "Customers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactNumber",
                table: "Customers");
        }
    }
}
