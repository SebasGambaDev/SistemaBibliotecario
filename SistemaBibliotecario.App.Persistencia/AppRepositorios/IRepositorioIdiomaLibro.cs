using System;
using System.Collections.Generic;
using SistemaBibliotecario.App.Dominio.Entidades;
using System.Linq;

namespace SistemaBibliotecario.App.Persistencia.AppRepositorios
{
    public interface IRepositorioIdiomaLibro
    {
        IEnumerable<IdiomaLibro> GetAllIdiomasLibro(string? nombre);
        IdiomaLibro AddIdiomaLibro(IdiomaLibro idiomaLibro);
        IdiomaLibro UpdateIdiomaLibro(IdiomaLibro idiomaLibro);
        void DeleteIdiomaLibro(int id);
        IdiomaLibro GetIdiomaLibro(int id); 
         
    }
}