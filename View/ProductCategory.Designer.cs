namespace GroupAProducts.View
{
    partial class ProductCategory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dGV_ProductCategory = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lblcat = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PcatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brandname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PcatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sizes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ProductCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_ProductCategory
            // 
            this.dGV_ProductCategory.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.dGV_ProductCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_ProductCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.PcatID,
            this.ProductID,
            this.BrandID,
            this.SizeID,
            this.DetailID,
            this.ColorID,
            this.Brandname,
            this.PcatName,
            this.ProductName,
            this.Barcode,
            this.Sizes,
            this.Color,
            this.Price});
            this.dGV_ProductCategory.Location = new System.Drawing.Point(12, 83);
            this.dGV_ProductCategory.Name = "dGV_ProductCategory";
            this.dGV_ProductCategory.Size = new System.Drawing.Size(739, 468);
            this.dGV_ProductCategory.TabIndex = 0;
            this.dGV_ProductCategory.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dGV_ProductCategory_MouseDoubleClick);
            // 
            // lblcat
            // 
            this.lblcat.AutoSize = true;
            this.lblcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcat.Location = new System.Drawing.Point(12, 28);
            this.lblcat.Name = "lblcat";
            this.lblcat.Size = new System.Drawing.Size(234, 31);
            this.lblcat.TabIndex = 1;
            this.lblcat.Text = "Product Serial List";
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Number.DataPropertyName = "rownum";
            this.Number.HeaderText = "No.";
            this.Number.Name = "Number";
            this.Number.Width = 49;
            // 
            // PcatID
            // 
            this.PcatID.DataPropertyName = "pcatid";
            this.PcatID.HeaderText = "Category ID";
            this.PcatID.Name = "PcatID";
            this.PcatID.Visible = false;
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "productid";
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.Name = "ProductID";
            this.ProductID.Visible = false;
            // 
            // BrandID
            // 
            this.BrandID.DataPropertyName = "brandid";
            this.BrandID.HeaderText = "Brand ID";
            this.BrandID.Name = "BrandID";
            this.BrandID.Visible = false;
            // 
            // SizeID
            // 
            this.SizeID.DataPropertyName = "sizeid";
            this.SizeID.HeaderText = "Size ID";
            this.SizeID.Name = "SizeID";
            this.SizeID.Visible = false;
            // 
            // DetailID
            // 
            this.DetailID.DataPropertyName = "detailid";
            this.DetailID.HeaderText = "Detail ID";
            this.DetailID.Name = "DetailID";
            this.DetailID.ReadOnly = true;
            // 
            // ColorID
            // 
            this.ColorID.DataPropertyName = "colorid";
            this.ColorID.HeaderText = "ColorID";
            this.ColorID.Name = "ColorID";
            this.ColorID.ReadOnly = true;
            this.ColorID.Visible = false;
            // 
            // Brandname
            // 
            this.Brandname.DataPropertyName = "brandname";
            this.Brandname.HeaderText = "Brand Name";
            this.Brandname.Name = "Brandname";
            // 
            // PcatName
            // 
            this.PcatName.DataPropertyName = "pcatname";
            this.PcatName.HeaderText = "Category Name";
            this.PcatName.Name = "PcatName";
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ProductName.DataPropertyName = "productname";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 92;
            // 
            // Barcode
            // 
            this.Barcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Barcode.DataPropertyName = "barcode";
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            this.Barcode.Width = 72;
            // 
            // Sizes
            // 
            this.Sizes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sizes.DataPropertyName = "sizes";
            this.Sizes.HeaderText = "Size";
            this.Sizes.Name = "Sizes";
            this.Sizes.ReadOnly = true;
            this.Sizes.Width = 52;
            // 
            // Color
            // 
            this.Color.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Color.DataPropertyName = "color";
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            this.Color.Width = 56;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Price.DataPropertyName = "price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 56;
            // 
            // ProductCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 563);
            this.Controls.Add(this.lblcat);
            this.Controls.Add(this.dGV_ProductCategory);
            this.Name = "ProductCategory";
            this.Text = "ProductCategory";
            this.Load += new System.EventHandler(this.ProductCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ProductCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_ProductCategory;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lblcat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn PcatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brandname;
        private System.Windows.Forms.DataGridViewTextBoxColumn PcatName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sizes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}