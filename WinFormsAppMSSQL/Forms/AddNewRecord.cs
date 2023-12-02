using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppMSSQL.Forms
{
    public partial class AddNewRecord : Form
    {
        private DbContext db = new DbContext();

        public AddNewRecord()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }

        private void saveRecBtn_Click(object sender, EventArgs e)
        {
            db.OpenConnection();

            var type = prodTypeTextBox.Text;
            var amount = amountTextBox.Text;
            var supplier = supplierTextBox.Text;
            int price;

            if (int.TryParse(priceTextBox.Text, out price))   // Check if price is integer in textBox; return value to price variable if true
            {
                var query = $"INSERT INTO MainTable (product_type, product_amount, supply, price) VALUES ('{type}', '{amount}', '{supplier}', '{price}')";
                var command = new SqlCommand(query, db.GetConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Record successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The price must be integer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            db.CloseConnection();

        }
    }
}
