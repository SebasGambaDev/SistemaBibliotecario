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
    public class ListEditorialesModel : PageModel
    {
        private readonly IRepositorioEditorial repositorioEditoriales;

        public IEnumerable<Editorial> editoriales {get;set;}

        public string searchString;
        
        public ListEditorialesModel(IRepositorioEditorial repositorioEditoriales)
        {
            this.repositorioEditoriales=repositorioEditoriales;
        }

        public void OnGet()
        {
            editoriales = repositorioEditoriales.GetAllEditoriales(searchString);
        }

        public IActionResult OnPost(string? searchString)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            editoriales = repositorioEditoriales.GetAllEditoriales(searchString);
            return Page();
        }
    }
}
