using System;
using System.Collections.Generic;

namespace ProductsApp.Models;

public partial class UnitsOfMeasurement {
	public short Id { get; set; }

	public string NameOfUnit { get; set; } = null!;

	public string ShortName { get; set; } = null!;

	public virtual ICollection<Material> Materials { get; set; } = new List<Material>();
}
