using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GroupAProducts.Common;
using GroupAProducts.Model;
using GroupAProducts.Repository;

namespace GroupAProducts.View
{
    public partial class CreateCategory : Form
    {
        private MainForm MainForm;
        ProductRepository prodRepo = new ProductRepository();
        string error = "";

        public CreateCategory()
        {
            InitializeComponent();
        }

        private void CreateCategory_Load(object sender, EventArgs e)
        {
            refreshdata();
        }

        public void refreshdata()
        {
            //ProCategoryAutoID                
            GA_Common.ProCategoryAutoID = prodRepo.getProductNoSeries("ProductCategory", out error);
            txtcatID.Text = GA_Common.ProCategoryAutoID;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GA_Common.objProductCategory = new CategoryModel();

            GA_Common.objProductCategory.pcatid = GA_Common.ProCategoryAutoID;

            DialogResult = MessageBox.Show("Are you sure to SAVE data",
                                "Confirmation", MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                //check product Category name data
                if (txtCatName.Text == "")
                    MessageBox.Show("Enter Product Category Name!",
                                "Information", MessageBoxButtons.OK);
                else
                    GA_Common.objProductCategory.pcatname = txtCatName.Text;

               
                ReturnDataModel ObjSaveCategory = prodRepo.saveCategory(GA_Common.objProductCategory, out error);
                if (ObjSaveCategory.retStatus == true)
                {
                    MessageBox.Show("Successfully SAVE!",
                                "Information", MessageBoxButtons.OK);
                    //clear autoid textbox
                    GA_Common.ProCategoryAutoID = null;
                }
                else
                {
                    MessageBox.Show(ObjSaveCategory.errorMsg,
                                "Information", MessageBoxButtons.OK);
                }

            }
            else if (DialogResult == DialogResult.No)
            {
                //this.Close();
            }

            this.Close();           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm = new MainForm();
            MainForm.Show();
        }
    }
}
