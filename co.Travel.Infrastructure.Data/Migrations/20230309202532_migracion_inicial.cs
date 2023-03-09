using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace co.Travel.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class migracion_inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombres = table.Column<string>(type: "varchar(45)", unicode: false, maxLength: 45, nullable: true),
                    Apellidos = table.Column<string>(type: "varchar(45)", unicode: false, maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Editoriales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sede = table.Column<string>(type: "varchar(45)", unicode: false, maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editorial", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Libros",
                columns: table => new
                {
                    ISBN = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Editores_id = table.Column<int>(type: "int", nullable: false),
                    Titulo = table.Column<string>(type: "varchar(45)", unicode: false, maxLength: 45, nullable: true),
                    sinopsis = table.Column<string>(type: "text", nullable: true),
                    n_paginas = table.Column<string>(type: "varchar(45)", unicode: false, maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libros", x => x.ISBN);
                    table.ForeignKey(
                        name: "FK_Libros_Editores",
                        column: x => x.Editores_id,
                        principalTable: "Editoriales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AutoresLibros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AutoresId = table.Column<int>(type: "int", nullable: true),
                    LibrosIsbn = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoresLibro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AutoresLibro_autor",
                        column: x => x.AutoresId,
                        principalTable: "Autores",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AutoresLibro_libro",
                        column: x => x.LibrosIsbn,
                        principalTable: "Libros",
                        principalColumn: "ISBN");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AutoresLibros_AutoresId",
                table: "AutoresLibros",
                column: "AutoresId");

            migrationBuilder.CreateIndex(
                name: "IX_AutoresLibros_LibrosIsbn",
                table: "AutoresLibros",
                column: "LibrosIsbn");

            migrationBuilder.CreateIndex(
                name: "IX_Libros_Editores_id",
                table: "Libros",
                column: "Editores_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutoresLibros");

            migrationBuilder.DropTable(
                name: "Autores");

            migrationBuilder.DropTable(
                name: "Libros");

            migrationBuilder.DropTable(
                name: "Editoriales");
        }
    }
}
