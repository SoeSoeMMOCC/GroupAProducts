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
    public partial class ProductDetails : Form
    {
        public ProductDetails()
        {
            InitializeComponent();
            refreshdata();
        }

        public void refreshdata()
        {
            string error = "";

            //BrandName
            List<Brand> ObjBrandName = new List<Brand>();
            ProductRepository prodRepoBrand = new ProductRepository();
            ObjBrandName = prodRepoBrand.getProductBrand("%",out error);
            cmbBrandName.DataSource = ObjBrandName;
            cmbBrandName.ValueMember = "brandid";
            cmbBrandName.DisplayMember = "brandname";

            //ProductName
            List<Products> ObjProductName = new List<Products>();
            ProductRepository prodRepoProduct = new ProductRepository();
            ObjProductName = prodRepoProduct.getProducts("%", "%", "%", out error);
            cmbProductName.DataSource = ObjProductName;
            cmbProductName.ValueMember = "productid";
            cmbProductName.DisplayMember = "productname";

            //Category Name
            List<CategoryModel> ObjCategoryName = new List<CategoryModel>();
            ProductRepository prodRepoCategory = new ProductRepository();
            ObjCategoryName = prodRepoCategory.getProductCategory("%", out error);
            cmbCategoryName.DataSource = ObjCategoryName;
            cmbCategoryName.ValueMember = "productid";
            cmbCategoryName.DisplayMember = "productname";

            //Color
            List<ProductColor> ObjProductColor = new List<ProductColor>();
            ProductRepository prodRepoColor = new ProductRepository();
            ObjProductColor = prodRepoColor.getProductColor("%", out error);
            cmbColor.DataSource = ObjCategoryName;
            cmbColor.ValueMember = "colorid";
            cmbColor.DisplayMember = "color";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //DialogResult dr = MessageBox.Show("Are you sure to DELETE?", "Confirmation", MessageBoxButtons.YesNo);

            DialogResult = MessageBox.Show("Are you sure to DELETE?",
                                "Confirmation", MessageBoxButtons.YesNo, 
                                 MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                // any function
            }
            else
            {
                // any function
            }
        }

        private void ProductDetails_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
