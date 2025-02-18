using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ELearning.Data.Migrations
{
    /// <inheritdoc />
    public partial class V3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Enrollments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "Duration",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "643a58d8-1eb1-4bd8-9269-1bded40bb892", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "User", "johndoe@example.com", false, false, null, "John Doe", null, null, null, null, false, "secure_stamp_1", false, "johndoe@example.com" },
                    { "2", 0, "2670d463-b877-4e4f-8612-b3a9474edb2f", new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "User", "janesmith@example.com", false, false, null, "Jane Smith", null, null, null, null, false, "secure_stamp_2", false, "janesmith@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CreatedAt", "Description", "Duration", "InstructorId", "Price", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description for Course 1", 0, "1", 150m, "Course 1", null },
                    { 2, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description for Course 2", 0, "2", 250m, "Course 2", null }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "Id", "CourseId", "EnrolledAt", "Status", "StudentId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1" },
                    { 2, 2, new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "2" }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Amount", "CourseId", "PaymentDate", "Status", "StudentId" },
                values: new object[,]
                {
                    { 1, 100m, 1, new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "don", "1" },
                    { 2, 200m, 2, new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "don", "2" }
                });

            migrationBuilder.InsertData(
                table: "Quizzes",
                columns: new[] { "Id", "CourseId", "CreatedAt", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "good" },
                    { 2, 2, new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "notgood" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "CourseId", "Rating", "StudentId" },
                values: new object[,]
                {
                    { 1, "Great course!", 1, 5, "1" },
                    { 2, "Good course, but could be better.", 2, 4, "2" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "QuestionText", "QuestionType", "QuizId" },
                values: new object[,]
                {
                    { 1, "what is your name", "chose", 1 },
                    { 2, "what is your country name ", "chose", 2 }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "AnswerText", "IsCorrect", "QuestionId", "StudentId" },
                values: new object[,]
                {
                    { 1, "Answer 1", true, 1, "1" },
                    { 2, "Answer 2", true, 2, "2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Courses");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Enrollments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}
