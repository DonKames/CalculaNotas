using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalculaNotas.Migrations
{
    /// <inheritdoc />
    public partial class UserCareerrelationchanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Careers_CareerId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CareerId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CareerId",
                table: "Users");

            migrationBuilder.CreateTable(
                name: "UserCareers",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    CareerId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCareers", x => new { x.UserId, x.CareerId });
                    table.ForeignKey(
                        name: "FK_UserCareers_Careers_CareerId",
                        column: x => x.CareerId,
                        principalTable: "Careers",
                        principalColumn: "CareerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCareers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserCareers_CareerId",
                table: "UserCareers",
                column: "CareerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserCareers");

            migrationBuilder.AddColumn<int>(
                name: "CareerId",
                table: "Users",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_CareerId",
                table: "Users",
                column: "CareerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Careers_CareerId",
                table: "Users",
                column: "CareerId",
                principalTable: "Careers",
                principalColumn: "CareerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
