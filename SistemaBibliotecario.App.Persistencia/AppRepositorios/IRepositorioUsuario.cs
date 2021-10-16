using System;
using System.Collections.Generic;
using SistemaBibliotecario.App.Dominio.Entidades;
using System.Linq;


namespace SistemaBibliotecario.App.Persistencia.AppRepositorios
{
    public interface IRepositorioUsuario
    {
        IEnumerable<Usuario> GetAllUsuarios(string? nombre);
        Usuario AddUsuario(Usuario usuario);
        Usuario UpdateUsuario(Usuario usuario);
        void DeleteUsuario(int id);
        Usuario GetUsuario(int id); 
    }
}