﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APIEMECI.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EmeciEntities : DbContext
    {
        public EmeciEntities()
            : base("name=EmeciEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<DatosTarjeta> DatosTarjeta { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Registro> Registro { get; set; }
    }
}