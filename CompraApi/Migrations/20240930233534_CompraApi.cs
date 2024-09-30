using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompraApi.Migrations
{
    /// <inheritdoc />
    public partial class CompraApi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Condicoes_Produtos_ProdutoId",
                table: "Condicoes");

            migrationBuilder.DropIndex(
                name: "IX_Condicoes_ProdutoId",
                table: "Condicoes");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "Condicoes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProdutoId",
                table: "Condicoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Condicoes_ProdutoId",
                table: "Condicoes",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Condicoes_Produtos_ProdutoId",
                table: "Condicoes",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
