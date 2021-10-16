using System;
using System.Collections.Generic;
using SistemaBibliotecario.App.Dominio.Entidades;
using System.Linq;

namespace SistemaBibliotecario.App.Persistencia.AppRepositorios
{
    public interface IRepositorioTurno
    {
        IEnumerable<TurnoBibliotecario> GetAllTurnos(string? nombre);
        TurnoBibliotecario AddTurno(TurnoBibliotecario turno);
        TurnoBibliotecario UpdateTurno(TurnoBibliotecario turno);
        void DeleteTurno(int id);
        TurnoBibliotecario GetTurno(int id); 
         
    }
}