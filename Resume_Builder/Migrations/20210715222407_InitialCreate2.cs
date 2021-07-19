using Microsoft.EntityFrameworkCore.Migrations;

namespace Resume_Builder.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "Resumes",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Resumes",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Resumes",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Degree",
                table: "Resumes",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Resumes",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Indexx",
                table: "Resumes",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Job",
                table: "Resumes",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Resumes",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Study",
                table: "Resumes",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudyTimeFrom",
                table: "Resumes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudyTimeTo",
                table: "Resumes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Resumes",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Resumes",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "University",
                table: "Resumes",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WorkTimeFrom",
                table: "Resumes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WorkTimeTo",
                table: "Resumes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adress",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Degree",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Indexx",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Job",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Study",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "StudyTimeFrom",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "StudyTimeTo",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "University",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "WorkTimeFrom",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "WorkTimeTo",
                table: "Resumes");
        }
    }
}
