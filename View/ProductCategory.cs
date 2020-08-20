using GroupAProducts.Common;
using GroupAProducts.Model;
using GroupAProducts.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupAProducts.View
{
    public partial class ProductCategory : Form
    {
        private ProductDetails ProductDetails;
        private MainForm MainForm;

        public ProductCategory()
        {
            InitializeComponent();
        }

        private void BindGrid()
        {
            try
            {
                List<ProductDetailModel> ProductDetailList = new List<ProductDetailModel>();
                string error = "";
                ProductRepository prodRepo = new ProductRepository();
                ProductDetailList = prodRepo.getProductDetailList(GA_Common.ProID, GA_Common.PCatID, GA_Common.BrandID, "%", out error);
                dGV_ProductCategory.DataSource = ProductDetailList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProductCategory_Load(object sender, EventArgs e)
        {            
            BindGrid();
            GA_Common.ProID = null;
            GA_Common.PCatID = null;
            GA_Common.BrandID = null;
        }

        private void dGV_ProductCategory_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            GA_Common.btnstatus = "Edit";
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dGV_ProductCategory.Rows[e.RowIndex];
                GA_Common.ProID = Convert.ToString(row.Cells["productid"].Value);
                GA_Common.PCatID = Convert.ToString(row.Cells["pcatid"].Value);
                GA_Common.BrandID = Convert.ToString(row.Cells["brandid"].Value);
                GA_Common.PDetailID = Convert.ToString(row.Cells["detailid"].Value);               
            }
            ProductDetails = new ProductDetails();
            ProductDetails.Show();
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            GA_Common.btnstatus = "CreateNew";
            ProductDetails = new ProductDetails();
            ProductDetails.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm = new MainForm();
            MainForm.refresh_method();
            //MainForm.Show();
        }
    }
}
