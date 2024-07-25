using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCECommerce.Migrations
{
    public partial class addedVariantName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Variant",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Variant");
        }
    }
}
