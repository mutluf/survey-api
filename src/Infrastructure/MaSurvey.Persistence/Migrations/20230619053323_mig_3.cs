using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaSurvey.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Surveys_AspNetUsers_CreatedById",
                table: "Surveys");

            migrationBuilder.RenameColumn(
                name: "CreatedById",
                table: "Surveys",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Surveys_CreatedById",
                table: "Surveys",
                newName: "IX_Surveys_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Surveys",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_Surveys_AspNetUsers_UserId",
                table: "Surveys",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Surveys_AspNetUsers_UserId",
                table: "Surveys");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Surveys",
                newName: "CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_Surveys_UserId",
                table: "Surveys",
                newName: "IX_Surveys_CreatedById");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Surveys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Surveys_AspNetUsers_CreatedById",
                table: "Surveys",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
