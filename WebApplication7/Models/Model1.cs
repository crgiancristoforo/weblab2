namespace WebApplication7.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<TB_Cliente> TB_Cliente { get; set; }
        public virtual DbSet<TB_Menu> TB_Menu { get; set; }
        public virtual DbSet<TB_MenuItem> TB_MenuItem { get; set; }
        public virtual DbSet<TB_Produto> TB_Produto { get; set; }
        public virtual DbSet<tb_teste> tb_teste { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TB_Cliente>()
                .Property(e => e.DS_Nome)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Menu>()
                .Property(e => e.Menu)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Menu>()
                .HasMany(e => e.TB_MenuItem)
                .WithRequired(e => e.TB_Menu)
                .HasForeignKey(e => e.IdMenu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_MenuItem>()
                .Property(e => e.MenuItem)
                .IsUnicode(false);

            modelBuilder.Entity<TB_MenuItem>()
                .Property(e => e.Rota)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Produto>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<tb_teste>()
                .Property(e => e.DS_Teste)
                .IsUnicode(false);
        }
    }
}
