using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaSurvey.Persistence.Migrations
{
    public partial class mig_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Votes_Responses_ResponseId",
                table: "Votes");

            migrationBuilder.DropIndex(
                name: "IX_Votes_ResponseId",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "ResponseId",
                table: "Votes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ResponseId",
                table: "Votes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Votes_ResponseId",
                table: "Votes",
                column: "ResponseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Votes_Responses_ResponseId",
                table: "Votes",
                column: "ResponseId",
                principalTable: "Responses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
