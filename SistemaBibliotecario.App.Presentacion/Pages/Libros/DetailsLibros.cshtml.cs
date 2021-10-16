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
    public class DetailsLibrosModel : PageModel
    {
        private readonly IRepositorioLibro repositorioLibros;
        public Libro libro { get; set; }

        public DetailsLibrosModel()
        {
            this.repositorioLibros = new RepositorioLibro(new SistemaBibliotecario.App.Persistencia.AppContext());
        }

        public IActionResult OnGet(int libroId)
        {
            libro = repositorioLibros.GetLibro(libroId);
            if(libro==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
        }
    }
}
