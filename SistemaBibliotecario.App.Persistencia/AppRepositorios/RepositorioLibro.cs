using System.Collections;
using System;
using System.Collections.Generic;
using SistemaBibliotecario.App.Dominio.Entidades;
using System.Linq;
using SistemaBibliotecario.App.Dominio;


namespace SistemaBibliotecario.App.Persistencia.AppRepositorios
{
    public class RepositorioLibro : IRepositorioLibro
    {
        private readonly AppContext _appContext;

        public IEnumerable<Libro> libros {get;set;}
        
        public RepositorioLibro(AppContext appContext)
        {
            _appContext = appContext;
        }

        //Llamar la lista de Libros
        IEnumerable<Libro> IRepositorioLibro.GetAllLibros(string? nombre)
        {
            if (nombre != null) {
              libros = _appContext.Libros.Where(p => p.lib_titulo.Contains(nombre)); //like sobre la tabla
            }
            else 
               libros = _appContext.Libros;  //select * from Libro
            return libros;
        }

        //Adicionar Libro
        Libro IRepositorioLibro.AddLibro(Libro libro)
        {
            try
            {
                var LibroAdicionado = _appContext.Libros.Add(libro);
                _appContext.SaveChanges();
                return LibroAdicionado.Entity;

            }catch
            {
                throw;
            }
        }

        //Actualizar Libro
        Libro IRepositorioLibro.UpdateLibro(Libro libro)
        {
            var LibroEncontrado = _appContext.Libros.FirstOrDefault(p => p.id == libro.id);
            if (LibroEncontrado != null)
            {
                LibroEncontrado.lib_titulo = libro.lib_titulo;
                LibroEncontrado.lib_isbn = libro.lib_isbn;
                LibroEncontrado.lib_sinopsis = libro.lib_sinopsis;
                LibroEncontrado.lib_numCapt = libro.lib_numCapt;
                LibroEncontrado.lib_numPag = libro.lib_numPag;
                LibroEncontrado.lib_fechaPub = libro.lib_fechaPub;
                LibroEncontrado.lib_tipoLibroid = libro.lib_tipoLibroid;
                LibroEncontrado.lib_idioLibroid = libro.lib_idioLibroid;
                LibroEncontrado.lib_catLibroid = libro.lib_catLibroid;
                LibroEncontrado.lib_editid = libro.lib_editid;
                LibroEncontrado.lib_autid = libro.lib_autid;
                _appContext.SaveChanges();
            }
            return LibroEncontrado;
        }

        //Eliminar Libro
        void IRepositorioLibro.DeleteLibro(int id)
        {
            var LibroEncontrado = _appContext.Libros.FirstOrDefault(p => p.id == id);
            if (LibroEncontrado == null)
                return;
            _appContext.Libros.Remove(LibroEncontrado);
            _appContext.SaveChanges();
        }

        //Mostrar detalle Libro
        Libro IRepositorioLibro.GetLibro(int id)
        {
            return _appContext.Libros.FirstOrDefault(p => p.id == id);
        }

    }
}