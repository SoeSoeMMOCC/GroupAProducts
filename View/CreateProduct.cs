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
        private MainForm MainForm;
        ProductRepository prodRepo = new ProductRepository();
        string error = "";
        public CreateProduct()
        {
            InitializeComponent();
        }

        public void refreshdata()
        {
            //Auto Generate ProductID               
            GA_Common.ProductAutoID = prodRepo.getProductNoSeries("Product", out error);
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

        //save data to product table
        private void btnSave_Click(object sender, EventArgs e)
        {
            GA_Common.objProducts = new ProductModel();

            GA_Common.objProducts.productid = GA_Common.ProductAutoID;

            DialogResult = MessageBox.Show("Are you sure to SAVE data",
                                "Confirmation", MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                //check product name data
                if (txtProductName.Text == "" || txtProductName.Text == null)
                {
                    MessageBox.Show("Enter Product Name!",
                                "Information", MessageBoxButtons.OK);
                    txtProductName.Focus();
                    return;
                }
                else
                {
                    GA_Common.objProducts.productname = txtProductName.Text;
                }

                //check brand
                if (cmbBrand.SelectedValue == null)
                {
                    MessageBox.Show("Select Brand Name!",
                                "Information", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    GA_Common.objProducts.brandid = cmbBrand.SelectedValue.ToString();
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
                    GA_Common.objProducts.pcatid = cmbCategory.SelectedValue.ToString();
                }                   
                             
                ReturnDataModel ObjSaveProduct = prodRepo.saveProducts(GA_Common.objProducts, out error);
                if (ObjSaveProduct.retStatus == true)
                {
                    MessageBox.Show("Successfully SAVE!",
                                "Information", MessageBoxButtons.OK);
                    //clear autoid textbox
                    GA_Common.ProductAutoID = null;
                }
                else
                {
                    MessageBox.Show(ObjSaveProduct.errorMsg,
                                "Information", MessageBoxButtons.OK);
                }

            }
            else if (DialogResult == DialogResult.No)
            {
                return;
            }

            this.Close();            
        }

        private void CreateProduct_Load(object sender, EventArgs e)
        {
            refreshdata();
        }

        //close current form and goback to main form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
