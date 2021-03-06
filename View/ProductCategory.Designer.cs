﻿namespace GroupAProducts.View
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lblcat = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ProductCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.dGV_ProductCategory.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dGV_ProductCategory.Location = new System.Drawing.Point(16, 102);
            this.dGV_ProductCategory.Margin = new System.Windows.Forms.Padding(4);
            this.dGV_ProductCategory.Name = "dGV_ProductCategory";
            this.dGV_ProductCategory.Size = new System.Drawing.Size(931, 465);
            this.dGV_ProductCategory.TabIndex = 0;
            this.dGV_ProductCategory.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGV_ProductCategory_CellMouseClick);
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Number.DataPropertyName = "rownum";
            this.Number.HeaderText = "No.";
            this.Number.Name = "Number";
            this.Number.Width = 55;
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
            this.ProductName.Width = 113;
            // 
            // Barcode
            // 
            this.Barcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Barcode.DataPropertyName = "barcode";
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            this.Barcode.Width = 86;
            // 
            // Sizes
            // 
            this.Sizes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sizes.DataPropertyName = "sizes";
            this.Sizes.HeaderText = "Size";
            this.Sizes.Name = "Sizes";
            this.Sizes.ReadOnly = true;
            this.Sizes.Width = 60;
            // 
            // Color
            // 
            this.Color.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Color.DataPropertyName = "color";
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            this.Color.Width = 66;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Price.DataPropertyName = "price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 65;
            // 
            // lblcat
            // 
            this.lblcat.AutoSize = true;
            this.lblcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcat.Location = new System.Drawing.Point(123, 24);
            this.lblcat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcat.Name = "lblcat";
            this.lblcat.Size = new System.Drawing.Size(253, 31);
            this.lblcat.TabIndex = 1;
            this.lblcat.Text = "Product Serial List";
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(860, 610);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(156, 50);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Create New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GroupAProducts.Properties.Resources.teamicon;
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(655, 610);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(167, 50);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1045, 693);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lblcat);
            this.Controls.Add(this.dGV_ProductCategory);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductCategory";
            this.Load += new System.EventHandler(this.ProductCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ProductCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBack;
    }
}