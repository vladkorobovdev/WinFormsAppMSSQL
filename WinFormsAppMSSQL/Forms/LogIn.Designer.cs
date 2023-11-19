namespace WinFormsAppMSSQL.Forms
{
    partial class LogIn
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
            topPanel = new Panel();
            clearBtn = new Button();
            logInLabel = new Label();
            logInTextBox = new TextBox();
            passwordTextBox = new TextBox();
            logInBtn = new Button();
            logInTextLabel = new Label();
            passwordTextLabel = new Label();
            noAccLink = new LinkLabel();
            shiwBtn = new Button();
            hideBtn = new Button();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = SystemColors.ActiveBorder;
            topPanel.Controls.Add(clearBtn);
            topPanel.Controls.Add(logInLabel);
            topPanel.Location = new Point(12, 12);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(776, 86);
            topPanel.TabIndex = 0;
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
            // logInLabel
            // 
            logInLabel.AutoSize = true;
            logInLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            logInLabel.Location = new Point(18, 16);
            logInLabel.Name = "logInLabel";
            logInLabel.Size = new Size(119, 46);
            logInLabel.TabIndex = 0;
            logInLabel.Text = "Log in";
            // 
            // logInTextBox
            // 
            logInTextBox.BorderStyle = BorderStyle.FixedSingle;
            logInTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            logInTextBox.Location = new Point(308, 174);
            logInTextBox.Multiline = true;
            logInTextBox.Name = "logInTextBox";
            logInTextBox.Size = new Size(186, 48);
            logInTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(308, 244);
            passwordTextBox.Multiline = true;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(186, 48);
            passwordTextBox.TabIndex = 2;
            // 
            // logInBtn
            // 
            logInBtn.BackColor = SystemColors.ActiveBorder;
            logInBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            logInBtn.Location = new Point(331, 324);
            logInBtn.Name = "logInBtn";
            logInBtn.Size = new Size(144, 58);
            logInBtn.TabIndex = 3;
            logInBtn.Text = "Log in";
            logInBtn.UseVisualStyleBackColor = false;
            // 
            // logInTextLabel
            // 
            logInTextLabel.AutoSize = true;
            logInTextLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            logInTextLabel.Location = new Point(224, 180);
            logInTextLabel.Name = "logInTextLabel";
            logInTextLabel.Size = new Size(78, 32);
            logInTextLabel.TabIndex = 4;
            logInTextLabel.Text = "Login:";
            // 
            // passwordTextLabel
            // 
            passwordTextLabel.AutoSize = true;
            passwordTextLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextLabel.Location = new Point(186, 250);
            passwordTextLabel.Name = "passwordTextLabel";
            passwordTextLabel.Size = new Size(116, 32);
            passwordTextLabel.TabIndex = 5;
            passwordTextLabel.Text = "Password:";
            // 
            // noAccLink
            // 
            noAccLink.AutoSize = true;
            noAccLink.Location = new Point(308, 407);
            noAccLink.Name = "noAccLink";
            noAccLink.Size = new Size(187, 20);
            noAccLink.TabIndex = 6;
            noAccLink.TabStop = true;
            noAccLink.Text = "Don't have an account yet?";
            // 
            // shiwBtn
            // 
            shiwBtn.Location = new Point(500, 255);
            shiwBtn.Name = "shiwBtn";
            shiwBtn.Size = new Size(53, 29);
            shiwBtn.TabIndex = 7;
            shiwBtn.Text = "Show";
            shiwBtn.UseVisualStyleBackColor = true;
            // 
            // hideBtn
            // 
            hideBtn.Location = new Point(500, 255);
            hideBtn.Name = "hideBtn";
            hideBtn.Size = new Size(53, 29);
            hideBtn.TabIndex = 8;
            hideBtn.Text = "Hide";
            hideBtn.UseVisualStyleBackColor = true;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(hideBtn);
            Controls.Add(shiwBtn);
            Controls.Add(noAccLink);
            Controls.Add(passwordTextLabel);
            Controls.Add(logInTextLabel);
            Controls.Add(logInBtn);
            Controls.Add(passwordTextBox);
            Controls.Add(logInTextBox);
            Controls.Add(topPanel);
            Name = "LogIn";
            Text = "LogIn";
            Load += LogIn_Load;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel topPanel;
        private Label logInLabel;
        private Button clearBtn;
        private TextBox logInTextBox;
        private TextBox passwordTextBox;
        private Button logInBtn;
        private Label logInTextLabel;
        private Label passwordTextLabel;
        private LinkLabel noAccLink;
        private Button shiwBtn;
        private Button hideBtn;
    }
}