﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fluentApi.Migrations
{
    /// <inheritdoc />
    public partial class conversion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "MyUserFluents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "MyUserFluents");
        }
    }
}
