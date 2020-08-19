using GroupAProducts.Common;
using GroupAProducts.Model;
using GroupAProducts.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupAProducts.View
{
    public partial class ProductDetails : Form
    {
        private ProductCategory ProductCategory;
        string error = "";

        ProductRepository prodRepo = new ProductRepository();
        public ProductDetails()
        {
            InitializeComponent();            
        }

        public void refreshdata()
        {                   
            //BrandName
            List<Brand> ObjBrandName = new List<Brand>();
            ObjBrandName = prodRepo.getProductBrand("%", out error);
            cmbBrandName.DataSource = ObjBrandName;
            cmbBrandName.ValueMember = "brandid";
            cmbBrandName.DisplayMember = "brandname";

            //ProductName
            List<Products> ObjProductName = new List<Products>();
            ObjProductName = prodRepo.getProducts("%", "%", "%", out error);
            cmbProductName.DataSource = ObjProductName;
            cmbProductName.ValueMember = "productid";
            cmbProductName.DisplayMember = "productname";

            //Category Name
            List<CategoryModel> ObjCategoryName = new List<CategoryModel>();
            ObjCategoryName = prodRepo.getProductCategory("%", out error);
            cmbCategoryName.DataSource = ObjCategoryName;
            cmbCategoryName.ValueMember = "pcatid";
            cmbCategoryName.DisplayMember = "pcatname";

            //Color
            List<ProductColor> ObjProductColor = new List<ProductColor>();
            ObjProductColor = prodRepo.getProductColor("%", out error);
            cmbColor.DataSource = ObjProductColor;
            cmbColor.ValueMember = "colorid";
            cmbColor.DisplayMember = "color";

            //Sizes
            List<ProductSize> ObjProductSize = new List<ProductSize>();
            ObjProductSize = prodRepo.getProductSize("%", out error);
            cmbSize.DataSource = ObjProductSize;
            cmbSize.ValueMember = "sizeid";
            cmbSize.DisplayMember = "sizes";

            if (GA_Common.btnstatus == "Edit")
            {
                List<ProductDetailModel> productDetailsList = prodRepo.getProductDetailList(GA_Common.ProID, GA_Common.PCatID, GA_Common.BrandID, GA_Common.PDetailID, out error);
                if (productDetailsList.Count() > 0)
                {
                    GA_Common.objProductDetails = productDetailsList[0];

                    //ProductDetailID
                    txtProDetailID.Text = GA_Common.objProductDetails.detailid;

                    //BarCode
                    txtBarcode.Text = GA_Common.objProductDetails.barcode;

                    //brandname
                    int brandindex = ObjBrandName.FindIndex(x => x.brandid == GA_Common.BrandID);
                    cmbBrandName.SelectedIndex = brandindex;

                    //productname
                    //int productindex = ObjProductName.FindIndex(x => x.productid == GA_Common.ProID);
                    //cmbProductName.SelectedIndex = productindex;

                    //categoryname
                    int catindex = ObjCategoryName.FindIndex(x => x.pcatid == GA_Common.PCatID);
                    cmbCategoryName.SelectedIndex = catindex;

                    //color
                    int colorindex = ObjProductColor.FindIndex(x => x.colorid == GA_Common.objProductDetails.colorid);
                    cmbColor.SelectedIndex = colorindex;

                    //size
                    int sizeindex = ObjProductSize.FindIndex(x => x.sizeid == GA_Common.objProductDetails.sizeid);
                    cmbSize.SelectedIndex = sizeindex;

                    //Price
                    txtPrice.Text = GA_Common.objProductDetails.price.ToString();
                }
                else
                {
                    MessageBox.Show("No Data to show", "Information", MessageBoxButtons.OK);
                }
            }

            else if (GA_Common.btnstatus == "CreateNew")
            {
                //ProductDetailID                
                GA_Common.PDetailAutoID = prodRepo.getProductNoSeries(out error);
                txtProDetailID.Text = GA_Common.PDetailAutoID;
                GA_Common.objProductDetails = new ProductDetailModel();

                //BarCode
                txtBarcode.Text = prodRepo.getProductNoSeries(out error);

                //brandname                
                cmbBrandName.SelectedIndex = 0;

                //productname                
                cmbProductName.SelectedIndex = 0;

                //categoryname                
                cmbCategoryName.SelectedIndex = 0;

                //color
                cmbColor.SelectedIndex = 0;

                //size
                cmbSize.SelectedIndex = 0;

                //Price
                txtPrice.Text = "0";
            }               
                      
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {            
            string delerr = "";
            DialogResult = MessageBox.Show("Are you sure to DELETE?",
                                "Confirmation", MessageBoxButtons.YesNo, 
                                 MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                // any function
                ProductRepository prodRepoDelete = new ProductRepository();
                ReturnDataModel ObjDelete = prodRepoDelete.deleteProductDetail(GA_Common.PDetailID, out delerr);
                if(ObjDelete.retStatus == true)
                {
                    MessageBox.Show("Successfully DELETE!",
                                "Information", MessageBoxButtons.OK);                                
                }
                else
                {
                    MessageBox.Show(ObjDelete.errorMsg,
                                "Information", MessageBoxButtons.OK);
                }
                
            }
            else if (DialogResult == DialogResult.No)
            {
                //this.Close();
            }
        }

        private void ProductDetails_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            if (GA_Common.btnstatus == "CreateNew")
            {
                btnDelete.Visible = false; 
                refreshdata();
            }
            else if (GA_Common.btnstatus == "Edit")
            {
                btnDelete.Visible = true;
                refreshdata();
            }            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ProductCategory = new ProductCategory();
            ProductCategory.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GA_Common.objProductDetails.detailid = txtProDetailID.Text;
            //GA_Common.objProductDetails.barcode = txtBarcode.Text;
            //GA_Common.objProductDetails.productid = cmbProductName.SelectedValue.ToString();
            //GA_Common.objProductDetails.brandid = cmbBrandName.SelectedValue.ToString();
            //GA_Common.objProductDetails.pcatid = cmbCategoryName.SelectedValue.ToString();
            GA_Common.objProductDetails.colorid = cmbColor.SelectedValue.ToString();
            GA_Common.objProductDetails.sizeid = cmbSize.SelectedValue.ToString();
            GA_Common.objProductDetails.price = Convert.ToInt32(txtPrice.Text);

            string saveErr = "";
            DialogResult = MessageBox.Show("Are you sure to SAVE data",
                                "Confirmation", MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                //check barcode data
                if (txtBarcode.Text == "")
                    MessageBox.Show("Enter Barcode!",
                                "Information", MessageBoxButtons.OK);
                else
                    GA_Common.objProductDetails.barcode = txtBarcode.Text;

                //check product
                if (cmbProductName.SelectedValue == null)
                {
                    MessageBox.Show("Select Product Name!",
                                "Information", MessageBoxButtons.OK);
                    return;
                }

                else
                {
                    GA_Common.objProductDetails.productid = cmbProductName.SelectedValue.ToString();
                    GA_Common.ProID = cmbProductName.SelectedValue.ToString();                    

                }

                //check brand
                if (cmbBrandName.SelectedValue == null)
                {
                    MessageBox.Show("Select Brand Name!",
                                "Information", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    GA_Common.objProductDetails.brandid = cmbBrandName.SelectedValue.ToString();
                    GA_Common.BrandID = cmbBrandName.SelectedValue.ToString();
                }

                //check category
                if (cmbCategoryName.SelectedValue == null)
                {
                    MessageBox.Show("Select Category Name!",
                                "Information", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    GA_Common.objProductDetails.pcatid = cmbCategoryName.SelectedValue.ToString();
                    GA_Common.PCatID = cmbCategoryName.SelectedValue.ToString();
                }


                //update data
                ProductRepository prodRepoSave = new ProductRepository();
                ReturnDataModel ObjSave = prodRepoSave.updateProductDetail(GA_Common.PDetailID,GA_Common.objProductDetails, out saveErr);
                if (ObjSave.retStatus == true)
                {
                    MessageBox.Show("Successfully SAVE!",
                                "Information", MessageBoxButtons.OK);
                    //clear autoid textbox
                    GA_Common.PDetailAutoID = null;
                }
                else
                {
                    MessageBox.Show(ObjSave.errorMsg,
                                "Information", MessageBoxButtons.OK);
                }

            }
            else if (DialogResult == DialogResult.No)
            {
                //this.Close();
            }

            //refreshdata();
            ProductCategory = new ProductCategory();
            ProductCategory.Show();

        }

        private void cmbBrandName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBrandName.SelectedValue != null && cmbCategoryName.SelectedValue!=null)
            {
                List<Products> ObjProductNameByBrand = new List<Products>();
                //cmbProductName.DataSource = ObjProductNameByBrand;
                cmbProductName.ResetText();
                ObjProductNameByBrand = prodRepo.getProducts("%", cmbCategoryName.SelectedValue.ToString(), cmbBrandName.SelectedValue.ToString(), out error);
                cmbProductName.DataSource = ObjProductNameByBrand;
                cmbProductName.ValueMember = "productid";
                cmbProductName.DisplayMember = "productname";
                int productindex = ObjProductNameByBrand.FindIndex(x => x.productid == GA_Common.ProID);                
                cmbProductName.SelectedIndex = productindex;   
            }
            
        }

        private void cmbCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBrandName.SelectedValue != null && cmbCategoryName.SelectedValue != null)
            {
                List<Products> ObjProductNameByCat = new List<Products>();
                //cmbProductName.DataSource = ObjProductNameByCat;
                cmbProductName.ResetText();
                ObjProductNameByCat = prodRepo.getProducts("%", cmbCategoryName.SelectedValue.ToString(), cmbBrandName.SelectedValue.ToString(), out error);
                cmbProductName.DataSource = ObjProductNameByCat;
                cmbProductName.ValueMember = "productid";
                cmbProductName.DisplayMember = "productname";
                int productindex = ObjProductNameByCat.FindIndex(x => x.productid == GA_Common.ProID);                
                cmbProductName.SelectedIndex = productindex;
            }
        }
    }
}
