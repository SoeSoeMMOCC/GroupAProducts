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
            this.DetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sizes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lblcat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ProductCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_ProductCategory
            // 
            this.dGV_ProductCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_ProductCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.DetailID,
            this.ColorID,
            this.ProductName,
            this.Barcode,
            this.Sizes,
            this.Color,
            this.Price});
            this.dGV_ProductCategory.Location = new System.Drawing.Point(12, 81);
            this.dGV_ProductCategory.Name = "dGV_ProductCategory";
            this.dGV_ProductCategory.Size = new System.Drawing.Size(643, 470);
            this.dGV_ProductCategory.TabIndex = 0;
            this.dGV_ProductCategory.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dGV_ProductCategory_MouseDoubleClick);
            // 
            // Number
            // 
            this.Number.HeaderText = "No.";
            this.Number.Name = "Number";
            // 
            // DetailID
            // 
            this.DetailID.HeaderText = "Detail ID";
            this.DetailID.Name = "DetailID";
            this.DetailID.ReadOnly = true;
            this.DetailID.Visible = false;
            // 
            // ColorID
            // 
            this.ColorID.HeaderText = "ColorID";
            this.ColorID.Name = "ColorID";
            this.ColorID.ReadOnly = true;
            this.ColorID.Visible = false;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Barcode
            // 
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            // 
            // Sizes
            // 
            this.Sizes.HeaderText = "Size";
            this.Sizes.Name = "Sizes";
            this.Sizes.ReadOnly = true;
            // 
            // Color
            // 
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sizes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lblcat;
    }
}