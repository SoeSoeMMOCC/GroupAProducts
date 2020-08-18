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

        public ProductCategory()
        {
            InitializeComponent();
        }

        private void dGV_ProductCategory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ProductDetails = new ProductDetails();
            ProductDetails.Show();           
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
    }
}
