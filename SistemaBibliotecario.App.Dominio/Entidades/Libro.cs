using System;
namespace SistemaBibliotecario.App.Dominio.Entidades
{
    public class Libro
    {
        public int lib_id{get;set;}

        public string lib_titulo{get;set;}
        public string lib_isbn{get;set;}
        public string lib_sinopsis{get;set;}
        public int lib_numCapt{get;set;}
        public int lib_numPag{get;set;}
        public DateTime lib_fechaPub{get;set;}

        public Tipo_libro lib_tipoLibro{get;set;}
        public Categoria_libro lib_catLibro{get;set;}
        public Idioma_libro lib_idioLibro{get;set;}
        public Editorial lib_edit{get;set;}

        public Autor lib_aut{get;set;}
    }
}