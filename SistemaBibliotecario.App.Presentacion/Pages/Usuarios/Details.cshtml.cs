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
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioUsuario repositorioUsuarios;
        public Usuario usuario { get; set; }

        public DetailsModel()
        {
            this.repositorioUsuarios = new RepositorioUsuario(new SistemaBibliotecario.App.Persistencia.AppContext());
        }

        public IActionResult OnGet(int UsuarioId)
        {
            usuario = repositorioUsuarios.GetUsuario(UsuarioId);
            if(usuario==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
        }
    }
}
