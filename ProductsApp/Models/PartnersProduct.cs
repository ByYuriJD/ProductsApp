using System;
using System.Collections.Generic;

namespace ProductsApp.Models;

public partial class PartnersProduct {
	public short Id { get; set; }

	public short IdOfPartner { get; set; }

	public short IdOfProduct { get; set; }

	public int Amount { get; set; }

	public DateOnly SaleDate { get; set; }

	public virtual Partner IdOfPartnerNavigation { get; set; } = null!;

	public virtual Product IdOfProductNavigation { get; set; } = null!;
}
