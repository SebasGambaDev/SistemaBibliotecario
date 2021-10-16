using System.Collections;
using System;
using System.Collections.Generic;
using SistemaBibliotecario.App.Dominio.Entidades;
using System.Linq;
using SistemaBibliotecario.App.Dominio;

namespace SistemaBibliotecario.App.Persistencia.AppRepositorios
{
    public class RepositorioTipoLibro : IRepositorioTipoLibro
    {
        private readonly AppContext _appContext;

        public IEnumerable<TipoLibro> tiposLibro {get;set;}

        public RepositorioTipoLibro(AppContext appContext)
        {
            _appContext = appContext;
        }

        //Llamar la lista de TiposLibro
        IEnumerable<TipoLibro> IRepositorioTipoLibro.GetAllTiposLibro(string? nombre)
        {
            if (nombre != null) {
              tiposLibro = _appContext.TiposLibro.Where(p => p.tipoLibro_nombre.Contains(nombre)); //like sobre la tabla
            }
            else 
               tiposLibro = _appContext.TiposLibro;  //select * from TipoLibro
            return tiposLibro;
        }

        //Adicionar TipoLibro
        TipoLibro IRepositorioTipoLibro.AddTipoLibro(TipoLibro tipoLibro)
        {
            var TipoLibroAdicionado = _appContext.TiposLibro.Add(tipoLibro);
            _appContext.SaveChanges();
            return TipoLibroAdicionado.Entity;
        }

        //Actualizar TipoLibro
        TipoLibro IRepositorioTipoLibro.UpdateTipoLibro(TipoLibro tipoLibro)
        {
            var TipoLibroEncontrado = _appContext.TiposLibro.FirstOrDefault(p => p.id == tipoLibro.id);
            if (TipoLibroEncontrado != null)
            {
                
                TipoLibroEncontrado.tipoLibro_nombre = tipoLibro.tipoLibro_nombre;
                
                _appContext.SaveChanges();
            }
            return TipoLibroEncontrado;
        }

        //Eliminar TipoLibro
        void IRepositorioTipoLibro.DeleteTipoLibro(int id)
        {
            var TipoLibroEncontrado = _appContext.TiposLibro.FirstOrDefault(p => p.id == id);
            if (TipoLibroEncontrado == null)
                return;
            _appContext.TiposLibro.Remove(TipoLibroEncontrado);
            _appContext.SaveChanges();
        }

        //Mostrar detalle TipoLibro
        TipoLibro IRepositorioTipoLibro.GetTipoLibro(int id)
        {
            return _appContext.TiposLibro.FirstOrDefault(p => p.id == id);
        }
        
        
    }
}