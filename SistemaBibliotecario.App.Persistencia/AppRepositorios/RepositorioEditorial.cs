using System.Collections;
using System;
using System.Collections.Generic;
using SistemaBibliotecario.App.Dominio.Entidades;
using System.Linq;
using SistemaBibliotecario.App.Dominio;

namespace SistemaBibliotecario.App.Persistencia.AppRepositorios
{
    public class RepositorioEditorial : IRepositorioEditorial
    {
        private readonly AppContext _appContext;

        public IEnumerable<Editorial> editoriales {get;set;}

        public RepositorioEditorial(AppContext appContext)
        {
            _appContext = appContext;
        }

        //Llamar la lista de Editoriales
        IEnumerable<Editorial> IRepositorioEditorial.GetAllEditoriales(string? nombre)
        {
            if (nombre != null) {
              editoriales = _appContext.Editoriales.Where(p => p.edit_nombre.Contains(nombre)); //like sobre la tabla
            }
            else 
               editoriales = _appContext.Editoriales;  //select * from Editorial
            return editoriales;
        }

        //Adicionar Editorial
        Editorial IRepositorioEditorial.AddEditorial(Editorial Editorial)
        {
            var EditorialAdicionado = _appContext.Editoriales.Add(Editorial);
            _appContext.SaveChanges();
            return EditorialAdicionado.Entity;
        }

        //Actualizar Editorial
        Editorial IRepositorioEditorial.UpdateEditorial(Editorial editorial)
        {
            var EditorialEncontrado = _appContext.Editoriales.FirstOrDefault(p => p.id == editorial.id);
            if (EditorialEncontrado != null)
            {
                
                EditorialEncontrado.edit_nombre = editorial.edit_nombre;
                
                _appContext.SaveChanges();
            }
            return EditorialEncontrado;
        }

        //Eliminar Editorial
        void IRepositorioEditorial.DeleteEditorial(int id)
        {
            var EditorialEncontrado = _appContext.Editoriales.FirstOrDefault(p => p.id == id);
            if (EditorialEncontrado == null)
                return;
            _appContext.Editoriales.Remove(EditorialEncontrado);
            _appContext.SaveChanges();
        }

        //Mostrar detalle Editorial
        Editorial IRepositorioEditorial.GetEditorial(int id)
        {
            return _appContext.Editoriales.FirstOrDefault(p => p.id == id);
        }
        
        
    }
}