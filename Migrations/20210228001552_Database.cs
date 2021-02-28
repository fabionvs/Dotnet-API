using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace app.Migrations
{
    public partial class Database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_contrato",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataContrato = table.Column<DateTime>(nullable: false),
                    Parcelas = table.Column<int>(nullable: false),
                    ValorFinanciado = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_contrato", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_prestacao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataVencimento = table.Column<DateTime>(nullable: false),
                    DataPagamento = table.Column<DateTime>(nullable: true),
                    Valor = table.Column<decimal>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    ContratoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_prestacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_prestacao_tb_contrato_ContratoId",
                        column: x => x.ContratoId,
                        principalTable: "tb_contrato",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_prestacao_ContratoId",
                table: "tb_prestacao",
                column: "ContratoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_prestacao");

            migrationBuilder.DropTable(
                name: "tb_contrato");
        }
    }
}
