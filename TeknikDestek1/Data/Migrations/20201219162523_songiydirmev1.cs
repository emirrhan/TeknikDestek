using Microsoft.EntityFrameworkCore.Migrations;

namespace TeknikDestek1.Data.Migrations
{
    public partial class songiydirmev1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "References",
                table: "Document",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "References",
                table: "Document");
        }
    }
}
