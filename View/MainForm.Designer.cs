namespace GroupAProducts.View
{
    partial class MainForm
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
            this.dGV_ProductList = new System.Windows.Forms.DataGridView();
            this.rownum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_ProductList
            // 
            this.dGV_ProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_ProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rownum,
            this.ProductID,
            this.PCatID,
            this.BrandID,
            this.BrandName,
            this.ProductName,
            this.Qty});
            this.dGV_ProductList.Location = new System.Drawing.Point(101, 70);
            this.dGV_ProductList.Name = "dGV_ProductList";
            this.dGV_ProductList.Size = new System.Drawing.Size(443, 185);
            this.dGV_ProductList.TabIndex = 0;
            // 
            // rownum
            // 
            this.rownum.DataPropertyName = "rownum";
            this.rownum.HeaderText = "No.";
            this.rownum.Name = "rownum";
            this.rownum.ReadOnly = true;
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "productid";
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.Name = "ProductID";
            this.ProductID.Visible = false;
            // 
            // PCatID
            // 
            this.PCatID.DataPropertyName = "pcatid";
            this.PCatID.HeaderText = "Category ID";
            this.PCatID.Name = "PCatID";
            this.PCatID.Visible = false;
            // 
            // BrandID
            // 
            this.BrandID.DataPropertyName = "brandid";
            this.BrandID.HeaderText = "Brand ID";
            this.BrandID.Name = "BrandID";
            this.BrandID.Visible = false;
            // 
            // BrandName
            // 
            this.BrandName.DataPropertyName = "brandname";
            this.BrandName.HeaderText = "Brand Name";
            this.BrandName.Name = "BrandName";
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "productname";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            // 
            // Qty
            // 
            this.Qty.DataPropertyName = "total_qty";
            this.Qty.HeaderText = "Total Quantity";
            this.Qty.Name = "Qty";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dGV_ProductList);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ProductList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_ProductList;
        private System.Windows.Forms.DataGridViewTextBoxColumn rownum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
    }
}