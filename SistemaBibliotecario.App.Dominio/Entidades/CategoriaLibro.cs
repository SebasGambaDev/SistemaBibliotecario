using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaBibliotecario.App.Dominio.Entidades
{
    public class CategoriaLibro
    {
        public  int id {get;set;}

        [Requerido, StringLengthAttribute(50), Display(Name = "Categoria de libro:")]
        public string catLibro_nombre {get;set;}
    }
}