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
    public partial class CreateBrand : Form
    {
        private MainForm MainForm;
        ProductRepository prodRepo = new ProductRepository();
        string error = "";
        public CreateBrand()
        {
            InitializeComponent();
        }

        public void refreshdata()
        {
            //Auto Generate BrandID                
            GA_Common.BrandAutoID = prodRepo.getProductNoSeries("Brand", out error);
            txtBrandID.Text = GA_Common.BrandAutoID;            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GA_Common.objBrand = new Brand();

            GA_Common.objBrand.brandid = GA_Common.BrandAutoID;

            DialogResult = MessageBox.Show("Are you sure to SAVE data",
                                "Confirmation", MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                //check product name data
                if (txtBrandName.Text == "")
                    MessageBox.Show("Enter Product Name!",
                                "Information", MessageBoxButtons.OK);
                else
                    GA_Common.objBrand.brandname = txtBrandName.Text;
                
                ReturnDataModel ObjSaveBrand = prodRepo.saveBrand(GA_Common.objBrand, out error);
                if (ObjSaveBrand.retStatus == true)
                {
                    MessageBox.Show("Successfully SAVE!",
                                "Information", MessageBoxButtons.OK);
                    //clear autoid textbox
                    GA_Common.BrandAutoID = null;
                }
                else
                {
                    MessageBox.Show(ObjSaveBrand.errorMsg,
                                "Information", MessageBoxButtons.OK);
                }

            }
            else if (DialogResult == DialogResult.No)
            {
                //this.Close();
            }

            this.Close();            
        }

        private void CreateBrand_Load(object sender, EventArgs e)
        {
            refreshdata();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm = new MainForm();
            MainForm.Show();
        }
    }
}
