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
    public partial class SignUp : Form
    {
        private DbContext db = new DbContext();

        public SignUp()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '*';
            hideBtn.Visible = false;
            logInTextBox.MaxLength = 50;
            passwordTextBox.MaxLength = 50;
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {

            var login = logInTextBox.Text;
            var password = passwordTextBox.Text;

            var query = $"INSERT INTO Register (users_login, users_password) VALUES ('{login}', '{password}')";

            var command = new SqlCommand(query, db.GetConnection());

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Account was created successfully!", "An account created", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                var logInWin = new LogIn();
                logInWin.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Account wasn't created", "An account wasn't created", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.CloseConnection();
        }

        private bool CheckUser()
        {
            var login = logInTextBox.Text;
            var password = passwordTextBox.Text;

            var adapter = new SqlDataAdapter();
            var table = new DataTable();
            
            string query = $"SELECT id, users_login, users_password FROM Register WHERE users_login = '{login}' AND users_password = '{password}'";
            var command = new SqlCommand(query, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("The account is already created!", "An account is already created", MessageBoxButtons.OK, MessageBoxIcon.Information);
             
                return true;
            }

            return false;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            logInTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
        }

        private void hideBtn_Click(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '*';
            hideBtn.Visible = false;
            showBtn.Visible = true;
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '\0';
            showBtn.Visible = false;
            hideBtn.Visible = true;
        }
    }
}
