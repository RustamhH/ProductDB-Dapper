using Database.Entities;
using Microsoft.Data.SqlClient;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ProductDB_Dapper
{
    public partial class Form2 : Form
    {
        private SqlConnection connection;
        public string ProductName { get; set; }
        public string Country { get; set; }
        public string Cost { get; set; }
        public Form2()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=HOMEPC\\SQLEXPRESS;Initial Catalog=Products;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            ProductName = NameTextBox.Text;
            Country = CountryTextBox.Text;
            Cost = CostTextBox.Text;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product
            {
                Name = ProductName,
                Country = Country,
                Cost = Convert.ToDecimal(Cost)
            };

            connection.Execute("INSERT INTO Products (Name, Country, Cost) VALUES (@Name, @Country, @Cost)", newProduct);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = "";
            CountryTextBox.Text = "";
            CostTextBox.Text = "";
        }
    }
}
