﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BLUEBOOK
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BlueBookEntities : DbContext
    {
        public BlueBookEntities()
            : base("name=BlueBookEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Authors> Authors { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Publishers> Publishers { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Invoices> Invoices { get; set; }
        public DbSet<InvoicesDetails> InvoicesDetails { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrdersDetails> OrdersDetails { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<Stocks> Stocks { get; set; }
        public DbSet<Stores> Stores { get; set; }
    }
}
