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
            this.dGV_ProductDetail = new System.Windows.Forms.DataGridView();
            this.RowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ProductDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_ProductDetail
            // 
            this.dGV_ProductDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_ProductDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowNumber,
            this.BrandID,
            this.ProductID,
            this.PCatID,
            this.BrandName,
            this.ProductName,
            this.Qty});
            this.dGV_ProductDetail.Location = new System.Drawing.Point(101, 70);
            this.dGV_ProductDetail.Name = "dGV_ProductDetail";
            this.dGV_ProductDetail.Size = new System.Drawing.Size(443, 185);
            this.dGV_ProductDetail.TabIndex = 0;
            // 
            // RowNumber
            // 
            this.RowNumber.DataPropertyName = "RowNumber";
            this.RowNumber.HeaderText = "No.";
            this.RowNumber.Name = "RowNumber";
            this.RowNumber.ReadOnly = true;
            // 
            // BrandID
            // 
            this.BrandID.HeaderText = "Brand ID";
            this.BrandID.Name = "BrandID";
            this.BrandID.Visible = false;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.Name = "ProductID";
            this.ProductID.Visible = false;
            // 
            // PCatID
            // 
            this.PCatID.HeaderText = "Category ID";
            this.PCatID.Name = "PCatID";
            this.PCatID.Visible = false;
            // 
            // BrandName
            // 
            this.BrandName.HeaderText = "Brand Name";
            this.BrandName.Name = "BrandName";
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Quantity";
            this.Qty.Name = "Qty";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dGV_ProductDetail);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ProductDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_ProductDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
    }
}