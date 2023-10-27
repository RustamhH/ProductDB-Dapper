using Dapper;
using Database.Entities;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace ProductDB_Dapper
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=HOMEPC\\SQLEXPRESS;Initial Catalog=Products;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            WriteData();   
        }

        private void WriteData()
        {
            ProductsList.Items.Clear();
            connection.Open();
            var Products = connection.Query<Product>("SELECT * FROM Products").ToList();
            foreach (var product in Products)
            {
                ProductsList.Items.Add($"{product.Id}-{product.Name}-{product.Country}-{product.Cost}");
            }
            connection.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ProductsList.Items.Clear();
            connection.Execute("TRUNCATE TABLE Products");
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                WriteData();
            }
        }
    }
}