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
            this.lblbrand = new System.Windows.Forms.Label();
            this.lblproduct = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblbrand
            // 
            this.lblbrand.AutoSize = true;
            this.lblbrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbrand.Location = new System.Drawing.Point(86, 50);
            this.lblbrand.Name = "lblbrand";
            this.lblbrand.Size = new System.Drawing.Size(97, 17);
            this.lblbrand.TabIndex = 0;
            this.lblbrand.Text = "Brand Name";
            // 
            // lblproduct
            // 
            this.lblproduct.AutoSize = true;
            this.lblproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproduct.Location = new System.Drawing.Point(86, 82);
            this.lblproduct.Name = "lblproduct";
            this.lblproduct.Size = new System.Drawing.Size(110, 17);
            this.lblproduct.TabIndex = 1;
            this.lblproduct.Text = "Product Name";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCat.Location = new System.Drawing.Point(86, 116);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(119, 17);
            this.lblCat.TabIndex = 2;
            this.lblCat.Text = "Category Name";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(86, 151);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(46, 17);
            this.lblColor.TabIndex = 3;
            this.lblColor.Text = "Color";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(86, 191);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(39, 17);
            this.lblSize.TabIndex = 4;
            this.lblSize.Text = "Size";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(86, 230);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(45, 17);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(293, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // ProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.lblproduct);
            this.Controls.Add(this.lblbrand);
            this.Name = "ProductDetails";
            this.Text = "ProductDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lblbrand;
        private System.Windows.Forms.Label lblproduct;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}