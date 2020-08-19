﻿using GroupAProducts.Model;
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
            //string constring = @"Server=127.0.0.1;Port=5432;Database=basicsql;User Id=postgres;Password=yamin-mmocc;Timeout=15;";
            //using (NpgsqlConnection con = new NpgsqlConnection(constring))
            //{
            //    using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM Customers", con))
            //    {
            //        cmd.CommandType = CommandType.Text;
            //        using (NpgsqlDataAdapter sda = new NpgsqlDataAdapter(cmd))
            //        {
            //            using (DataTable dt = new DataTable())
            //            {
            //                sda.Fill(dt);

            //                //Set AutoGenerateColumns False
            //                dGV_ProductDetail.AutoGenerateColumns = false;

            //                //Set Columns Count
            //                dGV_ProductDetail.ColumnCount = 4;

            //                //Add Columns
            //                dGV_ProductDetail.Columns[0].Name = "ProductID";
            //                dGV_ProductDetail.Columns[0].HeaderText = "Number";
            //                dGV_ProductDetail.Columns[0].DataPropertyName = "ProductID";

            //                dGV_ProductDetail.Columns[1].Name = "BrandName";
            //                dGV_ProductDetail.Columns[1].HeaderText = "Brand Name";
            //                dGV_ProductDetail.Columns[1].DataPropertyName = "BrandName";

            //                dGV_ProductDetail.Columns[2].Name = "ProductName";
            //                dGV_ProductDetail.Columns[2].HeaderText = "Product Name";
            //                dGV_ProductDetail.Columns[2].DataPropertyName = "ProductName";

            //                dGV_ProductDetail.Columns[3].Name = "Qty";
            //                dGV_ProductDetail.Columns[3].HeaderText = "Quantity";
            //                dGV_ProductDetail.Columns[3].DataPropertyName = "Qty";

            //                dGV_ProductDetail.DataSource = dt;
            //            }
            //        }
            //    }
            //}

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
