using System.Data;
using System.Data.SqlClient;
using WinFormsAppMSSQL.Forms;

namespace WinFormsAppMSSQL
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class MainWin : Form
    {
        private DbContext db = new DbContext();
        private int selectedRow;

        public MainWin()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ClearFields()
        {
            idTextBox.Text = string.Empty;
            prodTypeTextBox.Text = string.Empty;
            amountTextBox.Text = string.Empty;
            supplierTextBox.Text = string.Empty;
            priceTextBox.Text = string.Empty;
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "Id");
            dataGridView1.Columns.Add("type_of", "Product type");
            dataGridView1.Columns.Add("amount_of", "Amount");
            dataGridView1.Columns.Add("supplier", "Supplier");
            dataGridView1.Columns.Add("price", "Price");
            dataGridView1.Columns.Add("isNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetString(3), record.GetInt32(4), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string query = $"SELECT * FROM MainTable";
            var command = new SqlCommand(query, db.GetConnection());

            db.OpenConnection();

            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void MainWin_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                idTextBox.Text = row.Cells[0].Value.ToString();
                prodTypeTextBox.Text = row.Cells[1].Value.ToString();
                amountTextBox.Text = row.Cells[2].Value.ToString();
                supplierTextBox.Text = row.Cells[3].Value.ToString();
                priceTextBox.Text = row.Cells[4].Value.ToString();
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void newRecBtn_Click(object sender, EventArgs e)
        {
            var addRec = new AddNewRecord();
            addRec.Show();
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            var query = $"SELECT * FROM MainTable WHERE CONCAT (id, product_type, product_amount, supply, price) LIKE '%" + searchTextBox.Text + "%'";
            var command = new SqlCommand(query, db.GetConnection());

            db.OpenConnection();

            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }

            db.CloseConnection();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void RemoveRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible = false;     // First hide the row, then send query for deleting into DB

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
        }

        private void removeRecBtn_Click(object sender, EventArgs e)
        {
            RemoveRow();
            ClearFields();
        }

        private void Update()
        {
            db.OpenConnection();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var rowState = (RowState)dataGridView1.Rows[i].Cells[5].Value;

                if (rowState == RowState.Existed)
                {
                    continue;
                }

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    var query = $"DELETE FROM MainTable WHERE id = {id}";
                    var command = new SqlCommand(query, db.GetConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    var type = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    var amount = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    var supplier = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    var price = dataGridView1.Rows[i].Cells[4].Value.ToString();

                    var query = $"UPDATE MainTable SET product_type = '{type}', product_amount = '{amount}', supply = '{supplier}', price = '{price}' WHERE id = '{id}'";
                    var command = new SqlCommand(query, db.GetConnection());
                    command.ExecuteNonQuery();
                }
            }

            db.CloseConnection();
        }

        private void saveRecBtn_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void changeRecBtn_Click(object sender, EventArgs e)
        {
            Change();
            ClearFields();
        }

        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = idTextBox.Text;
            var type = prodTypeTextBox.Text;
            var amount = amountTextBox.Text;
            var supplier = supplierTextBox.Text;
            int price;

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(priceTextBox.Text, out price))
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(id, type, amount, supplier, price);
                    dataGridView1.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("The price must be integer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}