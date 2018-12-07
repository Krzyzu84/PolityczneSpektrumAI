using Microsoft.EntityFrameworkCore.Migrations;

namespace PolityczneSpektrum.Migrations
{
    public partial class newquestion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthoritarianScore",
                table: "Questions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LeftScore",
                table: "Questions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LibertarianScore",
                table: "Questions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RightScore",
                table: "Questions",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthoritarianScore",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "LeftScore",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "LibertarianScore",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "RightScore",
                table: "Questions");
        }
    }
}
