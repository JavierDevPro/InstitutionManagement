using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Institution.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AlterInscription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateCreation",
                table: "Inscriptions",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<DateOnly>(
                name: "DateUpdate",
                table: "Inscriptions",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreation",
                table: "Inscriptions");

            migrationBuilder.DropColumn(
                name: "DateUpdate",
                table: "Inscriptions");
        }
    }
}
