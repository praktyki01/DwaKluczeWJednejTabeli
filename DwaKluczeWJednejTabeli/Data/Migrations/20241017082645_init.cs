using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DwaKluczeWJednejTabeli.Data.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Druzyna",
                columns: table => new
                {
                    DruzynaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RokZalozenia = table.Column<int>(type: "int", nullable: false),
                    Miasto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trener = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Druzyna", x => x.DruzynaId);
                });

            migrationBuilder.CreateTable(
                name: "Mecz",
                columns: table => new
                {
                    MeczId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GoscieDruzynaId = table.Column<int>(type: "int", nullable: false),
                    GospodarzeDruzynaId = table.Column<int>(type: "int", nullable: false),
                    Wynik = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mecz", x => x.MeczId);
                    table.ForeignKey(
                        name: "FK_Mecz_Druzyna_GoscieDruzynaId",
                        column: x => x.GoscieDruzynaId,
                        principalTable: "Druzyna",
                        principalColumn: "DruzynaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mecz_Druzyna_GospodarzeDruzynaId",
                        column: x => x.GospodarzeDruzynaId,
                        principalTable: "Druzyna",
                        principalColumn: "DruzynaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sedzia",
                columns: table => new
                {
                    SedziaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WystawioneZolteKartki = table.Column<int>(type: "int", nullable: false),
                    DruzynaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sedzia", x => x.SedziaId);
                    table.ForeignKey(
                        name: "FK_Sedzia_Druzyna_DruzynaId",
                        column: x => x.DruzynaId,
                        principalTable: "Druzyna",
                        principalColumn: "DruzynaId");
                });

            migrationBuilder.CreateTable(
                name: "Sponsor",
                columns: table => new
                {
                    SponsorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kwota = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DruzynaId = table.Column<int>(type: "int", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sponsor", x => x.SponsorId);
                    table.ForeignKey(
                        name: "FK_Sponsor_Druzyna_DruzynaId",
                        column: x => x.DruzynaId,
                        principalTable: "Druzyna",
                        principalColumn: "DruzynaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tabela",
                columns: table => new
                {
                    TabelaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DruzynaId = table.Column<int>(type: "int", nullable: false),
                    RozegraneMecze = table.Column<int>(type: "int", nullable: false),
                    Punkty = table.Column<int>(type: "int", nullable: false),
                    StrzeloneBramki = table.Column<int>(type: "int", nullable: false),
                    StraconeBramki = table.Column<int>(type: "int", nullable: false),
                    Zwyciestwa = table.Column<int>(type: "int", nullable: false),
                    Remisy = table.Column<int>(type: "int", nullable: false),
                    Porazki = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabela", x => x.TabelaId);
                    table.ForeignKey(
                        name: "FK_Tabela_Druzyna_DruzynaId",
                        column: x => x.DruzynaId,
                        principalTable: "Druzyna",
                        principalColumn: "DruzynaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Zawodnik",
                columns: table => new
                {
                    ZawodnikId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataUrodzenia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Pozycja = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DruzynaId = table.Column<int>(type: "int", nullable: false),
                    Kraj = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zawodnik", x => x.ZawodnikId);
                    table.ForeignKey(
                        name: "FK_Zawodnik_Druzyna_DruzynaId",
                        column: x => x.DruzynaId,
                        principalTable: "Druzyna",
                        principalColumn: "DruzynaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MeczSedzia",
                columns: table => new
                {
                    MeczId = table.Column<int>(type: "int", nullable: false),
                    SedziasSedziaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeczSedzia", x => new { x.MeczId, x.SedziasSedziaId });
                    table.ForeignKey(
                        name: "FK_MeczSedzia_Mecz_MeczId",
                        column: x => x.MeczId,
                        principalTable: "Mecz",
                        principalColumn: "MeczId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MeczSedzia_Sedzia_SedziasSedziaId",
                        column: x => x.SedziasSedziaId,
                        principalTable: "Sedzia",
                        principalColumn: "SedziaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Statystyki",
                columns: table => new
                {
                    StatystykiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ZawodnikId = table.Column<int>(type: "int", nullable: false),
                    MeczId = table.Column<int>(type: "int", nullable: false),
                    Gole = table.Column<int>(type: "int", nullable: false),
                    Asysty = table.Column<int>(type: "int", nullable: false),
                    ZolteKartki = table.Column<int>(type: "int", nullable: false),
                    CzerwoneKartki = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statystyki", x => x.StatystykiId);
                    table.ForeignKey(
                        name: "FK_Statystyki_Mecz_MeczId",
                        column: x => x.MeczId,
                        principalTable: "Mecz",
                        principalColumn: "MeczId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Statystyki_Zawodnik_ZawodnikId",
                        column: x => x.ZawodnikId,
                        principalTable: "Zawodnik",
                        principalColumn: "ZawodnikId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mecz_GoscieDruzynaId",
                table: "Mecz",
                column: "GoscieDruzynaId");

            migrationBuilder.CreateIndex(
                name: "IX_Mecz_GospodarzeDruzynaId",
                table: "Mecz",
                column: "GospodarzeDruzynaId");

            migrationBuilder.CreateIndex(
                name: "IX_MeczSedzia_SedziasSedziaId",
                table: "MeczSedzia",
                column: "SedziasSedziaId");

            migrationBuilder.CreateIndex(
                name: "IX_Sedzia_DruzynaId",
                table: "Sedzia",
                column: "DruzynaId");

            migrationBuilder.CreateIndex(
                name: "IX_Sponsor_DruzynaId",
                table: "Sponsor",
                column: "DruzynaId");

            migrationBuilder.CreateIndex(
                name: "IX_Statystyki_MeczId",
                table: "Statystyki",
                column: "MeczId");

            migrationBuilder.CreateIndex(
                name: "IX_Statystyki_ZawodnikId",
                table: "Statystyki",
                column: "ZawodnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Tabela_DruzynaId",
                table: "Tabela",
                column: "DruzynaId");

            migrationBuilder.CreateIndex(
                name: "IX_Zawodnik_DruzynaId",
                table: "Zawodnik",
                column: "DruzynaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MeczSedzia");

            migrationBuilder.DropTable(
                name: "Sponsor");

            migrationBuilder.DropTable(
                name: "Statystyki");

            migrationBuilder.DropTable(
                name: "Tabela");

            migrationBuilder.DropTable(
                name: "Sedzia");

            migrationBuilder.DropTable(
                name: "Mecz");

            migrationBuilder.DropTable(
                name: "Zawodnik");

            migrationBuilder.DropTable(
                name: "Druzyna");
        }
    }
}
