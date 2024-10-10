using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FieldGroove.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addofficeaddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "RegisterDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "RegisterDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StreetAddress1",
                table: "RegisterDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StreetAddress2",
                table: "RegisterDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Zip",
                table: "RegisterDetails",
                type: "bigint",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "RegisterDetails");

            migrationBuilder.DropColumn(
                name: "State",
                table: "RegisterDetails");

            migrationBuilder.DropColumn(
                name: "StreetAddress1",
                table: "RegisterDetails");

            migrationBuilder.DropColumn(
                name: "StreetAddress2",
                table: "RegisterDetails");

            migrationBuilder.DropColumn(
                name: "Zip",
                table: "RegisterDetails");
        }
    }
}
