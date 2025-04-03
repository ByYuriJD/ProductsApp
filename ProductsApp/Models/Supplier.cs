using System;
using System.Collections.Generic;

namespace ProductsApp.Models;

public partial class Supplier {
	public short Id { get; set; }

	public short IdOfType { get; set; }

	public bool IsActive { get; set; }

	public string NameOfSupplier { get; set; } = null!;

	public string Inn { get; set; } = null!;

	public virtual OrganizationType IdOfTypeNavigation { get; set; } = null!;

	public virtual ICollection<MaterialDelivery> MaterialDeliveries { get; set; } = new List<MaterialDelivery>();
}
