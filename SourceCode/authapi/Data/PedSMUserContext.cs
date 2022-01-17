using authapi.Data.Entities;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace authapi.Data
{
    public partial class PedSMUserContext : DbContext
    {
        public PedSMUserContext()
        {
        }

        public PedSMUserContext(DbContextOptions<PedSMUserContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserLog> UserLogs { get; set; }
        public virtual DbSet<UserLogType> UserLogTypes { get; set; }
        public virtual DbSet<UserNotice> UserNotices { get; set; }
        public virtual DbSet<UserRecover> UserRecovers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Iduser)
                    .HasName("PK__Users__EAE6D9DF44C4C022");

                entity.Property(e => e.Iduser).HasColumnName("IDUser");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserLog>(entity =>
            {
                entity.HasKey(e => e.IduserLog)
                    .HasName("PK__UserLogs__B44C2F8F6BF09008");

                entity.Property(e => e.IduserLog).HasColumnName("IDUserLog");

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserLogTypesId).HasColumnName("UserLogTypesID");
            });

            modelBuilder.Entity<UserLogType>(entity =>
            {
                entity.HasKey(e => e.IduserLogType)
                    .HasName("PK__UserLogT__3FA70B24441BEB0F");

                entity.Property(e => e.IduserLogType).HasColumnName("IDUserLogType");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserNotice>(entity =>
            {
                entity.HasKey(e => e.IduserNotice)
                    .HasName("PK__UserNoti__860EA235A3B659A7");

                entity.Property(e => e.IduserNotice).HasColumnName("IDUserNotice");

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<UserRecover>(entity =>
            {
                entity.HasKey(e => e.IduserRecover)
                    .HasName("PK__UserReco__E98741A786C30AA9");

                entity.Property(e => e.IduserRecover).HasColumnName("IDUserRecover");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
