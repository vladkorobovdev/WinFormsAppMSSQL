namespace WinFormsAppMSSQL.Forms
{
    partial class SignUp
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
            registrationLabel = new Label();
            topPanel = new Panel();
            clearBtn = new Button();
            passwordTextLabel = new Label();
            logInTextLabel = new Label();
            signUpBtn = new Button();
            passwordTextBox = new TextBox();
            logInTextBox = new TextBox();
            hideBtn = new Button();
            shiwBtn = new Button();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // registrationLabel
            // 
            registrationLabel.AutoSize = true;
            registrationLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            registrationLabel.Location = new Point(18, 16);
            registrationLabel.Name = "registrationLabel";
            registrationLabel.Size = new Size(215, 46);
            registrationLabel.TabIndex = 0;
            registrationLabel.Text = "Registration";
            // 
            // topPanel
            // 
            topPanel.BackColor = SystemColors.ActiveBorder;
            topPanel.Controls.Add(clearBtn);
            topPanel.Controls.Add(registrationLabel);
            topPanel.Location = new Point(12, 12);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(776, 86);
            topPanel.TabIndex = 7;
            // 
            // clearBtn
            // 
            clearBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            clearBtn.Location = new Point(659, 3);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(114, 80);
            clearBtn.TabIndex = 1;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            // 
            // passwordTextLabel
            // 
            passwordTextLabel.AutoSize = true;
            passwordTextLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextLabel.Location = new Point(186, 250);
            passwordTextLabel.Name = "passwordTextLabel";
            passwordTextLabel.Size = new Size(116, 32);
            passwordTextLabel.TabIndex = 12;
            passwordTextLabel.Text = "Password:";
            // 
            // logInTextLabel
            // 
            logInTextLabel.AutoSize = true;
            logInTextLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            logInTextLabel.Location = new Point(224, 180);
            logInTextLabel.Name = "logInTextLabel";
            logInTextLabel.Size = new Size(78, 32);
            logInTextLabel.TabIndex = 11;
            logInTextLabel.Text = "Login:";
            // 
            // signUpBtn
            // 
            signUpBtn.BackColor = SystemColors.ActiveBorder;
            signUpBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            signUpBtn.Location = new Point(331, 324);
            signUpBtn.Name = "signUpBtn";
            signUpBtn.Size = new Size(144, 58);
            signUpBtn.TabIndex = 10;
            signUpBtn.Text = "Sign Up";
            signUpBtn.UseVisualStyleBackColor = false;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(308, 244);
            passwordTextBox.Multiline = true;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(186, 48);
            passwordTextBox.TabIndex = 9;
            // 
            // logInTextBox
            // 
            logInTextBox.BorderStyle = BorderStyle.FixedSingle;
            logInTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            logInTextBox.Location = new Point(308, 174);
            logInTextBox.Multiline = true;
            logInTextBox.Name = "logInTextBox";
            logInTextBox.Size = new Size(186, 48);
            logInTextBox.TabIndex = 8;
            // 
            // hideBtn
            // 
            hideBtn.Location = new Point(500, 255);
            hideBtn.Name = "hideBtn";
            hideBtn.Size = new Size(53, 29);
            hideBtn.TabIndex = 14;
            hideBtn.Text = "Hide";
            hideBtn.UseVisualStyleBackColor = true;
            // 
            // shiwBtn
            // 
            shiwBtn.Location = new Point(500, 255);
            shiwBtn.Name = "shiwBtn";
            shiwBtn.Size = new Size(53, 29);
            shiwBtn.TabIndex = 13;
            shiwBtn.Text = "Show";
            shiwBtn.UseVisualStyleBackColor = true;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(hideBtn);
            Controls.Add(shiwBtn);
            Controls.Add(topPanel);
            Controls.Add(passwordTextLabel);
            Controls.Add(logInTextLabel);
            Controls.Add(signUpBtn);
            Controls.Add(passwordTextBox);
            Controls.Add(logInTextBox);
            Name = "SignUp";
            Text = "SignUp";
            Load += SignUp_Load;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label registrationLabel;
        private Panel topPanel;
        private Button clearBtn;
        private Label passwordTextLabel;
        private Label logInTextLabel;
        private Button signUpBtn;
        private TextBox passwordTextBox;
        private TextBox logInTextBox;
        private Button hideBtn;
        private Button shiwBtn;
    }
}