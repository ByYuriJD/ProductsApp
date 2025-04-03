using System;
using System.Collections.Generic;

namespace ProductsApp.Models;

public partial class Product {
	public short Id { get; set; }

	public short IdProductType { get; set; }

	public decimal PriceMin { get; set; }

	public string NameOfProduct { get; set; } = null!;

	public string Article { get; set; } = null!;

	public string NumberStandart { get; set; } = null!;

	public decimal? LengthPackage { get; set; }

	public decimal? WidthPackage { get; set; }

	public decimal? HeightPackage { get; set; }

	public string? Description { get; set; }

	public string? Image { get; set; }

	public string? Certificate { get; set; }

	public virtual ProductType IdProductTypeNavigation { get; set; } = null!;

	public virtual ICollection<MaterialsProduct> MaterialsProducts { get; set; } = new List<MaterialsProduct>();

	public virtual ICollection<PartnersProduct> PartnersProducts { get; set; } = new List<PartnersProduct>();
}
