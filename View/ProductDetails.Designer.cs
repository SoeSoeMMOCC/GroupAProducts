namespace GroupAProducts.View
{
    partial class ProductDetails
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tblDetail = new System.Windows.Forms.TableLayoutPanel();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tblDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblDetail
            // 
            this.tblDetail.ColumnCount = 2;
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.35587F));
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.64413F));
            this.tblDetail.Controls.Add(this.lblBrandName, 0, 0);
            this.tblDetail.Controls.Add(this.flowLayoutPanel1, 1, 2);
            this.tblDetail.Controls.Add(this.label2, 0, 2);
            this.tblDetail.Controls.Add(this.label1, 0, 1);
            this.tblDetail.Location = new System.Drawing.Point(113, 35);
            this.tblDetail.Name = "tblDetail";
            this.tblDetail.RowCount = 7;
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.73228F));
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.26772F));
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblDetail.Size = new System.Drawing.Size(500, 200);
            this.tblDetail.TabIndex = 0;
            // 
            // lblBrandName
            // 
            this.lblBrandName.AutoSize = true;
            this.lblBrandName.Location = new System.Drawing.Point(10, 25);
            this.lblBrandName.Margin = new System.Windows.Forms.Padding(10, 25, 3, 0);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(66, 7);
            this.lblBrandName.TabIndex = 0;
            this.lblBrandName.Text = "Brand Name";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(254, 80);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 36);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 25, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 25, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // ProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tblDetail);
            this.Name = "ProductDetails";
            this.Text = "ProductDetails";
            this.tblDetail.ResumeLayout(false);
            this.tblDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TableLayoutPanel tblDetail;
        private System.Windows.Forms.Label lblBrandName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}