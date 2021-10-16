using System.Collections;
using System;
using System.Collections.Generic;
using SistemaBibliotecario.App.Dominio.Entidades;
using System.Linq;
using SistemaBibliotecario.App.Dominio;


namespace SistemaBibliotecario.App.Persistencia.AppRepositorios
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        private readonly AppContext _appContext;

        public IEnumerable<Usuario> usuarios {get;set;}

        public RepositorioUsuario(AppContext appContext)
        {
            _appContext = appContext;
        }

        //Llamar la lista de usuarios
        IEnumerable<Usuario> IRepositorioUsuario.GetAllUsuarios(string? nombre)
        {
            if (nombre != null) {
              usuarios = _appContext.Usuarios.Where(p => p.usu_nombre.Contains(nombre)); //like sobre la tabla
            }
            else 
               usuarios = _appContext.Usuarios;  //select * from usuario
            return usuarios;
        }

        //Adicionar Usuario
        Usuario IRepositorioUsuario.AddUsuario(Usuario usuario)
        {
            var UsuarioAdicionado = _appContext.Usuarios.Add(usuario);
            _appContext.SaveChanges();
            return UsuarioAdicionado.Entity;
        }

        //Actualizar usuario
        Usuario IRepositorioUsuario.UpdateUsuario(Usuario usuario)
        {
            var UsuarioEncontrado = _appContext.Usuarios.FirstOrDefault(p => p.id == usuario.id);
            if (UsuarioEncontrado != null)
            {
                UsuarioEncontrado.usu_identificacion = usuario.usu_identificacion;
                UsuarioEncontrado.usu_nombre = usuario.usu_nombre;
                UsuarioEncontrado.usu_apellido = usuario.usu_apellido;
                UsuarioEncontrado.usu_telefono = usuario.usu_telefono;
                UsuarioEncontrado.usu_direccion = usuario.usu_direccion;
                UsuarioEncontrado.usu_email = usuario.usu_email;
                _appContext.SaveChanges();
            }
            return UsuarioEncontrado;
        }

        //Eliminar usuario
        void IRepositorioUsuario.DeleteUsuario(int id)
        {
            var UsuarioEncontrado = _appContext.Usuarios.FirstOrDefault(p => p.id == id);
            if (UsuarioEncontrado == null)
                return;
            _appContext.Usuarios.Remove(UsuarioEncontrado);
            _appContext.SaveChanges();
        }

        //Mostrar detalle usuario
        Usuario IRepositorioUsuario.GetUsuario(int id)
        {
            return _appContext.Usuarios.FirstOrDefault(p => p.id == id);
        }
    }
}