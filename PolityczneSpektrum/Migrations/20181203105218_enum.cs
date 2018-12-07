using Microsoft.EntityFrameworkCore.Migrations;

namespace PolityczneSpektrum.Migrations
{
    public partial class @enum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "Answer",
                table: "Questions",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Answer",
                table: "Questions");

            migrationBuilder.AddColumn<bool>(
                name: "AuthoritarianScore",
                table: "Questions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LeftScore",
                table: "Questions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LibertarianScore",
                table: "Questions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "RightScore",
                table: "Questions",
                nullable: false,
                defaultValue: false);
        }
    }
}
