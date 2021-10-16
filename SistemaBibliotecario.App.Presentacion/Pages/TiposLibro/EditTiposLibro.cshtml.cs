using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaBibliotecario.App.Persistencia.AppRepositorios;
using SistemaBibliotecario.App.Dominio.Entidades;


namespace SitemaBibliotecario.App.Presentacion
{
    public class EditTiposLibroModel : PageModel
    {
        private readonly IRepositorioTipoLibro repositorioTiposLibro;

        [BindProperty]
        public TipoLibro tipoLibro  { get; set; } 

        public EditTiposLibroModel()
        {
            this.repositorioTiposLibro = new RepositorioTipoLibro(new SistemaBibliotecario.App.Persistencia.AppContext());
        }
     

        //se ejecuta al presionar Editar en la lista
        public IActionResult OnGet(int? tipoLibroId)
        {
            if (tipoLibroId.HasValue)
            {
                tipoLibro = repositorioTiposLibro.GetTipoLibro(tipoLibroId.Value);
            }
            else
            {
                tipoLibro = new TipoLibro();
            }
            if (tipoLibro == null)
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
            if(tipoLibro.id > 0)
            {
               tipoLibro = repositorioTiposLibro.UpdateTipoLibro(tipoLibro);               
            }
            else
            {
               repositorioTiposLibro.AddTipoLibro(tipoLibro);
            }
            return Page();
        }
    }
}
