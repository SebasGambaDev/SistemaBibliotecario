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
    public class ListAutoresModel : PageModel
    {
        private readonly IRepositorioAutor repositorioAutores;

        public IEnumerable<Autor> autores {get;set;}

        public string searchString;
        
        public ListAutoresModel(IRepositorioAutor repositorioAutores)
        {
            this.repositorioAutores=repositorioAutores;
        }

        public void OnGet()
        {
            autores = repositorioAutores.GetAllAutores(searchString);
        }

        public IActionResult OnPost(string? searchString)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            autores = repositorioAutores.GetAllAutores(searchString);
            return Page();
        }
        
    }
}
