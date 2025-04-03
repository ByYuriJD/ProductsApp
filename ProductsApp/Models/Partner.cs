using System;
using System.Collections.Generic;

namespace ProductsApp.Models;

public partial class Partner {
	public short Id { get; set; }

	public short IdPartnerType { get; set; }

	public short Rating { get; set; }

	public string NameOfPartner { get; set; } = null!;

	public string LegalAdress { get; set; } = null!;

	public string Inn { get; set; } = null!;

	public string FullNameOfCeo { get; set; } = null!;

	public string PhoneNumber { get; set; } = null!;

	public string Email { get; set; } = null!;

	public virtual OrganizationType IdPartnerTypeNavigation { get; set; } = null!;

	public virtual ICollection<PartnersProduct> PartnersProducts { get; set; } = new List<PartnersProduct>();
}
