using System;
using System.Collections.Generic;
using SistemaBibliotecario.App.Dominio.Entidades;
using System.Linq;
using SistemaBibliotecario.App.Dominio;

namespace SistemaBibliotecario.App.Persistencia.AppRepositorios
{
    public class RepositorioTurno : IRepositorioTurno
    {
        private readonly AppContext _appContext;

        public IEnumerable<TurnoBibliotecario> turnos {get; set;}

        public RepositorioTurno(AppContext appContext)
        {
            _appContext = appContext;
        }

        //Llamar la lista de turnos
        IEnumerable<TurnoBibliotecario> IRepositorioTurno.GetAllTurnos(string? nombre)
        {
            if (nombre != null) {
              turnos = _appContext.TurnosBibliotecario.Where(p => p.turn_nombre.Contains(nombre)); //like sobre la tabla
            }
            else 
               turnos = _appContext.TurnosBibliotecario;  //select * from usuario
            return turnos;
        }

        //Adicionar turno
        TurnoBibliotecario IRepositorioTurno.AddTurno(TurnoBibliotecario turno)
        {
            var TurnoAdicionado = _appContext.TurnosBibliotecario.Add(turno);
            _appContext.SaveChanges();
            return TurnoAdicionado.Entity;
        }

        //Actualizar Turno
        TurnoBibliotecario IRepositorioTurno.UpdateTurno(TurnoBibliotecario turno)
        {
            var TurnoEncontrado = _appContext.TurnosBibliotecario.FirstOrDefault(p => p.id == turno.id);
            if (TurnoEncontrado != null)
            {
                TurnoEncontrado.turn_nombre = turno.turn_nombre;
               
                _appContext.SaveChanges();
            }
            return TurnoEncontrado;
        }

        //Eliminar Turno
        void IRepositorioTurno.DeleteTurno(int id)
        {
            var TurnoEncontrado = _appContext.TurnosBibliotecario.FirstOrDefault(p => p.id == id);
            if (TurnoEncontrado == null)
                return;
            _appContext.TurnosBibliotecario.Remove(TurnoEncontrado);
            _appContext.SaveChanges();
        }

        //Mostrar detalle Turno
        TurnoBibliotecario IRepositorioTurno.GetTurno(int id)
        {
            return _appContext.TurnosBibliotecario.FirstOrDefault(p => p.id == id);
        }
        
    }
}