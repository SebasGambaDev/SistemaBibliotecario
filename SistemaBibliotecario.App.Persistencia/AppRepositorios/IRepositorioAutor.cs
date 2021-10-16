using System;
using System.Collections.Generic;
using SistemaBibliotecario.App.Dominio.Entidades;
using System.Linq;

namespace SistemaBibliotecario.App.Persistencia.AppRepositorios
{
    public interface IRepositorioAutor
    {
        IEnumerable<Autor> GetAllAutores(string? nombre);
        Autor AddAutor(Autor autor);
        Autor UpdateAutor(Autor autor);
        void DeleteAutor(int id);
        Autor GetAutor(int id); 
         
    }
}