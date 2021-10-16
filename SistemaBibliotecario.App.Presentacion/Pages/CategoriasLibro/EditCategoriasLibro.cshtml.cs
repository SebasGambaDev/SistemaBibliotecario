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
    public class EditCategoriasLibroModel : PageModel
    {
        private readonly IRepositorioCategoriaLibro repositorioCategoriasLibro;

        [BindProperty]
        public CategoriaLibro categoriaLibro  { get; set; } 

        public EditCategoriasLibroModel()
        {
            this.repositorioCategoriasLibro = new RepositorioCategoriaLibro(new SistemaBibliotecario.App.Persistencia.AppContext());
        }
     

        //se ejecuta al presionar Editar en la lista
        public IActionResult OnGet(int? categoriaLibroId)
        {
            if (categoriaLibroId.HasValue)
            {
                categoriaLibro = repositorioCategoriasLibro.GetCategoriaLibro(categoriaLibroId.Value);
            }
            else
            {
                categoriaLibro = new CategoriaLibro();
            }
            if (categoriaLibro == null)
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
            if(categoriaLibro.id > 0)
            {
               categoriaLibro = repositorioCategoriasLibro.UpdateCategoriaLibro(categoriaLibro);               
            }
            else
            {
               repositorioCategoriasLibro.AddCategoriaLibro(categoriaLibro);
            }
            return Page();
        }
    }
}
