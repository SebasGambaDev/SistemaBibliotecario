using System;
namespace SistemaBibliotecario.App.Dominio.Entidades
{
    public class Bibliotecario
    {
        public int id{get;set;}
        public string bib_identificacion{get;set;}
        public string bib_nombre{get;set;}
        public string bib_apellido{get;set;}
        public string bib_email{get;set;}
        public string bib_telefono{get;set;}

        public TurnoBibliotecario bib_turnBib{get;set;}
    }
}