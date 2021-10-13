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
    public class ListModel : PageModel
    {
        

        /*
        public IEnumerable<Usuario> usuarios { get; set; }

        
        public ListModel()
        {
            usuarios =
                new List<Usuario>()
                {
                    new Usuario {
                        id = 1,
                        usu_identificacion = "102030",
                        usu_nombre = "Jhon Jairo Orozco"
                    },
                    new Usuario {
                        id = 1,
                        usu_identificacion = "102030",
                        usu_nombre = "Jhon Jairo Orozco"
                    }
                };
        }
        */

        private readonly IRepositorioUsuario repositorioUsuarios;

        public IEnumerable<Usuario> usuarios {get;set;}
        
        public ListModel(IRepositorioUsuario repositorioUsuarios)
        {
            this.repositorioUsuarios=repositorioUsuarios;
        }

        public void OnGet()
        {
            usuarios = repositorioUsuarios.GetAllUsuarios();
        }
    }
}
