using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace aula2.Migrations
{
    public partial class criandotabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "categoria");

            migrationBuilder.DropTable(
                name: "produto");

            migrationBuilder.CreateTable(
                name: "fraquesa",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    fraquesa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fraquesa", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "poder",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    poder = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_poder", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "fantasia",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Nome = table.Column<string>(nullable: true),
                    cor = table.Column<string>(nullable: true),
                    capa = table.Column<bool>(nullable: false),
                    poderid = table.Column<int>(nullable: true),
                    fraquesaid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fantasia", x => x.id);
                    table.ForeignKey(
                        name: "FK_fantasia_fraquesa_fraquesaid",
                        column: x => x.fraquesaid,
                        principalTable: "fraquesa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_fantasia_poder_poderid",
                        column: x => x.poderid,
                        principalTable: "poder",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "heroi",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nome = table.Column<string>(nullable: true),
                    poderid = table.Column<int>(nullable: true),
                    fraquesaid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_heroi", x => x.id);
                    table.ForeignKey(
                        name: "FK_heroi_fraquesa_fraquesaid",
                        column: x => x.fraquesaid,
                        principalTable: "fraquesa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_heroi_poder_poderid",
                        column: x => x.poderid,
                        principalTable: "poder",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_fantasia_fraquesaid",
                table: "fantasia",
                column: "fraquesaid");

            migrationBuilder.CreateIndex(
                name: "IX_fantasia_poderid",
                table: "fantasia",
                column: "poderid");

            migrationBuilder.CreateIndex(
                name: "IX_heroi_fraquesaid",
                table: "heroi",
                column: "fraquesaid");

            migrationBuilder.CreateIndex(
                name: "IX_heroi_poderid",
                table: "heroi",
                column: "poderid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "fantasia");

            migrationBuilder.DropTable(
                name: "heroi");

            migrationBuilder.DropTable(
                name: "fraquesa");

            migrationBuilder.DropTable(
                name: "poder");

            migrationBuilder.CreateTable(
                name: "categoria",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categoria", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "produto",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    descricao = table.Column<string>(nullable: true),
                    nome = table.Column<string>(nullable: true),
                    valor = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produto", x => x.id);
                });
        }
    }
}
