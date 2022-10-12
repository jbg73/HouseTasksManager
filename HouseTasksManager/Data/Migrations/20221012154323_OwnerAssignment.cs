using Microsoft.EntityFrameworkCore.Migrations;

namespace HouseTasksManager.Data.Migrations
{
    public partial class OwnerAssignment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Assigned",
                table: "HouseTask",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Owner",
                table: "HouseTask",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Assigned",
                table: "HouseTask");

            migrationBuilder.DropColumn(
                name: "Owner",
                table: "HouseTask");
        }
    }
}
