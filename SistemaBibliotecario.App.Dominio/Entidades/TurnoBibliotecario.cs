using System;
using System.ComponentModel.DataAnnotations;


namespace SistemaBibliotecario.App.Dominio.Entidades
{
    public class TurnoBibliotecario
    {
        public  int id {get;set;}

        [Requerido, StringLengthAttribute(50), Display(Name = "Turno:")]
        public string turn_nombre {get;set;}   
    }
}