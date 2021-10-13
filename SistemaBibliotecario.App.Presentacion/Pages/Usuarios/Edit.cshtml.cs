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
    public class EditModel : PageModel
    {
        private readonly IRepositorioUsuario repositorioUsuarios;

        [BindProperty]
        public Usuario usuario  { get; set; } 

        public EditModel()
        {
            this.repositorioUsuarios = new RepositorioUsuario(new SistemaBibliotecario.App.Persistencia.AppContext());
        }
     

        //se ejecuta al presionar Editar en la lista
        public IActionResult OnGet(int? usuarioId)
        {
            if (usuarioId.HasValue)
            {
                usuario = repositorioUsuarios.GetUsuario(usuarioId.Value);
            }
            else
            {
                usuario = new Usuario();
            }
            if (usuario == null)
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
            if(usuario.id > 0)
            {
               usuario = repositorioUsuarios.UpdateUsuario(usuario);               
            }
            else
            {
               repositorioUsuarios.AddUsuario(usuario);
            }
            return Page();
        }
    }
}
