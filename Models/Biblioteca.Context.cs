﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Biblioteca_Web.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BibliotecaEntities : DbContext
    {
        public BibliotecaEntities()
            : base("name=BibliotecaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Autor> Autors { get; set; }
        public DbSet<Libro> Libroes { get; set; }
        public DbSet<Prestamo> Prestamoes { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}