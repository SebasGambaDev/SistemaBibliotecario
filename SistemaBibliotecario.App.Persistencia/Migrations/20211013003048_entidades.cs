using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaBibliotecario.App.Persistencia.Migrations
{
    public partial class entidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    aut_nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Bibliotecarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bib_identificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bib_nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bib_apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bib_email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bib_telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bib_turnBib = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bibliotecarios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Editoriales",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    edit_nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editoriales", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usu_identificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    usu_nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    usu_apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    usu_direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    usu_email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    usu_telefono = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Libros",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lib_titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lib_isbn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lib_sinopsis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lib_numCapt = table.Column<int>(type: "int", nullable: false),
                    lib_numPag = table.Column<int>(type: "int", nullable: false),
                    lib_fechaPub = table.Column<DateTime>(type: "datetime2", nullable: false),
                    lib_tipoLibro = table.Column<int>(type: "int", nullable: false),
                    lib_catLibro = table.Column<int>(type: "int", nullable: false),
                    lib_idioLibro = table.Column<int>(type: "int", nullable: false),
                    lib_editid = table.Column<int>(type: "int", nullable: true),
                    lib_autid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libros", x => x.id);
                    table.ForeignKey(
                        name: "FK_Libros_Autores_lib_autid",
                        column: x => x.lib_autid,
                        principalTable: "Autores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Libros_Editoriales_lib_editid",
                        column: x => x.lib_editid,
                        principalTable: "Editoriales",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ejemplares",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ejem_scdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ejem_libid = table.Column<int>(type: "int", nullable: true),
                    ejem_estEjem = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ejemplares", x => x.id);
                    table.ForeignKey(
                        name: "FK_Ejemplares_Libros_ejem_libid",
                        column: x => x.ejem_libid,
                        principalTable: "Libros",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    reser_usuid = table.Column<int>(type: "int", nullable: true),
                    reser_ejemid = table.Column<int>(type: "int", nullable: true),
                    reser_fechReserva = table.Column<DateTime>(type: "datetime2", nullable: false),
                    reser_diasPrest = table.Column<int>(type: "int", nullable: false),
                    reser_fechDevolucion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    reser_multa = table.Column<float>(type: "real", nullable: false),
                    reser_bibid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Reservas_Bibliotecarios_reser_bibid",
                        column: x => x.reser_bibid,
                        principalTable: "Bibliotecarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservas_Ejemplares_reser_ejemid",
                        column: x => x.reser_ejemid,
                        principalTable: "Ejemplares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservas_Usuarios_reser_usuid",
                        column: x => x.reser_usuid,
                        principalTable: "Usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ejemplares_ejem_libid",
                table: "Ejemplares",
                column: "ejem_libid");

            migrationBuilder.CreateIndex(
                name: "IX_Libros_lib_autid",
                table: "Libros",
                column: "lib_autid");

            migrationBuilder.CreateIndex(
                name: "IX_Libros_lib_editid",
                table: "Libros",
                column: "lib_editid");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_reser_bibid",
                table: "Reservas",
                column: "reser_bibid");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_reser_ejemid",
                table: "Reservas",
                column: "reser_ejemid");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_reser_usuid",
                table: "Reservas",
                column: "reser_usuid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservas");

            migrationBuilder.DropTable(
                name: "Bibliotecarios");

            migrationBuilder.DropTable(
                name: "Ejemplares");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Libros");

            migrationBuilder.DropTable(
                name: "Autores");

            migrationBuilder.DropTable(
                name: "Editoriales");
        }
    }
}
