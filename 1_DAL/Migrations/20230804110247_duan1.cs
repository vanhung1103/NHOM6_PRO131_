using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1_DAL.Migrations
{
    public partial class duan1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductName",
                table: "Bill",
                newName: "product name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Bill",
                newName: "Des");

            migrationBuilder.AddColumn<string>(
                name: "MaSp",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Mahdct",
                table: "BillDetail",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "product name",
                table: "Bill",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Des",
                table: "Bill",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "MaHD",
                table: "Bill",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaSp",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Mahdct",
                table: "BillDetail");

            migrationBuilder.DropColumn(
                name: "MaHD",
                table: "Bill");

            migrationBuilder.RenameColumn(
                name: "product name",
                table: "Bill",
                newName: "ProductName");

            migrationBuilder.RenameColumn(
                name: "Des",
                table: "Bill",
                newName: "Description");

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Bill",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Bill",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");
        }
    }
}
