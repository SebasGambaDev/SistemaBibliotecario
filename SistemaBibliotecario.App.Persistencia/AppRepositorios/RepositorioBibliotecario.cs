using System;
using System.Collections.Generic;
using SistemaBibliotecario.App.Dominio.Entidades;
using System.Linq;


namespace SistemaBibliotecario.App.Persistencia.AppRepositorios
{
    public class RepositorioBibliotecario : IRepositorioBibliotecario
    {
        private readonly AppContext _appContext;

        public RepositorioBibliotecario(AppContext appContext)
        {
            _appContext = appContext;
        }

        //Llamar la lista de Bibliotecarios
        IEnumerable<Bibliotecario> IRepositorioBibliotecario.GetAllBibliotecarios()
        {
            return _appContext.Bibliotecarios;
        }

        //Adicionar Bibliotecario
        Bibliotecario IRepositorioBibliotecario.AddBibliotecario(Bibliotecario bibliotecario)
        {
            var BibliotecarioAdicionado = _appContext.Bibliotecarios.Add(bibliotecario);
            _appContext.SaveChanges();
            return BibliotecarioAdicionado.Entity;
        }

        //Actualizar Bibliotecario
        Bibliotecario IRepositorioBibliotecario.UpdateBibliotecario(Bibliotecario bibliotecario)
        {
            var BibliotecarioEncontrado = _appContext.Bibliotecarios.FirstOrDefault(p => p.id == bibliotecario.id);
            if (BibliotecarioEncontrado != null)
            {
                BibliotecarioEncontrado.bib_identificacion = bibliotecario.bib_identificacion;
                BibliotecarioEncontrado.bib_nombre = bibliotecario.bib_nombre;
                BibliotecarioEncontrado.bib_apellido = bibliotecario.bib_apellido;
                BibliotecarioEncontrado.bib_email = bibliotecario.bib_email;
                BibliotecarioEncontrado.bib_telefono = bibliotecario.bib_telefono;
                
                _appContext.SaveChanges();
            }
            return BibliotecarioEncontrado;
        }

        //Eliminar Bibliotecario
        void IRepositorioBibliotecario.DeleteBibliotecario(int id)
        {
            var BibliotecarioEncontrado = _appContext.Bibliotecarios.FirstOrDefault(p => p.id == id);
            if (BibliotecarioEncontrado == null)
                return;
            _appContext.Bibliotecarios.Remove(BibliotecarioEncontrado);
            _appContext.SaveChanges();
        }

        //Mostrar detalle Bibliotecario
        Bibliotecario IRepositorioBibliotecario.GetBibliotecario(int id)
        {
            return _appContext.Bibliotecarios.FirstOrDefault(p => p.id == id);
        }
    }
}