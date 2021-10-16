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

namespace SitemaBibliotecario.App.Presentacion
{
    public class ListIdiomasModel : PageModel
    {
        private readonly IRepositorioIdiomaLibro repositorioIdiomasLibro;

        public IEnumerable<IdiomaLibro> idiomasLibro {get;set;}

        public string searchString;
        
        public ListIdiomasModel(IRepositorioIdiomaLibro repositorioIdiomasLibro)
        {
            this.repositorioIdiomasLibro=repositorioIdiomasLibro;
        }

        public void OnGet()
        {
            idiomasLibro = repositorioIdiomasLibro.GetAllIdiomasLibro(searchString);
        }

        public IActionResult OnPost(string? searchString)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            idiomasLibro = repositorioIdiomasLibro.GetAllIdiomasLibro(searchString);
            return Page();
        }
    }
}
