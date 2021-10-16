using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaBibliotecario.App.Dominio.Entidades
{
    public class TipoLibro
    {
        public  int id {get;set;}

        [Requerido, StringLengthAttribute(50), Display(Name = "Tipo de libro:")]
        public string tipoLibro_nombre {get;set;}
    }
}