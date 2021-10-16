using System;
namespace SistemaBibliotecario.App.Dominio.Entidades
{
    public class Libro
    {
        public int id{get;set;}
        public string lib_titulo{get;set;}
        public string lib_isbn{get;set;}
        public string lib_sinopsis{get;set;}
        public int lib_numCapt{get;set;}
        public int lib_numPag{get;set;}
        public DateTime lib_fechaPub{get;set;}

        public int lib_tipoLibro{get;set;}
        public int lib_catLibro{get;set;}
        public int lib_idioLibro{get;set;}
        public int lib_edit{get;set;}
        public int lib_aut{get;set;}
    }
}