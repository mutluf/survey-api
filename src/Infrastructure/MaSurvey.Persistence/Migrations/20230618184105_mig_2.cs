using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaSurvey.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Questions",
                newName: "QuestionContent");

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "Surveys",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                table: "Surveys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Surveys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "Surveys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SolvedCount",
                table: "Surveys",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "QuestionRate",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                table: "Options",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "OptionContent",
                table: "Options",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Surveys_CreatedById",
                table: "Surveys",
                column: "CreatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Surveys_AspNetUsers_CreatedById",
                table: "Surveys",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Surveys_AspNetUsers_CreatedById",
                table: "Surveys");

            migrationBuilder.DropIndex(
                name: "IX_Surveys_CreatedById",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "Link",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "SolvedCount",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "QuestionRate",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                table: "Options");

            migrationBuilder.DropColumn(
                name: "OptionContent",
                table: "Options");

            migrationBuilder.RenameColumn(
                name: "QuestionContent",
                table: "Questions",
                newName: "Content");
        }
    }
}
