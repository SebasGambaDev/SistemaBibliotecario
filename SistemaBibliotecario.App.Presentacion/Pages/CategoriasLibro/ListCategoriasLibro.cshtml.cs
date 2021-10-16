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
    public class ListCategoriasLibroModel : PageModel
    {
        private readonly IRepositorioCategoriaLibro repositorioCategoriasLibro;

        public IEnumerable<CategoriaLibro> categoriasLibro {get;set;}

        public string searchString;
        
        public ListCategoriasLibroModel(IRepositorioCategoriaLibro repositorioCategoriasLibro)
        {
            this.repositorioCategoriasLibro=repositorioCategoriasLibro;
        }

        public void OnGet()
        {
            categoriasLibro = repositorioCategoriasLibro.GetAllCategoriasLibro(searchString);
        }

        public IActionResult OnPost(string? searchString)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            categoriasLibro = repositorioCategoriasLibro.GetAllCategoriasLibro(searchString);
            return Page();
        }
    }
}
