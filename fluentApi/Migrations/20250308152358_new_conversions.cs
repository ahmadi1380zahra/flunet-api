using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fluentApi.Migrations
{
    /// <inheritdoc />
    public partial class new_conversions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "MyUserFluents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NationalCode",
                table: "MyUserFluents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "MyUserFluents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "MyUserFluents");

            migrationBuilder.DropColumn(
                name: "NationalCode",
                table: "MyUserFluents");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "MyUserFluents");
        }
    }
}
