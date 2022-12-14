using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ZH_ASWYGE.Models;

public partial class WebshopContext : DbContext
{
    public WebshopContext()
    {
    }

    public WebshopContext(DbContextOptions<WebshopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Raktar> Raktar { get; set; }

    public virtual DbSet<Rendeles> Rendeles { get; set; }

    public virtual DbSet<RendelesTetel> RendelesTetel { get; set; }

    public virtual DbSet<Termek> Termek { get; set; }

    public virtual DbSet<Termekkategoria> Termekkategoria { get; set; }

    public virtual DbSet<Ugyfel> Ugyfel { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\aswyge\\Downloads\\ZH_ASWYGE\\ZH_ASWYGE\\Webshopdb.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Raktar>(entity =>
        {
            entity.HasKey(e => e.RaktarKod);

            entity.HasIndex(e => e.RaktarKod, "IX_Raktar").IsUnique();

            entity.Property(e => e.RaktarKod)
                .ValueGeneratedNever()
                .HasColumnName("RAKTAR_KOD");
            entity.Property(e => e.RaktarCim)
                .HasMaxLength(255)
                .HasColumnName("RAKTAR_CIM");
            entity.Property(e => e.RaktarNev)
                .HasMaxLength(255)
                .HasColumnName("RAKTAR_NEV");
        });

        modelBuilder.Entity<Rendeles>(entity =>
        {
            entity.HasKey(e => e.Sorszam);

            entity.Property(e => e.Sorszam)
                .ValueGeneratedNever()
                .HasColumnName("SORSZAM");
            entity.Property(e => e.FizMod)
                .HasMaxLength(255)
                .HasColumnName("FIZ_MOD");
            entity.Property(e => e.Login)
                .HasMaxLength(255)
                .HasColumnName("LOGIN");
            entity.Property(e => e.RendDatum)
                .HasColumnType("date")
                .HasColumnName("REND_DATUM");
            entity.Property(e => e.SzallCim)
                .HasMaxLength(255)
                .HasColumnName("SZALL_CIM");
            entity.Property(e => e.SzallDatum)
                .HasColumnType("date")
                .HasColumnName("SZALL_DATUM");
            entity.Property(e => e.SzallMod)
                .HasMaxLength(255)
                .HasColumnName("SZALL_MOD");
            entity.Property(e => e.SzamlaCim)
                .HasMaxLength(255)
                .HasColumnName("SZAMLA_CIM");

            entity.HasOne(d => d.LoginNavigation).WithMany(p => p.Rendeles)
                .HasForeignKey(d => d.Login)
                .HasConstraintName("FK_Rendeles_Ugyfel");
        });

        modelBuilder.Entity<RendelesTetel>(entity =>
        {
            entity.HasKey(e => new { e.Sorszam, e.Termekkod });

            entity.ToTable("Rendeles_tetel");

            entity.Property(e => e.Sorszam).HasColumnName("SORSZAM");
            entity.Property(e => e.Termekkod)
                .HasMaxLength(255)
                .HasColumnName("TERMEKKOD");
            entity.Property(e => e.Egysegar).HasColumnName("EGYSEGAR");
            entity.Property(e => e.Mennyiseg).HasColumnName("MENNYISEG");

            entity.HasOne(d => d.SorszamNavigation).WithMany(p => p.RendelesTetel)
                .HasForeignKey(d => d.Sorszam)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rendeles_tetel_Rendeles");

            entity.HasOne(d => d.TermekkodNavigation).WithMany(p => p.RendelesTetel)
                .HasForeignKey(d => d.Termekkod)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rendeles_tetel_Termek");
        });

        modelBuilder.Entity<Termek>(entity =>
        {
            entity.HasKey(e => e.Termekkod);

            entity.Property(e => e.Termekkod)
                .HasMaxLength(255)
                .HasColumnName("TERMEKKOD");
            entity.Property(e => e.Felvitel)
                .HasColumnType("date")
                .HasColumnName("FELVITEL");
            entity.Property(e => e.Felvitte)
                .HasMaxLength(255)
                .HasColumnName("FELVITTE");
            entity.Property(e => e.KatId).HasColumnName("KAT_ID");
            entity.Property(e => e.Keszlet).HasColumnName("KESZLET");
            entity.Property(e => e.Leiras)
                .HasMaxLength(255)
                .HasColumnName("LEIRAS");
            entity.Property(e => e.Listaar).HasColumnName("LISTAAR");
            entity.Property(e => e.Megnevezes)
                .HasMaxLength(255)
                .HasColumnName("MEGNEVEZES");
            entity.Property(e => e.Megys)
                .HasMaxLength(255)
                .HasColumnName("MEGYS");
            entity.Property(e => e.RaktarKod).HasColumnName("RAKTAR_KOD");

            entity.HasOne(d => d.Kat).WithMany(p => p.Termek)
                .HasForeignKey(d => d.KatId)
                .HasConstraintName("FK_Termek_Termekkategoria");

            entity.HasOne(d => d.RaktarKodNavigation).WithMany(p => p.Termek)
                .HasForeignKey(d => d.RaktarKod)
                .HasConstraintName("FK_Termek_Raktar");
        });

        modelBuilder.Entity<Termekkategoria>(entity =>
        {
            entity.HasKey(e => e.KatId);

            entity.HasIndex(e => e.KatNev, "utk").IsUnique();

            entity.Property(e => e.KatId)
                .ValueGeneratedNever()
                .HasColumnName("KAT_ID");
            entity.Property(e => e.KatNev)
                .HasMaxLength(255)
                .HasColumnName("KAT_NEV");
            entity.Property(e => e.SzuloKat).HasColumnName("SZULO_KAT");

            entity.HasOne(d => d.SzuloKatNavigation).WithMany(p => p.InverseSzuloKatNavigation)
                .HasForeignKey(d => d.SzuloKat)
                .HasConstraintName("FK_Termekkategoria_Termekkategoria");
        });

        modelBuilder.Entity<Ugyfel>(entity =>
        {
            entity.HasKey(e => e.Login);

            entity.Property(e => e.Login)
                .HasMaxLength(255)
                .HasColumnName("LOGIN");
            entity.Property(e => e.Cim)
                .HasMaxLength(255)
                .HasColumnName("CIM");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Nem)
                .HasMaxLength(1)
                .HasColumnName("NEM");
            entity.Property(e => e.Nev)
                .HasMaxLength(255)
                .HasColumnName("NEV");
            entity.Property(e => e.Szulev).HasColumnName("SZULEV");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
