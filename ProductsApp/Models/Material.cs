using System;
using System.Collections.Generic;

namespace ProductsApp.Models;

public partial class Material {
	public int Id { get; set; }

	public short IdOfUnit { get; set; }

	public string? Image { get; set; }

	public short IdType { get; set; }

	public string NameOfMaterial { get; set; } = null!;

	public string? Description { get; set; }

	public virtual UnitsOfMeasurement IdOfUnitNavigation { get; set; } = null!;

	public virtual MaterialType IdTypeNavigation { get; set; } = null!;

	public virtual ICollection<MaterialDelivery> MaterialDeliveries { get; set; } = new List<MaterialDelivery>();

	public virtual ICollection<MaterialsProduct> MaterialsProducts { get; set; } = new List<MaterialsProduct>();
}
