﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace jfEjercicioDBFirst.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CancionesLocalDBEntities : DbContext
    {
        public CancionesLocalDBEntities()
            : base("name=CancionesLocalDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Albums> Albums { get; set; }
        public virtual DbSet<Artistas> Artistas { get; set; }
        public virtual DbSet<Canciones> Canciones { get; set; }
    }
}
