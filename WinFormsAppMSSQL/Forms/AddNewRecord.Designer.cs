namespace WinFormsAppMSSQL.Forms
{
    partial class AddNewRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            infoBtn = new Button();
            clearBtn = new Button();
            priceLabel = new Label();
            supplierLabel = new Label();
            amountLabel = new Label();
            prodTypeLabel = new Label();
            priceTextBox = new TextBox();
            supplierTextBox = new TextBox();
            amountTextBox = new TextBox();
            prodTypeTextBox = new TextBox();
            saveRecBtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(3, 47);
            label1.Name = "label1";
            label1.Size = new Size(126, 23);
            label1.TabIndex = 0;
            label1.Text = "Department #1";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(infoBtn);
            panel1.Controls.Add(clearBtn);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 86);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(3, 14);
            label2.Name = "label2";
            label2.Size = new Size(147, 32);
            label2.TabIndex = 3;
            label2.Text = "New Record:";
            // 
            // infoBtn
            // 
            infoBtn.Location = new Point(613, 14);
            infoBtn.Name = "infoBtn";
            infoBtn.Size = new Size(68, 56);
            infoBtn.TabIndex = 2;
            infoBtn.Text = "Info";
            infoBtn.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(707, 14);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(68, 56);
            clearBtn.TabIndex = 1;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            priceLabel.Location = new Point(189, 270);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(58, 28);
            priceLabel.TabIndex = 18;
            priceLabel.Text = "Price:";
            // 
            // supplierLabel
            // 
            supplierLabel.AutoSize = true;
            supplierLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            supplierLabel.Location = new Point(158, 236);
            supplierLabel.Name = "supplierLabel";
            supplierLabel.Size = new Size(89, 28);
            supplierLabel.TabIndex = 17;
            supplierLabel.Text = "Supplier:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            amountLabel.Location = new Point(160, 204);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(87, 28);
            amountLabel.TabIndex = 16;
            amountLabel.Text = "Amount:";
            // 
            // prodTypeLabel
            // 
            prodTypeLabel.AutoSize = true;
            prodTypeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            prodTypeLabel.Location = new Point(118, 172);
            prodTypeLabel.Name = "prodTypeLabel";
            prodTypeLabel.Size = new Size(129, 28);
            prodTypeLabel.TabIndex = 15;
            prodTypeLabel.Text = "Product type:";
            // 
            // priceTextBox
            // 
            priceTextBox.BorderStyle = BorderStyle.FixedSingle;
            priceTextBox.Location = new Point(253, 275);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(330, 27);
            priceTextBox.TabIndex = 14;
            // 
            // supplierTextBox
            // 
            supplierTextBox.BorderStyle = BorderStyle.FixedSingle;
            supplierTextBox.Location = new Point(253, 242);
            supplierTextBox.Name = "supplierTextBox";
            supplierTextBox.Size = new Size(330, 27);
            supplierTextBox.TabIndex = 13;
            // 
            // amountTextBox
            // 
            amountTextBox.BorderStyle = BorderStyle.FixedSingle;
            amountTextBox.Location = new Point(253, 209);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(330, 27);
            amountTextBox.TabIndex = 12;
            // 
            // prodTypeTextBox
            // 
            prodTypeTextBox.BorderStyle = BorderStyle.FixedSingle;
            prodTypeTextBox.Location = new Point(253, 176);
            prodTypeTextBox.Name = "prodTypeTextBox";
            prodTypeTextBox.Size = new Size(330, 27);
            prodTypeTextBox.TabIndex = 11;
            // 
            // saveRecBtn
            // 
            saveRecBtn.BackColor = SystemColors.ActiveBorder;
            saveRecBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            saveRecBtn.Location = new Point(282, 344);
            saveRecBtn.Name = "saveRecBtn";
            saveRecBtn.Size = new Size(270, 46);
            saveRecBtn.TabIndex = 19;
            saveRecBtn.Text = "Save";
            saveRecBtn.UseVisualStyleBackColor = false;
            saveRecBtn.Click += saveRecBtn_Click;
            // 
            // AddNewRecord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 457);
            Controls.Add(saveRecBtn);
            Controls.Add(priceLabel);
            Controls.Add(supplierLabel);
            Controls.Add(amountLabel);
            Controls.Add(prodTypeLabel);
            Controls.Add(priceTextBox);
            Controls.Add(supplierTextBox);
            Controls.Add(amountTextBox);
            Controls.Add(prodTypeTextBox);
            Controls.Add(panel1);
            Name = "AddNewRecord";
            Text = "AddNewRecord";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Button infoBtn;
        private Button clearBtn;
        private Label priceLabel;
        private Label supplierLabel;
        private Label amountLabel;
        private Label prodTypeLabel;
        private TextBox priceTextBox;
        private TextBox supplierTextBox;
        private TextBox amountTextBox;
        private TextBox prodTypeTextBox;
        private Button saveRecBtn;
    }
}