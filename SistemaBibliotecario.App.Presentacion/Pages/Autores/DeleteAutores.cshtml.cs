using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaBibliotecario.App.Dominio.Entidades;
using SistemaBibliotecario.App.Persistencia.AppRepositorios;

namespace SitemaBibliotecario.App.Presentacion
{
    public class DeleteAutoresModel : PageModel
    {
        private readonly IRepositorioAutor repositorioAutores;

        [BindProperty]
        public Autor autor  { get; set; } 

        public DeleteAutoresModel()
        {
            this.repositorioAutores = new RepositorioAutor(new SistemaBibliotecario.App.Persistencia.AppContext());
        }
     

        //se ejecuta al presionar Eliminar en la lista
        public IActionResult OnGet(int autorId)
        {
            autor = repositorioAutores.GetAutor(autorId);
            if(autor == null)
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
            if(autor.id > 0)
            {
               repositorioAutores.DeleteAutor(autor.id);
            }
            return Page();
        }
    }
}
