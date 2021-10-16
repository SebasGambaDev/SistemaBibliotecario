using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaBibliotecario.App.Persistencia.Migrations
{
    public partial class Entidades : Migration
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
                name: "CategoriasLibro",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    catLibro_nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriasLibro", x => x.id);
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
                name: "EstadosEjemplar",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    estadoEjemplar_nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadosEjemplar", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "IdiomasLibro",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idiomaLibro_nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdiomasLibro", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TiposLibro",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipoLibro_nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposLibro", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TurnosBibliotecario",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    turn_nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TurnosBibliotecario", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usu_identificacion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    usu_nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    usu_apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    usu_direccion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    usu_email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    usu_telefono = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
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
                    lib_tipoLibroid = table.Column<int>(type: "int", nullable: true),
                    lib_catLibroid = table.Column<int>(type: "int", nullable: true),
                    lib_idioLibroid = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_Libros_CategoriasLibro_lib_catLibroid",
                        column: x => x.lib_catLibroid,
                        principalTable: "CategoriasLibro",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Libros_Editoriales_lib_editid",
                        column: x => x.lib_editid,
                        principalTable: "Editoriales",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Libros_IdiomasLibro_lib_idioLibroid",
                        column: x => x.lib_idioLibroid,
                        principalTable: "IdiomasLibro",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Libros_TiposLibro_lib_tipoLibroid",
                        column: x => x.lib_tipoLibroid,
                        principalTable: "TiposLibro",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
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
                    bib_turnBibid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bibliotecarios", x => x.id);
                    table.ForeignKey(
                        name: "FK_Bibliotecarios_TurnosBibliotecario_bib_turnBibid",
                        column: x => x.bib_turnBibid,
                        principalTable: "TurnosBibliotecario",
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
                    ejem_estEjemid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ejemplares", x => x.id);
                    table.ForeignKey(
                        name: "FK_Ejemplares_EstadosEjemplar_ejem_estEjemid",
                        column: x => x.ejem_estEjemid,
                        principalTable: "EstadosEjemplar",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "IX_Bibliotecarios_bib_turnBibid",
                table: "Bibliotecarios",
                column: "bib_turnBibid");

            migrationBuilder.CreateIndex(
                name: "IX_Ejemplares_ejem_estEjemid",
                table: "Ejemplares",
                column: "ejem_estEjemid");

            migrationBuilder.CreateIndex(
                name: "IX_Ejemplares_ejem_libid",
                table: "Ejemplares",
                column: "ejem_libid");

            migrationBuilder.CreateIndex(
                name: "IX_Libros_lib_autid",
                table: "Libros",
                column: "lib_autid");

            migrationBuilder.CreateIndex(
                name: "IX_Libros_lib_catLibroid",
                table: "Libros",
                column: "lib_catLibroid");

            migrationBuilder.CreateIndex(
                name: "IX_Libros_lib_editid",
                table: "Libros",
                column: "lib_editid");

            migrationBuilder.CreateIndex(
                name: "IX_Libros_lib_idioLibroid",
                table: "Libros",
                column: "lib_idioLibroid");

            migrationBuilder.CreateIndex(
                name: "IX_Libros_lib_tipoLibroid",
                table: "Libros",
                column: "lib_tipoLibroid");

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
                name: "TurnosBibliotecario");

            migrationBuilder.DropTable(
                name: "EstadosEjemplar");

            migrationBuilder.DropTable(
                name: "Libros");

            migrationBuilder.DropTable(
                name: "Autores");

            migrationBuilder.DropTable(
                name: "CategoriasLibro");

            migrationBuilder.DropTable(
                name: "Editoriales");

            migrationBuilder.DropTable(
                name: "IdiomasLibro");

            migrationBuilder.DropTable(
                name: "TiposLibro");
        }
    }
}
