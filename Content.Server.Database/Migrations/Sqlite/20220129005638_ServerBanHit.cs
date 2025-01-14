// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Content.Server.Database.Migrations.Sqlite
{
    public partial class ServerBanHit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "denied",
                table: "connection_log",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "server_ban_hit",
                columns: table => new
                {
                    server_ban_hit_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ban_id = table.Column<int>(type: "INTEGER", nullable: false),
                    connection_id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_server_ban_hit", x => x.server_ban_hit_id);
                    table.ForeignKey(
                        name: "FK_server_ban_hit_connection_log_connection_id",
                        column: x => x.connection_id,
                        principalTable: "connection_log",
                        principalColumn: "connection_log_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_server_ban_hit_server_ban_ban_id",
                        column: x => x.ban_id,
                        principalTable: "server_ban",
                        principalColumn: "server_ban_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_server_ban_hit_ban_id",
                table: "server_ban_hit",
                column: "ban_id");

            migrationBuilder.CreateIndex(
                name: "IX_server_ban_hit_connection_id",
                table: "server_ban_hit",
                column: "connection_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "server_ban_hit");

            migrationBuilder.DropColumn(
                name: "denied",
                table: "connection_log");
        }
    }
}
