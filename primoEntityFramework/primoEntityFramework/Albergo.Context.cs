﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace primoEntityFramework
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AlbergoEntities : DbContext
    {
        public AlbergoEntities()
            : base("name=AlbergoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Camere> Camere { get; set; }
        public virtual DbSet<Clienti> Clienti { get; set; }
        public virtual DbSet<Prenotazioni> Prenotazioni { get; set; }
        public virtual DbSet<supplementi> supplementi { get; set; }
        public virtual DbSet<Prezzi> Prezzi { get; set; }
        public virtual DbSet<Supplementi_prenotati> Supplementi_prenotati { get; set; }
    }
}
