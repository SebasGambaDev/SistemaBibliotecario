using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaBibliotecario.App.Dominio.Entidades
{
    public class IdiomaLibro
    {
        public  int id {get;set;}

        [Requerido, StringLengthAttribute(50), Display(Name = "Idioma de libro:")]
        public string idiomaLibro_nombre {get;set;}
    }
}