using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaBibliotecario.App.Dominio.Entidades
{
    public class Editorial
    {
        public int id{get;set;}

        [Requerido, StringLengthAttribute(50), Display(Name = "Nombre de editorial:")]
        public string edit_nombre{get;set;}
    }
}