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

namespace GroupAProducts.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            BindGrid();
        }
        private void BindGrid()
        {
            string constring = @"Server=127.0.0.1;Port=5432;Database=basicsql;User Id=postgres;Password=yamin-mmocc;Timeout=15;";
            using (NpgsqlConnection con = new NpgsqlConnection(constring))
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM Customers", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (NpgsqlDataAdapter sda = new NpgsqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);

                            //Set AutoGenerateColumns False
                            dGV_ProductDetail.AutoGenerateColumns = false;

                            //Set Columns Count
                            dGV_ProductDetail.ColumnCount = 4;

                            //Add Columns
                            dGV_ProductDetail.Columns[0].Name = "ProductID";
                            dGV_ProductDetail.Columns[0].HeaderText = "Number";
                            dGV_ProductDetail.Columns[0].DataPropertyName = "ProductID";

                            dGV_ProductDetail.Columns[1].Name = "BrandName";
                            dGV_ProductDetail.Columns[1].HeaderText = "Brand Name";
                            dGV_ProductDetail.Columns[1].DataPropertyName = "BrandName";

                            dGV_ProductDetail.Columns[2].Name = "ProductName";
                            dGV_ProductDetail.Columns[2].HeaderText = "Product Name";
                            dGV_ProductDetail.Columns[2].DataPropertyName = "ProductName";

                            dGV_ProductDetail.Columns[3].Name = "Qty";
                            dGV_ProductDetail.Columns[3].HeaderText = "Quantity";
                            dGV_ProductDetail.Columns[3].DataPropertyName = "Qty";

                            dGV_ProductDetail.DataSource = dt;
                        }
                    }
                }
            }
        }
    }
}
