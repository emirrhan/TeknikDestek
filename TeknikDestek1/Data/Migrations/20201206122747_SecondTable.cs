using Microsoft.EntityFrameworkCore.Migrations;

namespace TeknikDestek1.Data.Migrations
{
    public partial class SecondTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WriterId",
                table: "Document",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Writer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Cinsiyet = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Writer", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Document_WriterId",
                table: "Document",
                column: "WriterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Document_Writer_WriterId",
                table: "Document",
                column: "WriterId",
                principalTable: "Writer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Document_Writer_WriterId",
                table: "Document");

            migrationBuilder.DropTable(
                name: "Writer");

            migrationBuilder.DropIndex(
                name: "IX_Document_WriterId",
                table: "Document");

            migrationBuilder.DropColumn(
                name: "WriterId",
                table: "Document");
        }
    }
}
