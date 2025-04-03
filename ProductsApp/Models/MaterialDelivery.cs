using System;
using System.Collections.Generic;

namespace ProductsApp.Models;

public partial class MaterialDelivery {
	public int Id { get; set; }

	public int IdOfMaterial { get; set; }

	public DateOnly DateOfDelivery { get; set; }

	public short IdOfSupplier { get; set; }

	public int AmountInPackage { get; set; }

	public short PackageCount { get; set; }

	public decimal PriceForPackage { get; set; }

	public short QualityOfDelivery { get; set; }

	public virtual Material IdOfMaterialNavigation { get; set; } = null!;

	public virtual Supplier IdOfSupplierNavigation { get; set; } = null!;
}
