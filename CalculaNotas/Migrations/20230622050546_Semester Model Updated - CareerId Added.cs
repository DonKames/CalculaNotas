using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalculaNotas.Migrations
{
    /// <inheritdoc />
    public partial class SemesterModelUpdatedCareerIdAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Semesters_Careers_CareerId",
                table: "Semesters");

            migrationBuilder.AlterColumn<int>(
                name: "CareerId",
                table: "Semesters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Semesters_Careers_CareerId",
                table: "Semesters",
                column: "CareerId",
                principalTable: "Careers",
                principalColumn: "CareerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Semesters_Careers_CareerId",
                table: "Semesters");

            migrationBuilder.AlterColumn<int>(
                name: "CareerId",
                table: "Semesters",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Semesters_Careers_CareerId",
                table: "Semesters",
                column: "CareerId",
                principalTable: "Careers",
                principalColumn: "CareerId");
        }
    }
}
