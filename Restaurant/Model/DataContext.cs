using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Model
{
    class DataContext : DbContext
    {
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Table> Tables { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Data Source = (localdb)\MSSQLLocalDB
            //Initial Catalog = Restaurant
            //Integrated Security = True
            //Connect Timeout = 30
            //Encrypt = False
            //TrustServerCertificate = False
            //ApplicationIntent = ReadWrite
            //MultiSubnetFailover = False

            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();

            sqlBuilder.DataSource = @"(localdb)\MSSQLLocalDB";
            sqlBuilder.InitialCatalog = "Restaurant";
            sqlBuilder.IntegratedSecurity = true;

            //optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Restaurant;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            optionsBuilder.UseSqlServer(sqlBuilder.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasIndex(user => user.Login)
                .IsUnique();
            modelBuilder.Entity<Table>()
                .HasIndex(table => table.Number)
                .IsUnique();
            modelBuilder.Entity<Meal>()
                .HasIndex(meal => meal.Name)
                .IsUnique();
            modelBuilder.Entity<Order>()
                .HasIndex(order => order.Number)
                .IsUnique();
        }
    }
}
