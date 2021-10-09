using System;
using Microsoft.EntityFrameworkCore;
using SistemaBibliotecario.App.Dominio.Entidades;


namespace SistemaBibliotecario.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Bibliotecario> Bibliotecarios { get; set; }
        public DbSet<Editorial> Editoriales { get; set; }
        public DbSet<Ejemplar> Ejemplares { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Server=localhost; Database=Default; user id=sa; password=Sebastian-0727; Initial Catalog = SistemaBibliotecario.Data");
            }
        }
    }
}