using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaBibliotecario.App.Persistencia.AppRepositorios;
using SistemaBibliotecario.App.Dominio.Entidades;

namespace SitemaBibliotecario.App.Presentacion.Pages
{
    public class EditEditorialesModel : PageModel
    {
        private readonly IRepositorioEditorial repositorioEditoriales;

        [BindProperty]
        public Editorial editorial  { get; set; } 

        public EditEditorialesModel()
        {
            this.repositorioEditoriales = new RepositorioEditorial(new SistemaBibliotecario.App.Persistencia.AppContext());
        }
     

        //se ejecuta al presionar Editar en la lista
        public IActionResult OnGet(int? editorialId)
        {
            if (editorialId.HasValue)
            {
                editorial = repositorioEditoriales.GetEditorial(editorialId.Value);
            }
            else
            {
                editorial = new Editorial();
            }
            if (editorial == null)
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
            if(editorial.id > 0)
            {
               editorial = repositorioEditoriales.UpdateEditorial(editorial);               
            }
            else
            {
               repositorioEditoriales.AddEditorial(editorial);
            }
            return Page();
        }
    }
}
