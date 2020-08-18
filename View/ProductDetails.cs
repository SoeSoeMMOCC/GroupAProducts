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
