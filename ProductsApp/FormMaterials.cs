using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductsApp.Models;

namespace ProductsApp {
	public partial class FormMaterials : Form {
		private Product product;
		private List<Material?> materials;
		public FormMaterials(Product product) {
			InitializeComponent();
			this.product = product;
			Text = product.MaterialsProducts.Count.ToString(); 
			//foreach (MaterialsProduct materialProduct in product.MaterialsProducts) {
			//	materials.Add(materialProduct.IdMaterialNavigation);
			//}
		}
		private void FormMaterials_Load(object sender, EventArgs e) {
			dataGridView1.DataSource = materials;
		}
	}
}
