using System;
using System.Collections.Generic;

namespace ProductsApp.Models;

public partial class ProductType {
	public short Id { get; set; }

	public string TypeOfProduct { get; set; } = null!;

	public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
