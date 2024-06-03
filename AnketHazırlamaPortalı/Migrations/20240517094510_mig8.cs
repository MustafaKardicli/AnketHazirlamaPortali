using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnketHazırlamaPortalı.Migrations
{
    /// <inheritdoc />
    public partial class mig8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Surveys",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatorUserId",
                table: "Surveys",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Surveys_AppUserId",
                table: "Surveys",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Surveys_AspNetUsers_AppUserId",
                table: "Surveys",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Surveys_AspNetUsers_AppUserId",
                table: "Surveys");

            migrationBuilder.DropIndex(
                name: "IX_Surveys_AppUserId",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Surveys");
        }
    }
}
