namespace LoginApp
{
    partial class LoginForm
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
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblUserName = new Label();
            lblPassword = new Label();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(275, 94);
            txtUserName.Margin = new Padding(2, 2, 2, 2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(263, 27);
            txtUserName.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(275, 152);
            txtPassword.Margin = new Padding(2, 2, 2, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(263, 27);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(378, 210);
            btnLogin.Margin = new Padding(2, 2, 2, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(90, 27);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(191, 96);
            lblUserName.Margin = new Padding(2, 0, 2, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(82, 20);
            lblUserName.TabIndex = 3;
            lblUserName.Text = "User Name";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(191, 157);
            lblPassword.Margin = new Padding(2, 0, 2, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(350, 292);
            lblStatus.Margin = new Padding(2, 0, 2, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(90, 20);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Login Status";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 425);
            Controls.Add(lblStatus);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Margin = new Padding(2, 2, 2, 2);
            Name = "LoginForm";
            Text = "Login Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblUserName;
        private Label lblPassword;
        private Label lblStatus;
    }
}