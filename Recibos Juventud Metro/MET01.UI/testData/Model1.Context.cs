﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MET01.UI.testData
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<MET01_ENCARGADO> MET01_ENCARGADO { get; set; }
        public DbSet<MET01_EVENTO> MET01_EVENTO { get; set; }
        public DbSet<MET01_IGLESIA> MET01_IGLESIA { get; set; }
        public DbSet<MET01_PASTOR> MET01_PASTOR { get; set; }
        public DbSet<MET01_REGION> MET01_REGION { get; set; }
    }
}
