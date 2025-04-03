using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProductsApp.Models;

public partial class PartnersContext : DbContext {
	public PartnersContext() {
	}

	public PartnersContext(DbContextOptions<PartnersContext> options)
		: base(options) {
	}

	public virtual DbSet<Material> Materials { get; set; }

	public virtual DbSet<MaterialDelivery> MaterialDeliveries { get; set; }

	public virtual DbSet<MaterialType> MaterialTypes { get; set; }

	public virtual DbSet<MaterialsProduct> MaterialsProducts { get; set; }

	public virtual DbSet<OrganizationType> OrganizationTypes { get; set; }

	public virtual DbSet<Partner> Partners { get; set; }

	public virtual DbSet<PartnersProduct> PartnersProducts { get; set; }

	public virtual DbSet<Product> Products { get; set; }

	public virtual DbSet<ProductType> ProductTypes { get; set; }

	public virtual DbSet<Supplier> Suppliers { get; set; }

	public virtual DbSet<UnitsOfMeasurement> UnitsOfMeasurements { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
		=> optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=partners;Username=postgres;Password=1111");

	protected override void OnModelCreating(ModelBuilder modelBuilder) {
		modelBuilder.Entity<Material>(entity => {
			entity.HasKey(e => e.Id).HasName("Materials_pkey");

			entity.Property(e => e.Id).HasColumnName("id");
			entity.Property(e => e.Description).HasColumnName("description");
			entity.Property(e => e.IdOfUnit).HasColumnName("idOfUnit");
			entity.Property(e => e.IdType).HasColumnName("idType");
			entity.Property(e => e.Image).HasColumnName("image");
			entity.Property(e => e.NameOfMaterial).HasColumnName("nameOfMaterial");

			entity.HasOne(d => d.IdOfUnitNavigation).WithMany(p => p.Materials)
				.HasForeignKey(d => d.IdOfUnit)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_materials_units");

			entity.HasOne(d => d.IdTypeNavigation).WithMany(p => p.Materials)
				.HasForeignKey(d => d.IdType)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_materials_types");
		});

		modelBuilder.Entity<MaterialDelivery>(entity => {
			entity.HasKey(e => e.Id).HasName("MaterialDeliveries_pkey");

			entity.Property(e => e.Id).HasColumnName("id");
			entity.Property(e => e.AmountInPackage).HasColumnName("amountInPackage");
			entity.Property(e => e.DateOfDelivery).HasColumnName("dateOfDelivery");
			entity.Property(e => e.IdOfMaterial).HasColumnName("idOfMaterial");
			entity.Property(e => e.IdOfSupplier).HasColumnName("idOfSupplier");
			entity.Property(e => e.PackageCount).HasColumnName("packageCount");
			entity.Property(e => e.PriceForPackage).HasColumnName("priceForPackage");
			entity.Property(e => e.QualityOfDelivery).HasColumnName("qualityOfDelivery");

			entity.HasOne(d => d.IdOfMaterialNavigation).WithMany(p => p.MaterialDeliveries)
				.HasForeignKey(d => d.IdOfMaterial)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_materialDeliveries_materials");

			entity.HasOne(d => d.IdOfSupplierNavigation).WithMany(p => p.MaterialDeliveries)
				.HasForeignKey(d => d.IdOfSupplier)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_materialDeliveries_suppliers");
		});

		modelBuilder.Entity<MaterialType>(entity => {
			entity.HasKey(e => e.Id).HasName("MaterialTypes_pkey");

			entity.Property(e => e.Id).HasColumnName("id");
			entity.Property(e => e.DefectRate).HasColumnName("defectRate");
			entity.Property(e => e.Type).HasColumnName("type");
		});

		modelBuilder.Entity<MaterialsProduct>(entity => {
			entity.HasKey(e => e.Id).HasName("materials_products_pkey");

			entity.ToTable("materials_products");

			entity.Property(e => e.Id).HasColumnName("id");
			entity.Property(e => e.IdMaterial).HasColumnName("idMaterial");
			entity.Property(e => e.IdProduct).HasColumnName("idProduct");
			entity.Property(e => e.MaterialAmount)
				.HasDefaultValueSql("1")
				.HasColumnName("materialAmount");

			entity.HasOne(d => d.IdMaterialNavigation).WithMany(p => p.MaterialsProducts)
				.HasForeignKey(d => d.IdMaterial)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_materials_materials_products");

			entity.HasOne(d => d.IdProductNavigation).WithMany(p => p.MaterialsProducts)
				.HasForeignKey(d => d.IdProduct)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_products_materials_products");
		});

		modelBuilder.Entity<OrganizationType>(entity => {
			entity.HasKey(e => e.Id).HasName("pk_partnerTypes");

			entity.Property(e => e.Id)
				.UseIdentityAlwaysColumn()
				.HasColumnName("id");
			entity.Property(e => e.TypeOfPartner).HasColumnName("typeOfPartner");
		});

		modelBuilder.Entity<Partner>(entity => {
			entity.HasKey(e => e.Id).HasName("pk_partners");

			entity.Property(e => e.Id)
				.UseIdentityAlwaysColumn()
				.HasColumnName("id");
			entity.Property(e => e.Email).HasColumnName("email");
			entity.Property(e => e.FullNameOfCeo).HasColumnName("fullNameOfCeo");
			entity.Property(e => e.IdPartnerType).HasColumnName("idPartnerType");
			entity.Property(e => e.Inn).HasColumnName("INN");
			entity.Property(e => e.LegalAdress).HasColumnName("legalAdress");
			entity.Property(e => e.NameOfPartner).HasColumnName("nameOfPartner");
			entity.Property(e => e.PhoneNumber).HasColumnName("phoneNumber");
			entity.Property(e => e.Rating).HasColumnName("rating");

			entity.HasOne(d => d.IdPartnerTypeNavigation).WithMany(p => p.Partners)
				.HasForeignKey(d => d.IdPartnerType)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_partners_organizationTypes");
		});

		modelBuilder.Entity<PartnersProduct>(entity => {
			entity.HasKey(e => e.Id).HasName("pk_partners_products");

			entity.ToTable("Partners_Products");

			entity.Property(e => e.Id)
				.UseIdentityAlwaysColumn()
				.HasColumnName("id");
			entity.Property(e => e.Amount).HasColumnName("amount");
			entity.Property(e => e.IdOfPartner).HasColumnName("idOfPartner");
			entity.Property(e => e.IdOfProduct).HasColumnName("idOfProduct");
			entity.Property(e => e.SaleDate).HasColumnName("saleDate");

			entity.HasOne(d => d.IdOfPartnerNavigation).WithMany(p => p.PartnersProducts)
				.HasForeignKey(d => d.IdOfPartner)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_partnersProducts_partners");

			entity.HasOne(d => d.IdOfProductNavigation).WithMany(p => p.PartnersProducts)
				.HasForeignKey(d => d.IdOfProduct)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_partnersProducts_products");
		});

		modelBuilder.Entity<Product>(entity => {
			entity.HasKey(e => e.Id).HasName("pk_products");

			entity.Property(e => e.Id)
				.UseIdentityAlwaysColumn()
				.HasColumnName("id");
			entity.Property(e => e.Article).HasColumnName("article");
			entity.Property(e => e.Certificate).HasColumnName("certificate");
			entity.Property(e => e.Description).HasColumnName("description");
			entity.Property(e => e.HeightPackage).HasColumnName("heightPackage");
			entity.Property(e => e.IdProductType).HasColumnName("idProductType");
			entity.Property(e => e.Image).HasColumnName("image");
			entity.Property(e => e.LengthPackage).HasColumnName("lengthPackage");
			entity.Property(e => e.NameOfProduct).HasColumnName("nameOfProduct");
			entity.Property(e => e.NumberStandart)
				.HasDefaultValueSql("'ГОСТ 000-0-00'::text")
				.HasColumnName("numberStandart");
			entity.Property(e => e.PriceMin)
				.HasColumnType("money")
				.HasColumnName("priceMin");
			entity.Property(e => e.WidthPackage).HasColumnName("widthPackage");

			entity.HasOne(d => d.IdProductTypeNavigation).WithMany(p => p.Products)
				.HasForeignKey(d => d.IdProductType)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_products_productTypes");
		});

		modelBuilder.Entity<ProductType>(entity => {
			entity.HasKey(e => e.Id).HasName("pk_productTypes");

			entity.Property(e => e.Id)
				.UseIdentityAlwaysColumn()
				.HasColumnName("id");
			entity.Property(e => e.TypeOfProduct).HasColumnName("typeOfProduct");
		});

		modelBuilder.Entity<Supplier>(entity => {
			entity.HasKey(e => e.Id).HasName("Suppliers_pkey");

			entity.Property(e => e.Id).HasColumnName("id");
			entity.Property(e => e.IdOfType).HasColumnName("idOfType");
			entity.Property(e => e.Inn).HasColumnName("inn");
			entity.Property(e => e.IsActive).HasColumnName("isActive");
			entity.Property(e => e.NameOfSupplier).HasColumnName("nameOfSupplier");

			entity.HasOne(d => d.IdOfTypeNavigation).WithMany(p => p.Suppliers)
				.HasForeignKey(d => d.IdOfType)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("fk_suppliers_types");
		});

		modelBuilder.Entity<UnitsOfMeasurement>(entity => {
			entity.HasKey(e => e.Id).HasName("UnitsOfMeasurement_pkey");

			entity.ToTable("UnitsOfMeasurement");

			entity.Property(e => e.Id).HasColumnName("id");
			entity.Property(e => e.NameOfUnit).HasColumnName("nameOfUnit");
			entity.Property(e => e.ShortName).HasColumnName("shortName");
		});

		OnModelCreatingPartial(modelBuilder);
	}

	partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
