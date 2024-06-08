using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Context;

public class PermissionManagementContext: DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(@"Server:(localdb)\eren; Database:PermissionManagement; Trusted_Connection:true;");
        base.OnConfiguring(options);
    }

    DbSet<User> Users { get; set; }
    DbSet<OperationClaim> OperationClaims { get; set; }
    DbSet<UserOperationClaim> UserOperationClaim { get; set; }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().ToTable("Users");
        modelBuilder.Entity<User>().HasOne(i => i.OperationClaim);
        modelBuilder.Entity<User>().Property(i => i.Username).HasColumnName("Username").HasMaxLength(20);

        base.OnModelCreating(modelBuilder);


        //modelBuilder.Entity<Product>().ToTable("Products");
        //modelBuilder.Entity<Product>().HasOne(i => i.Category);
        //modelBuilder.Entity<Product>().Property(i => i.Name).HasColumnName("Name").HasMaxLength(50);

        //// Seed Data

        //Category category = new Category(1, "Giyim");
        //Category category1 = new(2, "Elektronik");

        //Product product = new Product(1, "Kazak", 500, 50, 1);

        //modelBuilder.Entity<Category>().HasData(category, category1);
        //modelBuilder.Entity<Product>().HasData(product);

        //base.OnModelCreating(modelBuilder);
    }
}
