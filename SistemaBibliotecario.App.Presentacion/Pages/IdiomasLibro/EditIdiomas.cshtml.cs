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
    public class EditIdiomasModel : PageModel
    {
        private readonly IRepositorioIdiomaLibro repositorioIdiomasLibro;

        [BindProperty]
        public IdiomaLibro idiomaLibro  { get; set; } 

        public EditIdiomasModel()
        {
            this.repositorioIdiomasLibro = new RepositorioIdiomaLibro(new SistemaBibliotecario.App.Persistencia.AppContext());
        }
     

        //se ejecuta al presionar Editar en la lista
        public IActionResult OnGet(int? idiomaLibroId)
        {
            if (idiomaLibroId.HasValue)
            {
                idiomaLibro = repositorioIdiomasLibro.GetIdiomaLibro(idiomaLibroId.Value);
            }
            else
            {
                idiomaLibro = new IdiomaLibro();
            }
            if (idiomaLibro == null)
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
            if(idiomaLibro.id > 0)
            {
               idiomaLibro = repositorioIdiomasLibro.UpdateIdiomaLibro(idiomaLibro);               
            }
            else
            {
               repositorioIdiomasLibro.AddIdiomaLibro(idiomaLibro);
            }
            return Page();
        }
    }
}
