namespace WinFormsAppMSSQL
{
    partial class MainWin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            dsfdfdsToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel3 = new Panel();
            saveRecBtn = new Button();
            changeRecBtn = new Button();
            removeRecBtn = new Button();
            newRecBtn = new Button();
            label8 = new Label();
            panel2 = new Panel();
            priceLabel = new Label();
            supplierLabel = new Label();
            amountLabel = new Label();
            prodTypeLabel = new Label();
            idLabel = new Label();
            priceTextBox = new TextBox();
            supplierTextBox = new TextBox();
            amountTextBox = new TextBox();
            prodTypeTextBox = new TextBox();
            idTextBox = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            searchTextBox = new TextBox();
            searchBtn = new Button();
            refreshBtn = new Button();
            clearBtn = new Button();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dsfdfdsToolStripMenuItem, infoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1158, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dsfdfdsToolStripMenuItem
            // 
            dsfdfdsToolStripMenuItem.Name = "dsfdfdsToolStripMenuItem";
            dsfdfdsToolStripMenuItem.Size = new Size(46, 24);
            dsfdfdsToolStripMenuItem.Text = "File";
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(49, 24);
            infoToolStripMenuItem.Text = "Info";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(0, 31);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1158, 849);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1150, 816);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Department1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(saveRecBtn);
            panel3.Controls.Add(changeRecBtn);
            panel3.Controls.Add(removeRecBtn);
            panel3.Controls.Add(newRecBtn);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(696, 528);
            panel3.Name = "panel3";
            panel3.Size = new Size(448, 282);
            panel3.TabIndex = 3;
            // 
            // saveRecBtn
            // 
            saveRecBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            saveRecBtn.Location = new Point(101, 214);
            saveRecBtn.Name = "saveRecBtn";
            saveRecBtn.Size = new Size(270, 46);
            saveRecBtn.TabIndex = 15;
            saveRecBtn.Text = "Save";
            saveRecBtn.UseVisualStyleBackColor = true;
            saveRecBtn.Click += saveRecBtn_Click;
            // 
            // changeRecBtn
            // 
            changeRecBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            changeRecBtn.Location = new Point(101, 162);
            changeRecBtn.Name = "changeRecBtn";
            changeRecBtn.Size = new Size(270, 46);
            changeRecBtn.TabIndex = 14;
            changeRecBtn.Text = "Change";
            changeRecBtn.UseVisualStyleBackColor = true;
            changeRecBtn.Click += changeRecBtn_Click;
            // 
            // removeRecBtn
            // 
            removeRecBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            removeRecBtn.Location = new Point(101, 110);
            removeRecBtn.Name = "removeRecBtn";
            removeRecBtn.Size = new Size(270, 46);
            removeRecBtn.TabIndex = 13;
            removeRecBtn.Text = "Remove";
            removeRecBtn.UseVisualStyleBackColor = true;
            removeRecBtn.Click += removeRecBtn_Click;
            // 
            // newRecBtn
            // 
            newRecBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            newRecBtn.Location = new Point(101, 58);
            newRecBtn.Name = "newRecBtn";
            newRecBtn.Size = new Size(270, 46);
            newRecBtn.TabIndex = 12;
            newRecBtn.Text = "New";
            newRecBtn.UseVisualStyleBackColor = true;
            newRecBtn.Click += newRecBtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(101, 14);
            label8.Name = "label8";
            label8.Size = new Size(270, 37);
            label8.TabIndex = 11;
            label8.Text = "Record Management:";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(priceLabel);
            panel2.Controls.Add(supplierLabel);
            panel2.Controls.Add(amountLabel);
            panel2.Controls.Add(prodTypeLabel);
            panel2.Controls.Add(idLabel);
            panel2.Controls.Add(priceTextBox);
            panel2.Controls.Add(supplierTextBox);
            panel2.Controls.Add(amountTextBox);
            panel2.Controls.Add(prodTypeTextBox);
            panel2.Controls.Add(idTextBox);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(8, 528);
            panel2.Name = "panel2";
            panel2.Size = new Size(682, 282);
            panel2.TabIndex = 2;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            priceLabel.Location = new Point(201, 185);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(58, 28);
            priceLabel.TabIndex = 10;
            priceLabel.Text = "Price:";
            // 
            // supplierLabel
            // 
            supplierLabel.AutoSize = true;
            supplierLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            supplierLabel.Location = new Point(170, 151);
            supplierLabel.Name = "supplierLabel";
            supplierLabel.Size = new Size(89, 28);
            supplierLabel.TabIndex = 9;
            supplierLabel.Text = "Supplier:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            amountLabel.Location = new Point(172, 119);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(87, 28);
            amountLabel.TabIndex = 8;
            amountLabel.Text = "Amount:";
            // 
            // prodTypeLabel
            // 
            prodTypeLabel.AutoSize = true;
            prodTypeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            prodTypeLabel.Location = new Point(130, 87);
            prodTypeLabel.Name = "prodTypeLabel";
            prodTypeLabel.Size = new Size(129, 28);
            prodTypeLabel.TabIndex = 7;
            prodTypeLabel.Text = "Product type:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            idLabel.Location = new Point(224, 54);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(35, 28);
            idLabel.TabIndex = 6;
            idLabel.Text = "ID:";
            // 
            // priceTextBox
            // 
            priceTextBox.BorderStyle = BorderStyle.FixedSingle;
            priceTextBox.Location = new Point(265, 190);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(330, 27);
            priceTextBox.TabIndex = 5;
            // 
            // supplierTextBox
            // 
            supplierTextBox.BorderStyle = BorderStyle.FixedSingle;
            supplierTextBox.Location = new Point(265, 157);
            supplierTextBox.Name = "supplierTextBox";
            supplierTextBox.Size = new Size(330, 27);
            supplierTextBox.TabIndex = 4;
            // 
            // amountTextBox
            // 
            amountTextBox.BorderStyle = BorderStyle.FixedSingle;
            amountTextBox.Location = new Point(265, 124);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(330, 27);
            amountTextBox.TabIndex = 3;
            // 
            // prodTypeTextBox
            // 
            prodTypeTextBox.BorderStyle = BorderStyle.FixedSingle;
            prodTypeTextBox.Location = new Point(265, 91);
            prodTypeTextBox.Name = "prodTypeTextBox";
            prodTypeTextBox.Size = new Size(330, 27);
            prodTypeTextBox.TabIndex = 2;
            // 
            // idTextBox
            // 
            idTextBox.BorderStyle = BorderStyle.FixedSingle;
            idTextBox.Location = new Point(265, 58);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(330, 27);
            idTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(17, 14);
            label2.Name = "label2";
            label2.Size = new Size(105, 37);
            label2.TabIndex = 0;
            label2.Text = "Record:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1136, 454);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(searchTextBox);
            panel1.Controls.Add(searchBtn);
            panel1.Controls.Add(refreshBtn);
            panel1.Controls.Add(clearBtn);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1150, 62);
            panel1.TabIndex = 0;
            // 
            // searchTextBox
            // 
            searchTextBox.BorderStyle = BorderStyle.FixedSingle;
            searchTextBox.Location = new Point(871, 18);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(199, 27);
            searchTextBox.TabIndex = 4;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(1076, 3);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(68, 56);
            searchBtn.TabIndex = 3;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // refreshBtn
            // 
            refreshBtn.Location = new Point(797, 3);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(68, 56);
            refreshBtn.TabIndex = 2;
            refreshBtn.Text = "Refresh";
            refreshBtn.UseVisualStyleBackColor = true;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(723, 3);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(68, 56);
            clearBtn.TabIndex = 1;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(197, 37);
            label1.TabIndex = 0;
            label1.Text = "Department #1";
            // 
            // MainWin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 876);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainWin";
            Text = "MainWindow";
            Load += MainWin_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dsfdfdsToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private TextBox searchTextBox;
        private Button searchBtn;
        private Button refreshBtn;
        private Button clearBtn;
        private Label label1;
        private Panel panel3;
        private Panel panel2;
        private Label label2;
        private TextBox priceTextBox;
        private TextBox supplierTextBox;
        private TextBox amountTextBox;
        private TextBox prodTypeTextBox;
        private TextBox idTextBox;
        private Label priceLabel;
        private Label supplierLabel;
        private Label amountLabel;
        private Label prodTypeLabel;
        private Label idLabel;
        private Label label8;
        private Button saveRecBtn;
        private Button changeRecBtn;
        private Button removeRecBtn;
        private Button newRecBtn;
    }
}