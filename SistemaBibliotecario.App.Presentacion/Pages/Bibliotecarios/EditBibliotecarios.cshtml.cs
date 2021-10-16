using System.Runtime.InteropServices;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaBibliotecario.App.Persistencia.AppRepositorios;
using SistemaBibliotecario.App.Dominio.Entidades;



namespace SistemaBibliotecario.App.Presentacion
{
    public class EditBibliotecariosModel : PageModel
    {
        private readonly IRepositorioBibliotecario repositorioBibliotecarios;

        [BindProperty]
        public Bibliotecario bibliotecario  { get; set; }
        
        public EditBibliotecariosModel()
        {
            this.repositorioBibliotecarios = new RepositorioBibliotecario(new SistemaBibliotecario.App.Persistencia.AppContext());
        }
        //se ejecuta al presionar Editar en la lista
        public IActionResult OnGet(int? bibliotecarioId)
        {
            if (bibliotecarioId.HasValue)
            {
                bibliotecario = repositorioBibliotecarios.GetBibliotecario(bibliotecarioId.Value);
            }
            else
            {
                bibliotecario = new Bibliotecario();
            }
            if (bibliotecario == null)
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
            if(bibliotecario.id > 0)
            {
               bibliotecario = repositorioBibliotecarios.UpdateBibliotecario(bibliotecario);               
            }
            else
            {
               repositorioBibliotecarios.AddBibliotecario(bibliotecario);
            }
            return Page();
        }  
    }
}
