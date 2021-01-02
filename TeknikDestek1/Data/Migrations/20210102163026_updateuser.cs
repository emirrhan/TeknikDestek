using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TeknikDestek1.Data.Migrations
{
    public partial class updateuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DtimeUser",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastNameUser",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameUser",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DtimeUser",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastNameUser",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NameUser",
                table: "AspNetUsers");
        }
    }
}
