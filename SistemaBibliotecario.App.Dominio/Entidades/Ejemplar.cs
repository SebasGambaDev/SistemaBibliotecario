using System;
namespace SistemaBibliotecario.App.Dominio.Entidades
{
    public class Ejemplar
    {
       
        public int id{get;set;} 
        public string ejem_scdd{get;set;}

        public Libro ejem_lib{get;set;}
        public EstadoEjemplar ejem_estEjem{get;set;}
    }
}