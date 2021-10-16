using System.Collections;
using System;
using System.Collections.Generic;
using SistemaBibliotecario.App.Dominio.Entidades;
using System.Linq;
using SistemaBibliotecario.App.Dominio;

namespace SistemaBibliotecario.App.Persistencia.AppRepositorios
{
    public class RepositorioCategoriaLibro : IRepositorioCategoriaLibro
    {
        private readonly AppContext _appContext;

        public IEnumerable<CategoriaLibro> categoriaLibro {get;set;}

        public RepositorioCategoriaLibro(AppContext appContext)
        {
            _appContext = appContext;
        }

        //Llamar la lista de CategoriasLibro
        IEnumerable<CategoriaLibro> IRepositorioCategoriaLibro.GetAllCategoriasLibro(string? nombre)
        {
            if (nombre != null) {
              categoriaLibro = _appContext.CategoriasLibro.Where(p => p.catLibro_nombre.Contains(nombre)); //like sobre la tabla
            }
            else 
               categoriaLibro = _appContext.CategoriasLibro;  //select * from CategoriaLibro
            return categoriaLibro;
        }

        //Adicionar CategoriaLibro
        CategoriaLibro IRepositorioCategoriaLibro.AddCategoriaLibro(CategoriaLibro categoriaLibro)
        {
            var CategoriaLibroAdicionado = _appContext.CategoriasLibro.Add(categoriaLibro);
            _appContext.SaveChanges();
            return CategoriaLibroAdicionado.Entity;
        }

        //Actualizar CategoriaLibro
        CategoriaLibro IRepositorioCategoriaLibro.UpdateCategoriaLibro(CategoriaLibro categoriaLibro)
        {
            var CategoriaLibroEncontrado = _appContext.CategoriasLibro.FirstOrDefault(p => p.id == categoriaLibro.id);
            if (CategoriaLibroEncontrado != null)
            {
                
                CategoriaLibroEncontrado.catLibro_nombre = categoriaLibro.catLibro_nombre;
                
                _appContext.SaveChanges();
            }
            return CategoriaLibroEncontrado;
        }

        //Eliminar CategoriaLibro
        void IRepositorioCategoriaLibro.DeleteCategoriaLibro(int id)
        {
            var CategoriaLibroEncontrado = _appContext.CategoriasLibro.FirstOrDefault(p => p.id == id);
            if (CategoriaLibroEncontrado == null)
                return;
            _appContext.CategoriasLibro.Remove(CategoriaLibroEncontrado);
            _appContext.SaveChanges();
        }

        //Mostrar detalle CategoriaLibro
        CategoriaLibro IRepositorioCategoriaLibro.GetCategoriaLibro(int id)
        {
            return _appContext.CategoriasLibro.FirstOrDefault(p => p.id == id);
        }
        
        
    }
}