using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccesoDatos.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cereales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    HumedadMaxima = table.Column<double>(type: "REAL", nullable: false),
                    Activo = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cereales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Cuit = table.Column<string>(type: "TEXT", nullable: true),
                    Telefono = table.Column<string>(type: "TEXT", nullable: true),
                    Localidad = table.Column<string>(type: "TEXT", nullable: true),
                    Activo = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Productores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Cuit = table.Column<string>(type: "TEXT", nullable: true),
                    Telefono = table.Column<string>(type: "TEXT", nullable: true),
                    Localidad = table.Column<string>(type: "TEXT", nullable: true),
                    Activo = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Despachos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: false),
                    CerealId = table.Column<int>(type: "INTEGER", nullable: false),
                    Patente = table.Column<string>(type: "TEXT", nullable: true),
                    KilosBrutos = table.Column<int>(type: "INTEGER", nullable: false),
                    Tara = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Despachos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Despachos_Cereales_CerealId",
                        column: x => x.CerealId,
                        principalTable: "Cereales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Despachos_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Descargas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ProductorId = table.Column<int>(type: "INTEGER", nullable: false),
                    CerealId = table.Column<int>(type: "INTEGER", nullable: false),
                    Patente = table.Column<string>(type: "TEXT", nullable: true),
                    KilosBrutos = table.Column<int>(type: "INTEGER", nullable: false),
                    Tara = table.Column<int>(type: "INTEGER", nullable: false),
                    Humedad = table.Column<double>(type: "REAL", nullable: false),
                    Estado = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Descargas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Descargas_Cereales_CerealId",
                        column: x => x.CerealId,
                        principalTable: "Cereales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Descargas_Productores_ProductorId",
                        column: x => x.ProductorId,
                        principalTable: "Productores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Descargas_CerealId",
                table: "Descargas",
                column: "CerealId");

            migrationBuilder.CreateIndex(
                name: "IX_Descargas_ProductorId",
                table: "Descargas",
                column: "ProductorId");

            migrationBuilder.CreateIndex(
                name: "IX_Despachos_CerealId",
                table: "Despachos",
                column: "CerealId");

            migrationBuilder.CreateIndex(
                name: "IX_Despachos_ClienteId",
                table: "Despachos",
                column: "ClienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Descargas");

            migrationBuilder.DropTable(
                name: "Despachos");

            migrationBuilder.DropTable(
                name: "Productores");

            migrationBuilder.DropTable(
                name: "Cereales");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
