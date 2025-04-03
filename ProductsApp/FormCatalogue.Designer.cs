namespace ProductsApp
{
    partial class FormCatalogue
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCatalogue));
			panel1 = new Panel();
			tableLayoutPanel1 = new TableLayoutPanel();
			buttonMaterials = new Button();
			buttonView = new Button();
			dataGridView = new DataGridView();
			panel1.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(tableLayoutPanel1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(8, 8);
			panel1.Name = "panel1";
			panel1.Size = new Size(624, 70);
			panel1.TabIndex = 0;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Controls.Add(buttonMaterials, 1, 0);
			tableLayoutPanel1.Controls.Add(buttonView, 0, 0);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Size = new Size(624, 70);
			tableLayoutPanel1.TabIndex = 3;
			// 
			// buttonMaterials
			// 
			buttonMaterials.Dock = DockStyle.Left;
			buttonMaterials.Location = new Point(315, 3);
			buttonMaterials.Name = "buttonMaterials";
			buttonMaterials.Size = new Size(135, 64);
			buttonMaterials.TabIndex = 1;
			buttonMaterials.Text = "Посмотреть себестоимость";
			buttonMaterials.UseVisualStyleBackColor = true;
			// 
			// buttonView
			// 
			buttonView.Dock = DockStyle.Right;
			buttonView.Location = new Point(132, 3);
			buttonView.Name = "buttonView";
			buttonView.Size = new Size(177, 64);
			buttonView.TabIndex = 0;
			buttonView.Text = "Посмотреть подробнее";
			buttonView.UseVisualStyleBackColor = true;
			// 
			// dataGridView
			// 
			dataGridView.AllowUserToAddRows = false;
			dataGridView.AllowUserToDeleteRows = false;
			dataGridView.AllowUserToOrderColumns = true;
			dataGridView.BackgroundColor = Color.White;
			dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView.Dock = DockStyle.Fill;
			dataGridView.Location = new Point(8, 78);
			dataGridView.Name = "dataGridView";
			dataGridView.ReadOnly = true;
			dataGridView.Size = new Size(624, 339);
			dataGridView.TabIndex = 1;
			// 
			// FormCatalogue
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(640, 425);
			Controls.Add(dataGridView);
			Controls.Add(panel1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "FormCatalogue";
			Padding = new Padding(8);
			Text = "Каталог готовой продукции";
			Load += FormCatalogue_Load;
			panel1.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private DataGridView dataGridView;
		private TableLayoutPanel tableLayoutPanel1;
		private Button buttonMaterials;
		private Button buttonView;
	}
}
