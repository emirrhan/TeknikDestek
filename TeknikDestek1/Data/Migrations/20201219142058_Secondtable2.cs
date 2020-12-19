using Microsoft.EntityFrameworkCore.Migrations;

namespace TeknikDestek1.Data.Migrations
{
    public partial class Secondtable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Document_Category_CategoryId",
                table: "Document");

            migrationBuilder.AddColumn<string>(
                name: "Authority",
                table: "Writer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "References",
                table: "Writer",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Document",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "DocumentInfo",
                table: "Document",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Document_Category_CategoryId",
                table: "Document",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Document_Category_CategoryId",
                table: "Document");

            migrationBuilder.DropColumn(
                name: "Authority",
                table: "Writer");

            migrationBuilder.DropColumn(
                name: "References",
                table: "Writer");

            migrationBuilder.DropColumn(
                name: "DocumentInfo",
                table: "Document");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Document",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Document_Category_CategoryId",
                table: "Document",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
