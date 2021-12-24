using authapi.Models;
using Microsoft.EntityFrameworkCore;

namespace authapi.Data
{
    public class AuthAPIDbContext : DbContext
    {
        public AuthAPIDbContext(DbContextOptions op) : base(op)
        {
            
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var users = modelBuilder.Entity<User>();
            
            users.ToTable("Users");
            users.Property(u => u.UserId).HasColumnName("user_id");
            users.Property(u => u.Username).HasColumnName("username");
            users.Property(u => u.Password).HasColumnName("password");
            users.Property(u => u.Email).HasColumnName("email");
            users.Property(u => u.Register).HasColumnName("register_date");
            users.Property(u => u.Active).HasColumnName("active");
        }
    }
}