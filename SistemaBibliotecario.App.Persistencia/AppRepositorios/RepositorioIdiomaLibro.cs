using System.Collections;
using System;
using System.Collections.Generic;
using SistemaBibliotecario.App.Dominio.Entidades;
using System.Linq;
using SistemaBibliotecario.App.Dominio;

namespace SistemaBibliotecario.App.Persistencia.AppRepositorios
{
    public class RepositorioIdiomaLibro : IRepositorioIdiomaLibro
    {
        private readonly AppContext _appContext;

        public IEnumerable<IdiomaLibro> idiomasLibro {get;set;}

        public RepositorioIdiomaLibro(AppContext appContext)
        {
            _appContext = appContext;
        }

        //Llamar la lista de IdiomasLibro
        IEnumerable<IdiomaLibro> IRepositorioIdiomaLibro.GetAllIdiomasLibro(string? nombre)
        {
            if (nombre != null) {
              idiomasLibro = _appContext.IdiomasLibro.Where(p => p.idiomaLibro_nombre.Contains(nombre)); //like sobre la tabla
            }
            else 
               idiomasLibro = _appContext.IdiomasLibro;  //select * from IdiomaLibro
            return idiomasLibro;
        }

        //Adicionar IdiomaLibro
        IdiomaLibro IRepositorioIdiomaLibro.AddIdiomaLibro(IdiomaLibro idiomaLibro)
        {
            var IdiomaLibroAdicionado = _appContext.IdiomasLibro.Add(idiomaLibro);
            _appContext.SaveChanges();
            return IdiomaLibroAdicionado.Entity;
        }

        //Actualizar IdiomaLibro
        IdiomaLibro IRepositorioIdiomaLibro.UpdateIdiomaLibro(IdiomaLibro idiomaLibro)
        {
            var IdiomaLibroEncontrado = _appContext.IdiomasLibro.FirstOrDefault(p => p.id == idiomaLibro.id);
            if (IdiomaLibroEncontrado != null)
            {
                
                IdiomaLibroEncontrado.idiomaLibro_nombre = idiomaLibro.idiomaLibro_nombre;
                
                _appContext.SaveChanges();
            }
            return IdiomaLibroEncontrado;
        }

        //Eliminar IdiomaLibro
        void IRepositorioIdiomaLibro.DeleteIdiomaLibro(int id)
        {
            var IdiomaLibroEncontrado = _appContext.IdiomasLibro.FirstOrDefault(p => p.id == id);
            if (IdiomaLibroEncontrado == null)
                return;
            _appContext.IdiomasLibro.Remove(IdiomaLibroEncontrado);
            _appContext.SaveChanges();
        }

        //Mostrar detalle IdiomaLibro
        IdiomaLibro IRepositorioIdiomaLibro.GetIdiomaLibro(int id)
        {
            return _appContext.IdiomasLibro.FirstOrDefault(p => p.id == id);
        }
        
        
    }
}