using Entities;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Context;

public class BaseDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(@"Server=(localdb)\eren; Database=PermissionManagement; Trusted_Connection=True;");
        base.OnConfiguring(options);
    }
    public DbSet<User> Users { get; set; }
    public DbSet<OperationClaim> OperationClaims { get; set; }
    public DbSet<UserOperationClaim> UserOperationClaims { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().ToTable("Users");
        //modelBuilder.Entity<UserOperationClaim>();
        base.OnModelCreating(modelBuilder);
    }
}
