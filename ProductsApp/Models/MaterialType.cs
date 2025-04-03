using System;
using System.Collections.Generic;

namespace ProductsApp.Models;

public partial class MaterialType {
	public short Id { get; set; }

	public float DefectRate { get; set; }

	public string Type { get; set; } = null!;

	public virtual ICollection<Material> Materials { get; set; } = new List<Material>();
}
