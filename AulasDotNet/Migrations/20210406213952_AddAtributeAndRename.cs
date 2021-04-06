using Microsoft.EntityFrameworkCore.Migrations;

namespace AulasDotNet.Migrations
{
    public partial class AddAtributeAndRename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "_nomeMae",
                table: "pessoa",
                newName: "nomeMae");

            migrationBuilder.RenameColumn(
                name: "_nome",
                table: "pessoa",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "_dtNascimento",
                table: "pessoa",
                newName: "dtNascimento");

            migrationBuilder.RenameColumn(
                name: "_id",
                table: "pessoa",
                newName: "id");

            migrationBuilder.AddColumn<string>(
                name: "endereco",
                table: "pessoa",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "endereco",
                table: "pessoa");

            migrationBuilder.RenameColumn(
                name: "nomeMae",
                table: "pessoa",
                newName: "_nomeMae");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "pessoa",
                newName: "_nome");

            migrationBuilder.RenameColumn(
                name: "dtNascimento",
                table: "pessoa",
                newName: "_dtNascimento");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "pessoa",
                newName: "_id");
        }
    }
}
