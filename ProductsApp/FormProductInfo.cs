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
	public partial class FormProductInfo : Form {
		private Product product;
		public FormProductInfo(Product product) {
			InitializeComponent();
			this.product = product;
		}
		private void FormProductInfo_Load(object sender, EventArgs e) {
			labelArticle.Text = product.Article.ToString();
			labelDescription.Text = product.Description;
			labelHeight.Text = product.HeightPackage.ToString();
			labelLength.Text = product.LengthPackage.ToString();
			labelName.Text = product.NameOfProduct.ToString();
			labelPrice.Text = product.PriceMin.ToString();
			labelStandart.Text = product.NumberStandart.ToString();
			labelType.Text = product.IdProductTypeNavigation.TypeOfProduct.ToString();
			labelWidth.Text = product.WidthPackage.ToString();

			if (product.Image != null) {
				try {
					pictureBox.Image = Image.FromFile(product.Image);
				} catch (Exception ex) {

				}
			}

		}
		private void button1_Click(object sender, EventArgs e) {
			if (product.Certificate != null) {
				try {
					Image.FromFile(product.Certificate);
				} catch (Exception ex) {
					if (ex is FileNotFoundException) {
						MessageBox.Show("Сертификат не найден","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
					}
				}
			} else {
				MessageBox.Show("Сертификат отсутствует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
