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
    public class DeleteCategoriasLibroModel : PageModel
    {
        private readonly IRepositorioCategoriaLibro repositorioCategoriasLibro;

        [BindProperty]
        public CategoriaLibro categoriaLibro  { get; set; } 

        public DeleteCategoriasLibroModel()
        {
            this.repositorioCategoriasLibro = new RepositorioCategoriaLibro(new SistemaBibliotecario.App.Persistencia.AppContext());
        }
     

        //se ejecuta al presionar Eliminar en la lista
        public IActionResult OnGet(int categoriaLibroId)
        {
            categoriaLibro = repositorioCategoriasLibro.GetCategoriaLibro(categoriaLibroId);
            if(categoriaLibro == null)
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
            if(categoriaLibro.id > 0)
            {
               repositorioCategoriasLibro.DeleteCategoriaLibro(categoriaLibro.id);
            }
            return Page();
        }
    }
}
