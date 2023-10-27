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
            connection = new SqlConnection("Data Source=STHQ012E-07;User ID=admin;Password=admin;Initial Catalog=Products;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            WriteData();
        }

        private void WriteData()
        {
            ProductsList.Items.Clear();
            connection.Open();
            var Products = connection.Query<Product>("SELECT * FROM Products").ToList();
            foreach (var product in Products)
            {
                ProductsList.Items.Add(product);
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
            form2.ShowDialog();
            WriteData();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            connection.Execute($"DELETE FROM Products WHERE Id={(ProductsList.SelectedItem as Product).Id}");
            WriteData();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new(ProductsList.SelectedItem as Product);
            form2.ShowDialog();
            WriteData();
        }
    }
}