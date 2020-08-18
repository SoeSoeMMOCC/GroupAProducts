using GroupAProducts.Model;
using GroupAProducts.Repository;
using GroupAProducts.SSMModel;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupAProducts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //String constring = "Server=127.0.0.1;Port=5432;Database=basicsql;User Id=postgres;Password=ssmroot;Timeout=15;";
                //NpgsqlConnection conDataBase = new NpgsqlConnection(constring);
                //conDataBase.Open();
                //string query = @"select customerid,customername from customers;";
                //MessageBox.Show("Hello Success");
                //NpgsqlDataAdapter sda = new NpgsqlDataAdapter(query, constring);
                //DataTable dbdataset = new DataTable();
                //sda.Fill(dbdataset);
                //ProductGridView.DataSource = dbdataset;

                ////Bind the data tothe GridView to display table data
                //BindingSource bsource = new BindingSource();
                //bsource.DataSource = dbdataset;
                //ProductGridView.DataSource = bsource;

                ////Resize the DataGridView columns to fit the newly loaded content
                //ProductGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                List<Loginhistory> loginreturn = new List<Loginhistory>();
                List<ProductDetailModel> productlist = new List<ProductDetailModel>();
                string error = "";
                ProductRepository prodRepo = new ProductRepository();
                productlist = prodRepo.getProductDetailList("%","%","%","%", out error);
                //MessageBox.Show(loginreturn.Count().ToString());
                ProductGridView.DataSource = loginreturn;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProductGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }
    }
}
