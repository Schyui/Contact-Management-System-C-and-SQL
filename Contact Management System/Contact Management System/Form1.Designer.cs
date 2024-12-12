namespace Contact_Management_System
{
    partial class Form1
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            ViewDataBtn = new Button();
            instertBtn = new Button();
            updateBtn = new Button();
            deleteBtn = new Button();
            exitBtn = new Button();
            firstNameTxt = new TextBox();
            midNameTxt = new TextBox();
            lastNameTxt = new TextBox();
            contactTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            emailTxt = new TextBox();
            label6 = new Label();
            statusTxt = new TextBox();
            label7 = new Label();
            citizenTxt = new TextBox();
            label8 = new Label();
            label9 = new Label();
            regNoTxt = new TextBox();
            printBtn = new Button();
            deleteBox = new TextBox();
            label10 = new Label();
            searchBox = new TextBox();
            searchBtn = new Button();
            label12 = new Label();
            pictureBox1 = new PictureBox();
            signOutBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.SeaShell;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightBlue;
            dataGridViewCellStyle2.Font = new Font("Yu Gothic", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.Tan;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LightSteelBlue;
            dataGridViewCellStyle3.Font = new Font("Yu Gothic", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Location = new Point(343, 182);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.BurlyWood;
            dataGridViewCellStyle4.Font = new Font("Yu Gothic", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Size = new Size(781, 313);
            dataGridView1.TabIndex = 0;
            // 
            // ViewDataBtn
            // 
            ViewDataBtn.Enabled = false;
            ViewDataBtn.ForeColor = SystemColors.ButtonFace;
            ViewDataBtn.Location = new Point(1094, 621);
            ViewDataBtn.Name = "ViewDataBtn";
            ViewDataBtn.Size = new Size(16, 25);
            ViewDataBtn.TabIndex = 1;
            ViewDataBtn.Text = "View";
            ViewDataBtn.UseVisualStyleBackColor = true;
            ViewDataBtn.Visible = false;
            ViewDataBtn.Click += ViewDataBtn_Click;
            // 
            // instertBtn
            // 
            instertBtn.BackColor = Color.YellowGreen;
            instertBtn.FlatStyle = FlatStyle.Popup;
            instertBtn.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            instertBtn.ForeColor = SystemColors.ButtonFace;
            instertBtn.Location = new Point(133, 497);
            instertBtn.Name = "instertBtn";
            instertBtn.Size = new Size(90, 35);
            instertBtn.TabIndex = 2;
            instertBtn.Text = "Add";
            instertBtn.UseVisualStyleBackColor = false;
            instertBtn.Click += instertBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.RoyalBlue;
            updateBtn.FlatStyle = FlatStyle.Popup;
            updateBtn.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            updateBtn.ForeColor = SystemColors.ButtonFace;
            updateBtn.Location = new Point(236, 497);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(90, 35);
            updateBtn.TabIndex = 3;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Red;
            deleteBtn.FlatStyle = FlatStyle.Popup;
            deleteBtn.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            deleteBtn.ForeColor = SystemColors.ControlLightLight;
            deleteBtn.Location = new Point(538, 543);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(87, 35);
            deleteBtn.TabIndex = 4;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Black;
            exitBtn.FlatStyle = FlatStyle.Popup;
            exitBtn.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            exitBtn.ForeColor = SystemColors.ButtonFace;
            exitBtn.Location = new Point(1049, 510);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(75, 32);
            exitBtn.TabIndex = 5;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // firstNameTxt
            // 
            firstNameTxt.BackColor = Color.SeaShell;
            firstNameTxt.Location = new Point(132, 215);
            firstNameTxt.Name = "firstNameTxt";
            firstNameTxt.Size = new Size(196, 27);
            firstNameTxt.TabIndex = 6;
            // 
            // midNameTxt
            // 
            midNameTxt.BackColor = Color.SeaShell;
            midNameTxt.Location = new Point(132, 248);
            midNameTxt.Name = "midNameTxt";
            midNameTxt.Size = new Size(196, 27);
            midNameTxt.TabIndex = 7;
            // 
            // lastNameTxt
            // 
            lastNameTxt.BackColor = Color.SeaShell;
            lastNameTxt.Location = new Point(132, 281);
            lastNameTxt.Name = "lastNameTxt";
            lastNameTxt.Size = new Size(196, 27);
            lastNameTxt.TabIndex = 8;
            // 
            // contactTxt
            // 
            contactTxt.BackColor = Color.SeaShell;
            contactTxt.Location = new Point(132, 314);
            contactTxt.Name = "contactTxt";
            contactTxt.Size = new Size(196, 27);
            contactTxt.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(34, 221);
            label1.Name = "label1";
            label1.Size = new Size(92, 21);
            label1.TabIndex = 10;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(13, 254);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 11;
            label2.Text = "Middle Name:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(36, 287);
            label3.Name = "label3";
            label3.Size = new Size(90, 21);
            label3.TabIndex = 12;
            label3.Text = "Last Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(25, 320);
            label4.Name = "label4";
            label4.Size = new Size(101, 21);
            label4.TabIndex = 13;
            label4.Text = "Contact No.:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(74, 353);
            label5.Name = "label5";
            label5.Size = new Size(52, 21);
            label5.TabIndex = 15;
            label5.Text = "Email:";
            // 
            // emailTxt
            // 
            emailTxt.BackColor = Color.SeaShell;
            emailTxt.Location = new Point(132, 347);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(196, 27);
            emailTxt.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(53, 390);
            label6.Name = "label6";
            label6.Size = new Size(74, 21);
            label6.TabIndex = 17;
            label6.Text = "Address:";
            // 
            // statusTxt
            // 
            statusTxt.BackColor = Color.SeaShell;
            statusTxt.Location = new Point(133, 380);
            statusTxt.Multiline = true;
            statusTxt.Name = "statusTxt";
            statusTxt.Size = new Size(195, 78);
            statusTxt.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(33, 470);
            label7.Name = "label7";
            label7.Size = new Size(93, 21);
            label7.TabIndex = 19;
            label7.Text = "Citizenship:";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // citizenTxt
            // 
            citizenTxt.BackColor = Color.SeaShell;
            citizenTxt.Location = new Point(133, 464);
            citizenTxt.Name = "citizenTxt";
            citizenTxt.Size = new Size(194, 27);
            citizenTxt.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Symbol", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Beige;
            label8.Location = new Point(403, 31);
            label8.Name = "label8";
            label8.Size = new Size(566, 46);
            label8.TabIndex = 20;
            label8.Text = "CONTACT MANAGEMENT SYSTEM";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(53, 188);
            label9.Name = "label9";
            label9.Size = new Size(73, 21);
            label9.TabIndex = 22;
            label9.Text = "Reg No.:";
            // 
            // regNoTxt
            // 
            regNoTxt.BackColor = Color.SeaShell;
            regNoTxt.Location = new Point(132, 182);
            regNoTxt.Name = "regNoTxt";
            regNoTxt.Size = new Size(196, 27);
            regNoTxt.TabIndex = 21;
            // 
            // printBtn
            // 
            printBtn.BackColor = Color.DarkOrange;
            printBtn.FlatStyle = FlatStyle.Popup;
            printBtn.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            printBtn.ForeColor = SystemColors.ButtonHighlight;
            printBtn.Location = new Point(742, 508);
            printBtn.Name = "printBtn";
            printBtn.Size = new Size(115, 36);
            printBtn.TabIndex = 23;
            printBtn.Text = "Print to Excel";
            printBtn.UseVisualStyleBackColor = false;
            printBtn.Click += printBtn_Click;
            // 
            // deleteBox
            // 
            deleteBox.BackColor = Color.SeaShell;
            deleteBox.Location = new Point(511, 510);
            deleteBox.Name = "deleteBox";
            deleteBox.Size = new Size(139, 27);
            deleteBox.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(353, 510);
            label10.Name = "label10";
            label10.Size = new Size(156, 21);
            label10.TabIndex = 25;
            label10.Text = "Delete with Reg No.";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // searchBox
            // 
            searchBox.BackColor = Color.SeaShell;
            searchBox.Location = new Point(772, 109);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(352, 27);
            searchBox.TabIndex = 28;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.SeaShell;
            searchBtn.FlatStyle = FlatStyle.Popup;
            searchBtn.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            searchBtn.ForeColor = Color.Black;
            searchBtn.Location = new Point(1036, 142);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(88, 34);
            searchBtn.TabIndex = 27;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(703, 115);
            label12.Name = "label12";
            label12.Size = new Size(63, 21);
            label12.TabIndex = 29;
            label12.Text = "Search:";
            label12.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._845fa20f_12dc_4ba3_8009_77818c7d2c85;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(27, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(301, 130);
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // signOutBtn
            // 
            signOutBtn.BackColor = Color.SeaShell;
            signOutBtn.FlatStyle = FlatStyle.Popup;
            signOutBtn.Font = new Font("Yu Gothic", 11F, FontStyle.Bold);
            signOutBtn.Location = new Point(25, 12);
            signOutBtn.Name = "signOutBtn";
            signOutBtn.Size = new Size(85, 27);
            signOutBtn.TabIndex = 31;
            signOutBtn.Text = "Sign Out";
            signOutBtn.UseVisualStyleBackColor = false;
            signOutBtn.Click += signOutBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1159, 623);
            Controls.Add(signOutBtn);
            Controls.Add(pictureBox1);
            Controls.Add(label12);
            Controls.Add(searchBox);
            Controls.Add(searchBtn);
            Controls.Add(label10);
            Controls.Add(deleteBox);
            Controls.Add(printBtn);
            Controls.Add(label9);
            Controls.Add(regNoTxt);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(citizenTxt);
            Controls.Add(label6);
            Controls.Add(statusTxt);
            Controls.Add(label5);
            Controls.Add(emailTxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(contactTxt);
            Controls.Add(lastNameTxt);
            Controls.Add(midNameTxt);
            Controls.Add(firstNameTxt);
            Controls.Add(exitBtn);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(instertBtn);
            Controls.Add(ViewDataBtn);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            Font = new Font("Yu Gothic", 9F);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Contact Management System";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button ViewDataBtn;
        private Button instertBtn;
        private Button updateBtn;
        private Button deleteBtn;
        private Button exitBtn;
        private TextBox firstNameTxt;
        private TextBox midNameTxt;
        private TextBox lastNameTxt;
        private TextBox contactTxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox emailTxt;
        private Label label6;
        private TextBox statusTxt;
        private Label label7;
        private TextBox citizenTxt;
        private Label label8;
        private Label label9;
        private TextBox regNoTxt;
        private Button printBtn;
        private TextBox deleteBox;
        private Label label10;
        private TextBox searchBox;
        private Button searchBtn;
        private Label label12;
        private PictureBox pictureBox1;
        private Button signOutBtn;
    }
}
