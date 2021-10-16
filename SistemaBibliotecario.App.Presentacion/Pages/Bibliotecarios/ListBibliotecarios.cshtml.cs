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

namespace SistemaBibliotecario.App.Presentacion.Pages
{
    public class ListBibliotecariosModel : PageModel
    {
private readonly IRepositorioBibliotecario repositorioBibliotecarios;

        public IEnumerable<Bibliotecario> bibliotecarios {get;set;}
        
        public ListBibliotecariosModel(IRepositorioBibliotecario repositorioBibliotecarios)
        {
            this.repositorioBibliotecarios=repositorioBibliotecarios;
        }

        public void OnGet()
        {
            bibliotecarios = repositorioBibliotecarios.GetAllBibliotecarios();
        }
    }
}
