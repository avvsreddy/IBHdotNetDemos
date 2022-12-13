using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DbFirstEFDemo.Models;

public partial class FancyProductsDb2022Context : DbContext
{
    public FancyProductsDb2022Context()
    {
    }

    public FancyProductsDb2022Context(DbContextOptions<FancyProductsDb2022Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Catagory> Catagories { get; set; }

    public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<TblProduct> TblProducts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=FancyProductsDB2022;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Catagory>(entity =>
        {
            entity.HasKey(e => e.CatagoryId).HasName("PK_dbo.Catagories");

            entity.Property(e => e.CatagoryId).HasColumnName("CatagoryID");
        });

        modelBuilder.Entity<MigrationHistory>(entity =>
        {
            entity.HasKey(e => new { e.MigrationId, e.ContextKey }).HasName("PK_dbo.__MigrationHistory");

            entity.ToTable("__MigrationHistory");

            entity.Property(e => e.MigrationId).HasMaxLength(150);
            entity.Property(e => e.ContextKey).HasMaxLength(300);
            entity.Property(e => e.ProductVersion).HasMaxLength(32);
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.SupplierId).HasName("PK_dbo.Suppliers");

            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            entity.Property(e => e.AddressArea).HasColumnName("Address_Area");
            entity.Property(e => e.AddressCity).HasColumnName("Address_City");
            entity.Property(e => e.AddressCountry).HasColumnName("Address_Country");
            entity.Property(e => e.AddressPincode).HasColumnName("Address_Pincode");

            entity.HasMany(d => d.ProductProducts).WithMany(p => p.SupplierSuppliers)
                .UsingEntity<Dictionary<string, object>>(
                    "SupplierProduct",
                    r => r.HasOne<TblProduct>().WithMany()
                        .HasForeignKey("ProductProductId")
                        .HasConstraintName("FK_dbo.SupplierProducts_dbo.tbl_products_Product_ProductID"),
                    l => l.HasOne<Supplier>().WithMany()
                        .HasForeignKey("SupplierSupplierId")
                        .HasConstraintName("FK_dbo.SupplierProducts_dbo.Suppliers_Supplier_SupplierID"),
                    j =>
                    {
                        j.HasKey("SupplierSupplierId", "ProductProductId").HasName("PK_dbo.SupplierProducts");
                        j.HasIndex(new[] { "ProductProductId" }, "IX_Product_ProductID");
                        j.HasIndex(new[] { "SupplierSupplierId" }, "IX_Supplier_SupplierID");
                    });
        });

        modelBuilder.Entity<TblProduct>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK_dbo.tbl_products");

            entity.ToTable("tbl_products");

            entity.HasIndex(e => e.CatagoryCatagoryId, "IX_Catagory_CatagoryID");

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.CatagoryCatagoryId).HasColumnName("Catagory_CatagoryID");
            entity.Property(e => e.ProductName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("product_name");

            entity.HasOne(d => d.CatagoryCatagory).WithMany(p => p.TblProducts)
                .HasForeignKey(d => d.CatagoryCatagoryId)
                .HasConstraintName("FK_dbo.tbl_products_dbo.Catagories_Catagory_CatagoryID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
