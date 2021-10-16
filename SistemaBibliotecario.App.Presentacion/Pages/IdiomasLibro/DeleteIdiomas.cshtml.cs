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
    public class DeleteIdiomasModel : PageModel
    {
        private readonly IRepositorioIdiomaLibro repositorioIdiomasLibro;

        [BindProperty]
        public IdiomaLibro idiomaLibro  { get; set; } 

        public DeleteIdiomasModel()
        {
            this.repositorioIdiomasLibro = new RepositorioIdiomaLibro(new SistemaBibliotecario.App.Persistencia.AppContext());
        }
     

        //se ejecuta al presionar Eliminar en la lista
        public IActionResult OnGet(int idiomaLibroId)
        {
            idiomaLibro = repositorioIdiomasLibro.GetIdiomaLibro(idiomaLibroId);
            if(idiomaLibro == null)
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
            if(idiomaLibro.id > 0)
            {
               repositorioIdiomasLibro.DeleteIdiomaLibro(idiomaLibro.id);
            }
            return Page();
        }
    }
}
