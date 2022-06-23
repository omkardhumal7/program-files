using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EcommerceAPI.Models
{
    public partial class EcommerceDBContext : DbContext
    {
        public EcommerceDBContext()
        {
        }

        public EcommerceDBContext(DbContextOptions<EcommerceDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdminTable> AdminTables { get; set; }
        public virtual DbSet<LoginTable> LoginTables { get; set; }
        public virtual DbSet<ProductTable> ProductTables { get; set; }
        public virtual DbSet<UserTable> UserTables { get; set; }
        public object LoginTable { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-BN215B2;Initial Catalog=EcommerceDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AdminTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AdminTable");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.AdminName).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);
            });

            modelBuilder.Entity<LoginTable>(entity =>
            {
                entity.ToTable("LoginTable");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsAdmin)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<ProductTable>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("ProductTable");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductPrice).HasColumnType("money");
            });

            modelBuilder.Entity<UserTable>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("UserTable");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
