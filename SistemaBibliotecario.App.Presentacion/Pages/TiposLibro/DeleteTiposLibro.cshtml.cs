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
    public class DeleteTiposLibroModel : PageModel
    {
        private readonly IRepositorioTipoLibro repositorioTiposLibro;

        [BindProperty]
        public TipoLibro tipoLibro  { get; set; } 

        public DeleteTiposLibroModel()
        {
            this.repositorioTiposLibro = new RepositorioTipoLibro(new SistemaBibliotecario.App.Persistencia.AppContext());
        }
     

        //se ejecuta al presionar Eliminar en la lista
        public IActionResult OnGet(int tipoLibroId)
        {
            tipoLibro = repositorioTiposLibro.GetTipoLibro(tipoLibroId);
            if(tipoLibro == null)
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
            if(tipoLibro.id > 0)
            {
               repositorioTiposLibro.DeleteTipoLibro(tipoLibro.id);
            }
            return Page();
        }
    }
}
