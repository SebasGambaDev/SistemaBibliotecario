using System;
using System.Collections.Generic;
using SistemaBibliotecario.App.Dominio.Entidades;
using System.Linq;

namespace SistemaBibliotecario.App.Persistencia.AppRepositorios
{
    public interface IRepositorioCategoriaLibro
    {
        IEnumerable<CategoriaLibro> GetAllCategoriasLibro(string? nombre);
        CategoriaLibro AddCategoriaLibro(CategoriaLibro categoriaLibro);
        CategoriaLibro UpdateCategoriaLibro(CategoriaLibro categoriaLibro);
        void DeleteCategoriaLibro(int id);
        CategoriaLibro GetCategoriaLibro(int id); 
         
    }
}