using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaBibliotecario.App.Dominio.Entidades;
using SistemaBibliotecario.App.Persistencia.AppRepositorios;

namespace SitemaBibliotecario.App.Presentacion.Pages
{
    public class DeleteEditorialesModel : PageModel
    {
        private readonly IRepositorioEditorial repositorioEditoriales;

        [BindProperty]
        public Editorial editorial  { get; set; } 

        public DeleteEditorialesModel()
        {
            this.repositorioEditoriales = new RepositorioEditorial(new SistemaBibliotecario.App.Persistencia.AppContext());
        }
     

        //se ejecuta al presionar Eliminar en la lista
        public IActionResult OnGet(int editorialId)
        {
            editorial = repositorioEditoriales.GetEditorial(editorialId);
            if(editorial == null)
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
            if(editorial.id > 0)
            {
               repositorioEditoriales.DeleteEditorial(editorial.id);
            }
            return Page();
        }
    }
}
