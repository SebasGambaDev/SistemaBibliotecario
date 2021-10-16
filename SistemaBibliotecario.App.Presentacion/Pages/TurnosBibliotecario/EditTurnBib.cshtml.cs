using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaBibliotecario.App.Persistencia.AppRepositorios;
using SistemaBibliotecario.App.Dominio.Entidades;

namespace SistemaBibliotecario.App.Presentacion.Pages
{
    public class EditTurnBibModel : PageModel
    {
private readonly IRepositorioTurno repositorioTurnos;

        [BindProperty]
        public TurnoBibliotecario turno  { get; set; } 

        public EditTurnBibModel()
        {
            this.repositorioTurnos = new RepositorioTurno(new SistemaBibliotecario.App.Persistencia.AppContext());
        }
     

        //se ejecuta al presionar Editar en la lista
        public IActionResult OnGet(int? turnoId)
        {
            if (turnoId.HasValue)
            {
                turno = repositorioTurnos.GetTurno(turnoId.Value);
            }
            else
            {
                turno = new TurnoBibliotecario();
            }
            if (turno == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        }

        //se ejecuta al presionar Guardar en el formulario
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(turno.id > 0)
            {
               turno = repositorioTurnos.UpdateTurno(turno);               
            }
            else
            {
               repositorioTurnos.AddTurno(turno);
            }
            return Page();
        }
    }
}
