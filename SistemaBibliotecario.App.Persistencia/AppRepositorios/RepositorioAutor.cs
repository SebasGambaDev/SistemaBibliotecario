using System.Collections;
using System;
using System.Collections.Generic;
using SistemaBibliotecario.App.Dominio.Entidades;
using System.Linq;
using SistemaBibliotecario.App.Dominio;

namespace SistemaBibliotecario.App.Persistencia.AppRepositorios
{
    public class RepositorioAutor : IRepositorioAutor
    {
        private readonly AppContext _appContext;

        public IEnumerable<Autor> autores {get;set;}

        public RepositorioAutor(AppContext appContext)
        {
            _appContext = appContext;
        }

        //Llamar la lista de Autores
        IEnumerable<Autor> IRepositorioAutor.GetAllAutores(string? nombre)
        {
            if (nombre != null) {
              autores = _appContext.Autores.Where(p => p.aut_nombre.Contains(nombre)); //like sobre la tabla
            }
            else 
               autores = _appContext.Autores;  //select * from Autor
            return autores;
        }

        //Adicionar Autor
        Autor IRepositorioAutor.AddAutor(Autor autor)
        {
            var AutorAdicionado = _appContext.Autores.Add(autor);
            _appContext.SaveChanges();
            return AutorAdicionado.Entity;
        }

        //Actualizar Autor
        Autor IRepositorioAutor.UpdateAutor(Autor autor)
        {
            var AutorEncontrado = _appContext.Autores.FirstOrDefault(p => p.id == autor.id);
            if (AutorEncontrado != null)
            {
                
                AutorEncontrado.aut_nombre = autor.aut_nombre;
                
                _appContext.SaveChanges();
            }
            return AutorEncontrado;
        }

        //Eliminar Autor
        void IRepositorioAutor.DeleteAutor(int id)
        {
            var AutorEncontrado = _appContext.Autores.FirstOrDefault(p => p.id == id);
            if (AutorEncontrado == null)
                return;
            _appContext.Autores.Remove(AutorEncontrado);
            _appContext.SaveChanges();
        }

        //Mostrar detalle Autor
        Autor IRepositorioAutor.GetAutor(int id)
        {
            return _appContext.Autores.FirstOrDefault(p => p.id == id);
        }
        
        
    }
}