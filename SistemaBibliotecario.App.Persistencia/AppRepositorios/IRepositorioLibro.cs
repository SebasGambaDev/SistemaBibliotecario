using System;
using System.Collections.Generic;
using SistemaBibliotecario.App.Dominio.Entidades;
using System.Linq;


namespace SistemaBibliotecario.App.Persistencia.AppRepositorios
{
    public interface IRepositorioLibro
    {
        IEnumerable<Libro> GetAllLibros(string? nombre);
        Libro AddLibro(Libro libro);
        Libro UpdateLibro(Libro libro);
        void DeleteLibro(int id);
        Libro GetLibro(int id);
        
    }
}