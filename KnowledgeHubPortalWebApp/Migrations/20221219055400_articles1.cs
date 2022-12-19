using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KnowledgeHubPortalWebApp.Migrations
{
    public partial class articles1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "URL",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "URL",
                table: "Articles");
        }
    }
}
