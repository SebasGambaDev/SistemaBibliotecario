using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaBibliotecario.App.Dominio.Entidades
{
    public class Autor
    {
       public int id{get;set;}

       [Requerido, StringLengthAttribute(50), Display(Name = "Nombre de autor:")]
       public string aut_nombre{get;set;} 
    }
}