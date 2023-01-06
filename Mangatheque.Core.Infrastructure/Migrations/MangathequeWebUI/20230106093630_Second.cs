using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mangatheque.Core.Infrastructure.Migrations.MangathequeWebUI
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manga",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Auteur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatePublication = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Couverture = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    stockId = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MangathequeWebUIUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manga", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Manga_AspNetUsers_MangathequeWebUIUserId",
                        column: x => x.MangathequeWebUIUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Manga_Stock_stockId",
                        column: x => x.stockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Manga_MangathequeWebUIUserId",
                table: "Manga",
                column: "MangathequeWebUIUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Manga_stockId",
                table: "Manga",
                column: "stockId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Manga");

            migrationBuilder.DropTable(
                name: "Stock");
        }
    }
}
