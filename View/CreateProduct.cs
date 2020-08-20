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
    public partial class CreateProduct : Form
    {
        ProductRepository prodRepo = new ProductRepository();
        string error = "";
        public CreateProduct()
        {
            InitializeComponent();
        }

        public void refreshdata()
        {
            //ProductDetailID                
            GA_Common.ProductAutoID = prodRepo.getProductNoSeries("Products", out error);
            txtProductID.Text = GA_Common.ProductAutoID;

            //BrandName
            List<Brand> ObjBrand = new List<Brand>();
            ObjBrand = prodRepo.getProductBrand("%", out error);
            cmbBrand.DataSource = ObjBrand;
            cmbBrand.ValueMember = "brandid";
            cmbBrand.DisplayMember = "brandname";

            //Category Name
            List<CategoryModel> ObjCategory = new List<CategoryModel>();
            ObjCategory = prodRepo.getProductCategory("%", out error);
            cmbCategory.DataSource = ObjCategory;
            cmbCategory.ValueMember = "pcatid";
            cmbCategory.DisplayMember = "pcatname";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string saveErr = "";
            string productname = "";
            string brand = "";
            string category = "";
            DialogResult = MessageBox.Show("Are you sure to SAVE data",
                                "Confirmation", MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                //check product name data
                if (txtProductName.Text == "")
                    MessageBox.Show("Enter Product Name!",
                                "Information", MessageBoxButtons.OK);
                else
                    txtProductName.Text = txtProductName.Text;

                //check brand
                if (cmbBrand.SelectedValue == null)
                {
                    MessageBox.Show("Select Brand Name!",
                                "Information", MessageBoxButtons.OK);
                    return;
                }
                else
                {                    
                    brand = cmbBrand.SelectedValue.ToString();
                }

                //check category
                if (cmbCategory.SelectedValue == null)
                {
                    MessageBox.Show("Select Category Name!",
                                "Information", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    category = cmbCategory.SelectedValue.ToString();
                }

                //save data

            }

        }

        private void CreateProduct_Load(object sender, EventArgs e)
        {
            refreshdata();
        }
    }
}
