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
    public partial class LogIn : Form
    {
        private DbContext _db = new DbContext();

        public LogIn()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '*';
            hideBtn.Visible = false;
            logInTextBox.MaxLength = 50;
            passwordTextBox.MaxLength = 50;
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            var userLogin = logInTextBox.Text;
            var userPass = passwordTextBox.Text;

            var adapter = new SqlDataAdapter();
            var table = new DataTable();

            string query = $"SELECT id, users_login, users_password FROM Register WHERE users_login = '{userLogin}' AND users_password = '{userPass}'";

            var command = new SqlCommand(query, _db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("You have successfully logged in!", "Logged in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var mainForm = new MainWin();
                this.Hide();
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("There's no account with entered data.", "No account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void noAccLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            var signUpWin = new SignUp();
            signUpWin.ShowDialog();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            logInTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '\0';
            showBtn.Visible = false;
            hideBtn.Visible = true;
        }

        private void hideBtn_Click(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '*';
            hideBtn.Visible = false;
            showBtn.Visible = true;
        }
    }
}
