using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaSurvey.Persistence.Migrations
{
    public partial class mig_6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnsweredOptions_AnsweredQuestions_AnsweredQuestionId",
                table: "AnsweredOptions");

            migrationBuilder.DropIndex(
                name: "IX_AnsweredOptions_AnsweredQuestionId",
                table: "AnsweredOptions");

            migrationBuilder.DropColumn(
                name: "VoteAmount",
                table: "Options");

            migrationBuilder.RenameColumn(
                name: "AnsweredQuestionId",
                table: "AnsweredOptions",
                newName: "VoteAmount");

            migrationBuilder.AddColumn<int>(
                name: "QuestionId",
                table: "AnsweredOptions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AnsweredOptions_QuestionId",
                table: "AnsweredOptions",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_AnsweredOptions_AnsweredQuestions_QuestionId",
                table: "AnsweredOptions",
                column: "QuestionId",
                principalTable: "AnsweredQuestions",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnsweredOptions_AnsweredQuestions_QuestionId",
                table: "AnsweredOptions");

            migrationBuilder.DropIndex(
                name: "IX_AnsweredOptions_QuestionId",
                table: "AnsweredOptions");

            migrationBuilder.DropColumn(
                name: "QuestionId",
                table: "AnsweredOptions");

            migrationBuilder.RenameColumn(
                name: "VoteAmount",
                table: "AnsweredOptions",
                newName: "AnsweredQuestionId");

            migrationBuilder.AddColumn<int>(
                name: "VoteAmount",
                table: "Options",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AnsweredOptions_AnsweredQuestionId",
                table: "AnsweredOptions",
                column: "AnsweredQuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_AnsweredOptions_AnsweredQuestions_AnsweredQuestionId",
                table: "AnsweredOptions",
                column: "AnsweredQuestionId",
                principalTable: "AnsweredQuestions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
