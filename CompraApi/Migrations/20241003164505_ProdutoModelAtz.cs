using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompraApi.Migrations
{
    /// <inheritdoc />
    public partial class ProdutoModelAtz : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuantidadeEmEstoque",
                table: "Produtos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuantidadeEmEstoque",
                table: "Produtos");
        }
    }
}
