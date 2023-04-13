using EntityFreameworkExample.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityFreameworkExample.DAL;
public class AppDbContext : DbContext
{

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<User>().ToTable("");

       // modelBuilder.Entity<User>().Property(x => x.Name).HasMaxLength(100);

       modelBuilder.Entity<addressInfo>().HasKey(x => x.UserId); 
       modelBuilder.Entity<addressInfo>().Property(x => x.UserId).ValueGeneratedOnAdd();

        modelBuilder.Entity<User>().HasOne(x => x.AddressInfo).WithOne(x => x.user);

        base.OnModelCreating(modelBuilder);
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<addressInfo> UserAddress { get; set; }
}