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
        public Product EditedProduct { get; set; } = null;
        public Form2(Product editedProduct=null)
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=STHQ012E-07;Initial Catalog=Products;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            if(editedProduct!=null)
            {
                EditedProduct=editedProduct;
                NameTextBox.Text = EditedProduct.Name;
                CountryTextBox.Text = EditedProduct.Country;
                CostTextBox.Text = EditedProduct.Cost.ToString();
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if(EditedProduct!=null) // for edit product
            {

                EditedProduct.Name = NameTextBox.Text;
                EditedProduct.Country = CountryTextBox.Text;
                decimal.TryParse(CostTextBox.Text, out decimal Cost);
                EditedProduct.Cost=Cost;
                Product editedProduct = new Product()
                {
                    Id = EditedProduct.Id,
                    Name = EditedProduct.Name,
                    Country = EditedProduct.Country,
                    Cost = EditedProduct.Cost
                };
                connection.Execute("UPDATE Products SET Name=@Name,Country=@Country,Cost=@Cost WHERE Id=@Id",editedProduct);
            }
            else
            {
                decimal.TryParse(CostTextBox.Text, out decimal Cost);
                Product newProduct = new Product
                {
                    Name = NameTextBox.Text,
                    Country = CountryTextBox.Text,
                    Cost = Cost
                };

                connection.Execute("INSERT INTO Products (Name, Country, Cost) VALUES (@Name, @Country, @Cost)", newProduct);
            }
            
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = "";
            CountryTextBox.Text = "";
            CostTextBox.Text = "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
