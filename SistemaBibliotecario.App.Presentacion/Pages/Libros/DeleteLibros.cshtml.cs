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
    public class DeleteLibrosModel : PageModel
    {
        private readonly IRepositorioLibro repositorioLibros;

        [BindProperty]
        public Libro libro  { get; set; } 

        public DeleteLibrosModel()
        {
            this.repositorioLibros = new RepositorioLibro(new SistemaBibliotecario.App.Persistencia.AppContext());
        }
     

        //se ejecuta al presionar Eliminar en la lista
        public IActionResult OnGet(int libroId)
        {
            libro = repositorioLibros.GetLibro(libroId);
            if(libro == null)
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
            if(libro.id > 0)
            {
               repositorioLibros.DeleteLibro(libro.id);
            }
            return Page();
        }
    }
}
