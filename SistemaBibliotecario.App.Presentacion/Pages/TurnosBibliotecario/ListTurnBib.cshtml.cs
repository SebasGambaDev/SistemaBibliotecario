using System.Runtime.CompilerServices;
using System.Globalization;
using System.Collections;
using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaBibliotecario.App.Dominio.Entidades;
using SistemaBibliotecario.App.Persistencia.AppRepositorios;
using SistemaBibliotecario.App.Persistencia;

namespace SistemaBibliotecario.App.Presentacion.Pages
{
    public class ListTurnBibModel : PageModel
    {
         private readonly IRepositorioTurno repositorioTurnos;

        public IEnumerable<TurnoBibliotecario> turnos {get;set;}

        public string searchString;
        
        public ListTurnBibModel(IRepositorioTurno repositorioTurnos)
        {
            this.repositorioTurnos=repositorioTurnos;
        }

        public void OnGet()
        {
            turnos = repositorioTurnos.GetAllTurnos(searchString);
        }

        public IActionResult OnPost(string? searchString)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            turnos = repositorioTurnos.GetAllTurnos(searchString);
            return Page();
        }
    }
}
