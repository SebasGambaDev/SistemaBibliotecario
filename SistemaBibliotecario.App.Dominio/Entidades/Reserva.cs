using System;
namespace SistemaBibliotecario.App.Dominio.Entidades
{
    public class Reserva
    {
       public int id{get;set;}
       
       public int reser_usu{get;set;} 
       public int reser_ejem{get;set;} 

       public DateTime reser_fechReserva{get;set;}
       public int reser_diasPrest{get;set;}
       public DateTime reser_fechDevolucion{get;set;}  
       public float reser_multa{get;set;}  

       public int reser_bib{get;set;} 
    }
}