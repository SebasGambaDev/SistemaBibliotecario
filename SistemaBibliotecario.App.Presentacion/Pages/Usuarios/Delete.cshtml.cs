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
    public class DeleteModel : PageModel
    {
        private readonly IRepositorioUsuario repositorioUsuarios;

        [BindProperty]
        public Usuario usuario  { get; set; } 

        public DeleteModel()
        {
            this.repositorioUsuarios = new RepositorioUsuario(new SistemaBibliotecario.App.Persistencia.AppContext());
        }
     

        //se ejecuta al presionar Eliminar en la lista
        public IActionResult OnGet(int usuarioId)
        {
            usuario = repositorioUsuarios.GetUsuario(usuarioId);
            if(usuario == null)
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
            if(usuario.id > 0)
            {
               repositorioUsuarios.DeleteUsuario(usuario.id);
            }
            return Page();
        }
    }
}
