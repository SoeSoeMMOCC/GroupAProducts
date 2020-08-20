using GroupAProducts.Model;
using GroupAProducts.Repository;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using GroupAProducts.Common;

namespace GroupAProducts.View
{
    public partial class MainForm : Form
    {
        private ProductCategory ProductCategoryList;
        public MainForm()
        {
            InitializeComponent();           
        }
        private void BindGrid()
        {            
            try
            {
                List<ProductModel> ProductList = new List<ProductModel>();
                string error = "";
                ProductRepository prodRepo = new ProductRepository();
                ProductList = prodRepo.getProductListByCount("%", "%", "%",out error);                
                dGV_ProductList.DataSource = ProductList;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
       
        private void dGV_ProductList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dGV_ProductList.Rows[e.RowIndex];
                GA_Common.ProID = Convert.ToString(row.Cells["productid"].Value);
                GA_Common.PCatID = Convert.ToString( row.Cells["pcatid"].Value);
                GA_Common.BrandID = Convert.ToString(row.Cells["brandid"].Value);
            }
            ProductCategoryList = new ProductCategory();
            ProductCategoryList.Show();
        }

        private void dGV_ProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblStock_Click(object sender, EventArgs e)
        {

        }
    }
}
