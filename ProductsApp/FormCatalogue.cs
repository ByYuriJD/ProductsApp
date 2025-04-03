using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using ProductsApp.Models;

namespace ProductsApp
{
	public partial class FormCatalogue : Form {
		PartnersContext? db;
		public FormCatalogue() {
			InitializeComponent();

		}

		protected override void OnClosing(CancelEventArgs e) {
			base.OnClosing(e);
			db?.Dispose();
			db = null;
		}

		private void buttonView_Click(object sender, EventArgs e) {

		}

		private void FormCatalogue_Load(object sender, EventArgs e) {

			db = new PartnersContext();
			db.Products.Load();
			db.ProductTypes.Load();

			dataGridView.DataSource = db.Products.Local.ToBindingList();

			{
				dataGridView.Columns["Id"].Visible = false;
				dataGridView.Columns["IdProductType"].Visible = false;
				dataGridView.Columns["LengthPackage"].Visible = false;
				dataGridView.Columns["WidthPackage"].Visible = false;
				dataGridView.Columns["HeightPackage"].Visible = false;
				dataGridView.Columns["Description"].Visible = false;
				dataGridView.Columns["Image"].Visible = false;
				dataGridView.Columns["Certificate"].Visible = false;
				dataGridView.Columns["IdProductTypeNavigation"].Visible = false;
				dataGridView.Columns["MaterialsProducts"].Visible = false;
				dataGridView.Columns["PartnersProducts"].Visible = false;
			}

			DataGridViewTextBoxColumn prodType = new DataGridViewTextBoxColumn();
			prodType.Name = "Тип продукции";
			prodType.DisplayIndex = 0;
			dataGridView.Columns.Add(prodType);

			dataGridView.Columns["Article"].HeaderText = "Артикул";
			dataGridView.Columns["Article"].DisplayIndex = 1;

			dataGridView.Columns["nameOfProduct"].HeaderText = "Наименование продукции";
			dataGridView.Columns["nameOfProduct"].DisplayIndex = 2;

			dataGridView.Columns["NumberStandart"].HeaderText = "Номер стандарта";
			dataGridView.Columns["NumberStandart"].DisplayIndex = 3;

			DataGridViewTextBoxColumn packageSize = new DataGridViewTextBoxColumn();
			packageSize.Name = "Размер упаковки";
			packageSize.DisplayIndex = 4;
			dataGridView.Columns.Add(packageSize);

			dataGridView.Columns["priceMin"].HeaderText = "Минимальная стоимость для партнера";
			dataGridView.Columns["priceMin"].DisplayIndex = 5;

			Product[] products = db.Products.Local.ToArray();

			for (int i = 0; i < dataGridView.RowCount; i++) {
				DataGridViewRow row = dataGridView.Rows[i];
				Product product = products[i];
				row.Cells["Тип продукции"].Value =
					product.IdProductTypeNavigation.TypeOfProduct;

				row.Cells["Размер упаковки"].Value =
					product.LengthPackage + "x"
					+ product.WidthPackage + "x"
					+ product.HeightPackage;
			}

		}
	}
}
