using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaBibliotecario.App.Dominio.Entidades;
using SistemaBibliotecario.App.Persistencia.AppRepositorios;

namespace SistemaBibliotecario.App.Presentacion
{
    public class DetailsBibliotecariosModel : PageModel
    {
        private readonly IRepositorioBibliotecario repositorioBibliotecarios;
        public Bibliotecario bibliotecario { get; set; }

        public DetailsBibliotecariosModel ()
        {
            this.repositorioBibliotecarios = new RepositorioBibliotecario(new SistemaBibliotecario.App.Persistencia.AppContext());
        }

        public IActionResult OnGet(int BibliotecarioId)
        {
            bibliotecario = repositorioBibliotecarios.GetBibliotecario(BibliotecarioId);
            if (bibliotecario == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();
        }
    }
}
