using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hakaton.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updatebaze : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeviceActions_Events_EventId",
                table: "DeviceActions");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "DeviceActions");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "DeviceActions");

            migrationBuilder.RenameColumn(
                name: "EventId",
                table: "DeviceActions",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_DeviceActions_EventId",
                table: "DeviceActions",
                newName: "IX_DeviceActions_UserId");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "DeviceActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                table: "DeviceActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceActions_Users_UserId",
                table: "DeviceActions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeviceActions_Users_UserId",
                table: "DeviceActions");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "DeviceActions");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "DeviceActions");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "DeviceActions",
                newName: "EventId");

            migrationBuilder.RenameIndex(
                name: "IX_DeviceActions_UserId",
                table: "DeviceActions",
                newName: "IX_DeviceActions_EventId");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "DeviceActions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "DeviceActions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_UserId",
                table: "Events",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceActions_Events_EventId",
                table: "DeviceActions",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
