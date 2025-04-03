using System;
using System.Collections.Generic;

namespace ProductsApp.Models;

public partial class MaterialsProduct {
	public int Id { get; set; }

	public int IdMaterial { get; set; }

	public short IdProduct { get; set; }

	public decimal MaterialAmount { get; set; }

	public virtual Material IdMaterialNavigation { get; set; } = null!;

	public virtual Product IdProductNavigation { get; set; } = null!;
}
