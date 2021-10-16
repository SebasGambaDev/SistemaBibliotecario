using System;
using System.Collections.Generic;
using SistemaBibliotecario.App.Dominio.Entidades;
using System.Linq;


namespace SistemaBibliotecario.App.Persistencia.AppRepositorios
{
    public interface IRepositorioBibliotecario
    {
        IEnumerable<Bibliotecario> GetAllBibliotecarios();
        Bibliotecario AddBibliotecario(Bibliotecario bibliotecario);
        Bibliotecario UpdateBibliotecario(Bibliotecario bibliotecario);
        void DeleteBibliotecario(int id);
        Bibliotecario GetBibliotecario(int id); 
    }
}