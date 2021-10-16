using System;
using System.Collections.Generic;
using SistemaBibliotecario.App.Dominio.Entidades;
using System.Linq;

namespace SistemaBibliotecario.App.Persistencia.AppRepositorios
{
    public interface IRepositorioEditorial
    {
        IEnumerable<Editorial> GetAllEditoriales(string? nombre);
        Editorial AddEditorial(Editorial editorial);
        Editorial UpdateEditorial(Editorial editorial);
        void DeleteEditorial(int id);
        Editorial GetEditorial(int id); 
         
    }
}