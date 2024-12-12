namespace Contact_Management_System
{
    partial class LoginForm
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
            passwordTxt = new TextBox();
            usernameTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            loginBtn = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(98, 67);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(158, 23);
            passwordTxt.TabIndex = 0;
            passwordTxt.UseSystemPasswordChar = true;
            // 
            // usernameTxt
            // 
            usernameTxt.Location = new Point(98, 38);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(158, 23);
            usernameTxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 41);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 2;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 70);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            label2.Click += label2_Click;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.PaleGreen;
            loginBtn.Location = new Point(136, 107);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(75, 23);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(136, 9);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 5;
            label3.Text = "ADMIN LOGIN";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(308, 141);
            Controls.Add(label3);
            Controls.Add(loginBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(usernameTxt);
            Controls.Add(passwordTxt);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox passwordTxt;
        private TextBox usernameTxt;
        private Label label1;
        private Label label2;
        private Button loginBtn;
        private Label label3;
    }
}