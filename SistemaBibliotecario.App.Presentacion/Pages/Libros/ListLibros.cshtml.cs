using System.Runtime.CompilerServices;
using System.Globalization;
using System.Collections;
using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaBibliotecario.App.Dominio.Entidades;
using SistemaBibliotecario.App.Persistencia.AppRepositorios;
using SistemaBibliotecario.App.Persistencia;

namespace SitemaBibliotecario.App.Presentacion.Pages
{
    public class ListLibrosModel : PageModel
    {
        private readonly IRepositorioLibro repositorioLibros;

        public IEnumerable<Libro> libros {get;set;}

        public string searchString;
        
        public ListLibrosModel(IRepositorioLibro repositorioLibros)
        {
            this.repositorioLibros=repositorioLibros;
        }

        public void OnGet()
        {
            libros = repositorioLibros.GetAllLibros(searchString);
        }

        public IActionResult OnPost(string? searchString)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            libros = repositorioLibros.GetAllLibros(searchString);
            return Page();
        }
    }
}
