﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EvicenceMVC.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DCMDbContext : DbContext
    {
        public DCMDbContext()
            : base("name=DCMDbContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<EntryTest> EntryTests { get; set; }
        public virtual DbSet<TestEntry> TestEntries { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<TestType> TestTypes { get; set; }
    }
}
