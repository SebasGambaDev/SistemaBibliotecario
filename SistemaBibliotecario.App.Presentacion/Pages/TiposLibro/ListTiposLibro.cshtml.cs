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
    public class ListTiposLibroModel : PageModel
    {
        private readonly IRepositorioTipoLibro repositorioTiposLibro;

        public IEnumerable<TipoLibro> tiposLibro {get;set;}

        public string searchString;
        
        public ListTiposLibroModel(IRepositorioTipoLibro repositorioTiposLibro)
        {
            this.repositorioTiposLibro=repositorioTiposLibro;
        }

        public void OnGet()
        {
            tiposLibro = repositorioTiposLibro.GetAllTiposLibro(searchString);
        }

        public IActionResult OnPost(string? searchString)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            tiposLibro = repositorioTiposLibro.GetAllTiposLibro(searchString);
            return Page();
        }
    }
}
