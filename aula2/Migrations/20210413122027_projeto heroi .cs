using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace aula2.Migrations
{
    public partial class projetoheroi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_fantasia_fraquesa_fraquesaid",
                table: "fantasia");

            migrationBuilder.DropForeignKey(
                name: "FK_heroi_fraquesa_fraquesaid",
                table: "heroi");

            migrationBuilder.DropForeignKey(
                name: "FK_heroi_poder_poderid",
                table: "heroi");

            migrationBuilder.DropTable(
                name: "fraquesa");

            migrationBuilder.RenameColumn(
                name: "poder",
                table: "poder",
                newName: "nome");

            migrationBuilder.AlterColumn<int>(
                name: "poderid",
                table: "heroi",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "fraquesaid",
                table: "heroi",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "fantasiaid",
                table: "heroi",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "fraqueza",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fraqueza", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_heroi_fantasiaid",
                table: "heroi",
                column: "fantasiaid");

            migrationBuilder.AddForeignKey(
                name: "FK_fantasia_fraqueza_fraquesaid",
                table: "fantasia",
                column: "fraquesaid",
                principalTable: "fraqueza",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_heroi_fantasia_fantasiaid",
                table: "heroi",
                column: "fantasiaid",
                principalTable: "fantasia",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_heroi_fraqueza_fraquesaid",
                table: "heroi",
                column: "fraquesaid",
                principalTable: "fraqueza",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_heroi_poder_poderid",
                table: "heroi",
                column: "poderid",
                principalTable: "poder",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_fantasia_fraqueza_fraquesaid",
                table: "fantasia");

            migrationBuilder.DropForeignKey(
                name: "FK_heroi_fantasia_fantasiaid",
                table: "heroi");

            migrationBuilder.DropForeignKey(
                name: "FK_heroi_fraqueza_fraquesaid",
                table: "heroi");

            migrationBuilder.DropForeignKey(
                name: "FK_heroi_poder_poderid",
                table: "heroi");

            migrationBuilder.DropTable(
                name: "fraqueza");

            migrationBuilder.DropIndex(
                name: "IX_heroi_fantasiaid",
                table: "heroi");

            migrationBuilder.DropColumn(
                name: "fantasiaid",
                table: "heroi");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "poder",
                newName: "poder");

            migrationBuilder.AlterColumn<int>(
                name: "poderid",
                table: "heroi",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "fraquesaid",
                table: "heroi",
                nullable: true,
                oldClrType: typeof(int));

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

            migrationBuilder.AddForeignKey(
                name: "FK_fantasia_fraquesa_fraquesaid",
                table: "fantasia",
                column: "fraquesaid",
                principalTable: "fraquesa",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_heroi_fraquesa_fraquesaid",
                table: "heroi",
                column: "fraquesaid",
                principalTable: "fraquesa",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_heroi_poder_poderid",
                table: "heroi",
                column: "poderid",
                principalTable: "poder",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
