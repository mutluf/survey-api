using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaSurvey.Persistence.Migrations
{
    public partial class mig_8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VoteAmount",
                table: "AnsweredOptions");

            migrationBuilder.AddColumn<int>(
                name: "VoteAmount",
                table: "Options",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VoteAmount",
                table: "Options");

            migrationBuilder.AddColumn<int>(
                name: "VoteAmount",
                table: "AnsweredOptions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
