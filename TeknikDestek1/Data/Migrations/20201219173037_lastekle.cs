using Microsoft.EntityFrameworkCore.Migrations;

namespace TeknikDestek1.Data.Migrations
{
    public partial class lastekle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "References",
                table: "Writer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "References",
                table: "Writer",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
