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
    public class EditLibrosModel : PageModel
    {
        private readonly IRepositorioLibro repositorioLibros;
        private readonly IRepositorioAutor repositorioAutores;
        private readonly IRepositorioEditorial repositorioEditoriales;
        private readonly IRepositorioCategoriaLibro repositorioCategoriasLibro;
        private readonly IRepositorioIdiomaLibro repositorioIdiomasLibro;
        private readonly IRepositorioTipoLibro repositorioTiposLibro;

        [BindProperty]
        public Libro libro  { get; set; } 
        public IEnumerable<IdiomaLibro> idiomasLibro {get;set;}
        public IEnumerable<TipoLibro> tiposLibro {get;set;}
        public IEnumerable<CategoriaLibro> categoriasLibro {get; set;}
        public IEnumerable<Autor> autores {get; set;} 
        public IEnumerable<Editorial> editoriales {get; set;} 
        public string searchString;
        public string searchAutor;
        public string searchEditorial;
        public string searchCategoriaLibro;
        public string searchTipoLibro;
        public string searchIdiomaLibro;

        public EditLibrosModel()
        {
            this.repositorioLibros = new RepositorioLibro(new SistemaBibliotecario.App.Persistencia.AppContext());
            this.repositorioAutores = new RepositorioAutor(new SistemaBibliotecario.App.Persistencia.AppContext());
            this.repositorioEditoriales = new RepositorioEditorial(new SistemaBibliotecario.App.Persistencia.AppContext());
            this.repositorioCategoriasLibro = new RepositorioCategoriaLibro(new SistemaBibliotecario.App.Persistencia.AppContext());
            this.repositorioIdiomasLibro = new RepositorioIdiomaLibro(new SistemaBibliotecario.App.Persistencia.AppContext());
            this.repositorioTiposLibro = new RepositorioTipoLibro(new SistemaBibliotecario.App.Persistencia.AppContext());
        }
     

        //se ejecuta al presionar Editar en la lista
        public IActionResult OnGet(int? libroId)
        {
            tiposLibro = repositorioTiposLibro.GetAllTiposLibro(searchIdiomaLibro);
            idiomasLibro = repositorioIdiomasLibro.GetAllIdiomasLibro(searchIdiomaLibro);
            categoriasLibro = repositorioCategoriasLibro.GetAllCategoriasLibro(searchCategoriaLibro);
            autores = repositorioAutores.GetAllAutores(searchAutor);
            editoriales = repositorioEditoriales.GetAllEditoriales(searchEditorial);
            if (libroId.HasValue)
            {
                libro = repositorioLibros.GetLibro(libroId.Value);
                
            }
            else
            {
                libro = new Libro(); 
            }

            if (libro == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        }

        //se ejecuta al presionar Editar en el formulario
        public IActionResult OnPost()
        {
            tiposLibro = repositorioTiposLibro.GetAllTiposLibro(searchIdiomaLibro);
            idiomasLibro = repositorioIdiomasLibro.GetAllIdiomasLibro(searchIdiomaLibro);
            categoriasLibro = repositorioCategoriasLibro.GetAllCategoriasLibro(searchCategoriaLibro);
            autores = repositorioAutores.GetAllAutores(searchAutor);
            editoriales = repositorioEditoriales.GetAllEditoriales(searchEditorial);
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if(libro.id > 0)
            {
                libro = repositorioLibros.UpdateLibro( libro );   
                   
            }
            else
            {
               repositorioLibros.AddLibro( libro );
            }
            return Page();
        }
    }
}
