using Microsoft.EntityFrameworkCore.Migrations;

namespace blazor2.Data.Migrations
{
    public partial class remove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "pages",
                table: "книги");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "pages",
                table: "книги",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
