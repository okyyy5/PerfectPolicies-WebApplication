using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ICTPRG532OktayTurdu.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quizzes",
                columns: table => new
                {
                    QuizID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuizTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuizTopic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuizAuthor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuizDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    QuizPass = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quizzes", x => x.QuizID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserInfoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserInfoId);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionTopic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuizID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionID);
                    table.ForeignKey(
                        name: "FK_Questions_Quizzes_QuizID",
                        column: x => x.QuizID,
                        principalTable: "Quizzes",
                        principalColumn: "QuizID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Options",
                columns: table => new
                {
                    OptionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OptionText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OptionLetter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false),
                    QuestionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Options", x => x.OptionID);
                    table.ForeignKey(
                        name: "FK_Options_Questions_QuestionID",
                        column: x => x.QuestionID,
                        principalTable: "Questions",
                        principalColumn: "QuestionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Quizzes",
                columns: new[] { "QuizID", "QuizAuthor", "QuizDate", "QuizPass", "QuizTitle", "QuizTopic" },
                values: new object[] { 1, "Perfect Policies", new DateTime(2022, 6, 1, 19, 40, 28, 259, DateTimeKind.Local).AddTicks(4117), 100, "Sample Quiz", "General" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionID", "QuestionImage", "QuestionText", "QuestionTopic", "QuizID" },
                values: new object[] { 1, "No Image", "With our organisation's copyright material:", "Internal Copyright Materials", 1 });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionID", "QuestionImage", "QuestionText", "QuestionTopic", "QuizID" },
                values: new object[] { 2, "No Image", "When looking to work in a confined space, I need to review:", "Confined Space Work", 1 });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionID", "QuestionImage", "QuestionText", "QuestionTopic", "QuizID" },
                values: new object[] { 3, "No Image", "With Commercial in Confidence Client Details, we are required to:", "Client Details", 1 });

            migrationBuilder.InsertData(
                table: "Options",
                columns: new[] { "OptionID", "IsCorrect", "OptionLetter", "OptionText", "QuestionID" },
                values: new object[,]
                {
                    { 1, false, "1", "Obfuscate it so as to make it difficult to interpret", 1 },
                    { 2, false, "2", "Restrict viewing to only admin staff", 1 },
                    { 3, false, "3", "Only store in hard copy in a locked filing cabinet", 1 },
                    { 4, true, "4", "Store such materials only on our secured network", 1 },
                    { 5, false, "5", "Forward to other developers via email", 1 },
                    { 6, false, "1", "Our company's SOP - Working at Heights", 2 },
                    { 7, false, "2", "Our company's SOP - Vehicle Parking", 2 },
                    { 8, false, "3", "Our Chemical Safety Data Sheets", 2 },
                    { 9, false, "4", "Our Company's Copyright Policy", 2 },
                    { 10, true, "5", "Our company's SOP - Working in a Confined Space", 2 },
                    { 11, true, "1", "Store such details only on our secured network", 3 },
                    { 12, false, "2", "Only store in hard copy in a locked filing cabinet", 3 },
                    { 13, false, "3", "Obfuscate it so as to make it difficult to interpret", 3 },
                    { 14, false, "4", "Can only be viewed by admin staff", 3 },
                    { 15, false, "5", "Can be left unsecured", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Options_QuestionID",
                table: "Options",
                column: "QuestionID");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuizID",
                table: "Questions",
                column: "QuizID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Options");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Quizzes");
        }
    }
}
