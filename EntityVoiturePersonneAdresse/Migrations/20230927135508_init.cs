using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityVoiturePersonneAdresse.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "adresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rue = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CP = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_adresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "personnes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AdresseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personnes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_personnes_adresses_AdresseId",
                        column: x => x.AdresseId,
                        principalTable: "adresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "voitures",
                columns: table => new
                {
                    Frame = table.Column<string>(type: "nvarchar(17)", maxLength: 17, nullable: false),
                    Plate = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_voitures", x => x.Frame);
                    table.ForeignKey(
                        name: "FK_voitures_personnes_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "personnes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_personnes_AdresseId",
                table: "personnes",
                column: "AdresseId");

            migrationBuilder.CreateIndex(
                name: "IX_personnes_Email",
                table: "personnes",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_voitures_OwnerId",
                table: "voitures",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_voitures_Plate",
                table: "voitures",
                column: "Plate",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "voitures");

            migrationBuilder.DropTable(
                name: "personnes");

            migrationBuilder.DropTable(
                name: "adresses");
        }
    }
}
