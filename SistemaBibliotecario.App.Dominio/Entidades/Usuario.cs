using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;
using System;

namespace SistemaBibliotecario.App.Dominio.Entidades
{
    public class Usuario
    {
      public int id{get;set;}

      [Requerido, StringLengthAttribute(50), Display(Name = "DNI:")]
      public string usu_identificacion{get;set;}
      
      [Requerido, StringLengthAttribute(50), Display(Name = "Nombres:")]
      public string usu_nombre{get;set;}

      [Requerido, StringLengthAttribute(50), Display(Name = "Apellidos:")]
      public string usu_apellido{get;set;}

      [Requerido, StringLengthAttribute(100), Display(Name = "Dirección:")]
      public string usu_direccion{get;set;}

      [Requerido, StringLengthAttribute(50), Display(Name = "Correo electrónico:")]
      public string usu_email{get;set;}
      
      [Requerido, StringLengthAttribute(50), Display(Name = "Telefono:")]
      public string usu_telefono{get;set;}
    }
    public class Requerido : RequiredAttribute
    {
      public Requerido()
      {
          this.ErrorMessage = "Campo requerido, por favor ingrese datos.";
      }
    }
}