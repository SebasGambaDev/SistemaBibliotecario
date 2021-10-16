using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaBibliotecario.App.Dominio.Entidades;
using SistemaBibliotecario.App.Persistencia.AppRepositorios;

namespace SistemaBibliotecario.App.Presentacion.Pages
{
    public class DeleteTurnBibModel : PageModel
    {
        private readonly IRepositorioTurno repositorioTurnos;

        [BindProperty]
        public TurnoBibliotecario turno  { get; set; } 

        public DeleteTurnBibModel()
        {
            this.repositorioTurnos = new RepositorioTurno(new SistemaBibliotecario.App.Persistencia.AppContext());
        }
     

        //se ejecuta al presionar Eliminar en la lista
        public IActionResult OnGet(int turnoId)
        {
            turno = repositorioTurnos.GetTurno(turnoId);
            if(turno == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();

        }

        //se ejecuta al presionar Eliminar en el formulario 
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(turno.id > 0)
            {
               repositorioTurnos.DeleteTurno(turno.id);
            }
            return Page();
        }
    }
}
