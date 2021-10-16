using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaBibliotecario.App.Persistencia.AppRepositorios;
using SistemaBibliotecario.App.Dominio.Entidades;

namespace SitemaBibliotecario.App.Presentacion
{
    public class EditAutoresModel : PageModel
    {
        private readonly IRepositorioAutor repositorioAutores;

        [BindProperty]
        public Autor autor  { get; set; } 

        public EditAutoresModel()
        {
            this.repositorioAutores = new RepositorioAutor(new SistemaBibliotecario.App.Persistencia.AppContext());
        }
     

        //se ejecuta al presionar Editar en la lista
        public IActionResult OnGet(int? autorId)
        {
            if (autorId.HasValue)
            {
                autor = repositorioAutores.GetAutor(autorId.Value);
            }
            else
            {
                autor = new Autor();
            }
            if (autor == null)
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
            if(autor.id > 0)
            {
               autor = repositorioAutores.UpdateAutor(autor);               
            }
            else
            {
               repositorioAutores.AddAutor(autor);
            }
            return Page();
        }
    }
}
