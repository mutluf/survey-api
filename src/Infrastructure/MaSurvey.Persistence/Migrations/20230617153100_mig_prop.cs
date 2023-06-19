using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaSurvey.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_prop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Surveys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "VoteAmount",
                table: "Options",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "Content",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "VoteAmount",
                table: "Options");
        }
    }
}
