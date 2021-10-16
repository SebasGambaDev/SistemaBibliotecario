using System;
using System.Collections.Generic;
using SistemaBibliotecario.App.Dominio.Entidades;
using System.Linq;

namespace SistemaBibliotecario.App.Persistencia.AppRepositorios
{
    public interface IRepositorioTipoLibro
    {
        IEnumerable<TipoLibro> GetAllTiposLibro(string? nombre);
        TipoLibro AddTipoLibro(TipoLibro tipoLibro);
        TipoLibro UpdateTipoLibro(TipoLibro itipoLibro);
        void DeleteTipoLibro(int id);
        TipoLibro GetTipoLibro(int id); 
         
    }
}