using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaBibliotecario.App.Dominio.Entidades
{
    public class Libro
    {
        public int id{get;set;}

        [Requerido, StringLengthAttribute(50), Display(Name = "Titulo:")]
        public string lib_titulo{get;set;}

        [Requerido, StringLengthAttribute(50), Display(Name = "ISBN:")]
        public string lib_isbn{get;set;}

        [Requerido, StringLengthAttribute(50), Display(Name = "Sinopsis:")]
        public string lib_sinopsis{get;set;}

        [Requerido, Display(Name = "Numero de capitulos:")]
        public int lib_numCapt{get;set;}

        [Requerido, Display(Name = "Numero de páginas:")]
        public int lib_numPag{get;set;}

        [Display(Name = "Fecha de publicación:")]
        public DateTime lib_fechaPub{get;set;}

        public int lib_tipoLibroid{get;set;}
        public int lib_catLibroid{get;set;}
        public int lib_idioLibroid{get;set;}
        public int lib_editid{get;set;}
        public int lib_autid{get;set;}
    }
}