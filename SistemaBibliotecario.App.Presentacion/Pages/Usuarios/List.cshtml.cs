using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaBibliotecario.App.Dominio.Entidades;

namespace SistemaBibliotecario.App.Presentacion.Pages
{
    public class ListModel : PageModel
    {
        public string prueba = "Hola estoy probando";


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

        public void OnGet()
        {
        }
    }
}
