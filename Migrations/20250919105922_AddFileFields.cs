using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicStreamingAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddFileFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Album",
                table: "Tracks",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Tracks",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Duration",
                table: "Tracks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "Tracks",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FilePath",
                table: "Tracks",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "FileSize",
                table: "Tracks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Album",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "FileName",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "FilePath",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "FileSize",
                table: "Tracks");
        }
    }
}
