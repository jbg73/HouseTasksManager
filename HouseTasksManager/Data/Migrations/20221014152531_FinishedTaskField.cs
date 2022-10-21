using Microsoft.EntityFrameworkCore.Migrations;

namespace HouseTasksManager.Data.Migrations
{
    public partial class FinishedTaskField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Finished",
                table: "HouseTask",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Finished",
                table: "HouseTask");
        }
    }
}
