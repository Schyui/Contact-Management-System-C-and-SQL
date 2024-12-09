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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 224, 192);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.Tan;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Tan;
            dataGridViewCellStyle2.Font = new Font("Yu Gothic", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.NavajoWhite;
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
            dataGridView1.Size = new Size(698, 313);
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
            instertBtn.BackColor = Color.OliveDrab;
            instertBtn.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            instertBtn.ForeColor = SystemColors.ButtonFace;
            instertBtn.Location = new Point(171, 526);
            instertBtn.Name = "instertBtn";
            instertBtn.Size = new Size(75, 25);
            instertBtn.TabIndex = 2;
            instertBtn.Text = "Add";
            instertBtn.UseVisualStyleBackColor = false;
            instertBtn.Click += instertBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.RoyalBlue;
            updateBtn.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            updateBtn.ForeColor = SystemColors.ButtonFace;
            updateBtn.Location = new Point(252, 526);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(75, 25);
            updateBtn.TabIndex = 3;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Firebrick;
            deleteBtn.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            deleteBtn.ForeColor = SystemColors.ControlLightLight;
            deleteBtn.Location = new Point(496, 539);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(75, 25);
            deleteBtn.TabIndex = 4;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Red;
            exitBtn.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            exitBtn.ForeColor = SystemColors.ButtonFace;
            exitBtn.Location = new Point(966, 504);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(75, 25);
            exitBtn.TabIndex = 5;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // firstNameTxt
            // 
            firstNameTxt.BackColor = Color.BurlyWood;
            firstNameTxt.Location = new Point(131, 244);
            firstNameTxt.Name = "firstNameTxt";
            firstNameTxt.Size = new Size(196, 27);
            firstNameTxt.TabIndex = 6;
            // 
            // midNameTxt
            // 
            midNameTxt.BackColor = Color.BurlyWood;
            midNameTxt.Location = new Point(131, 277);
            midNameTxt.Name = "midNameTxt";
            midNameTxt.Size = new Size(196, 27);
            midNameTxt.TabIndex = 7;
            // 
            // lastNameTxt
            // 
            lastNameTxt.BackColor = Color.BurlyWood;
            lastNameTxt.Location = new Point(131, 310);
            lastNameTxt.Name = "lastNameTxt";
            lastNameTxt.Size = new Size(196, 27);
            lastNameTxt.TabIndex = 8;
            // 
            // contactTxt
            // 
            contactTxt.BackColor = Color.BurlyWood;
            contactTxt.Location = new Point(131, 343);
            contactTxt.Name = "contactTxt";
            contactTxt.Size = new Size(196, 27);
            contactTxt.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Peru;
            label1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(47, 249);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 10;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Peru;
            label2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(33, 280);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 11;
            label2.Text = "Middle Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Peru;
            label3.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(47, 313);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 12;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Peru;
            label4.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(42, 346);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 13;
            label4.Text = "Contact No.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Peru;
            label5.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(77, 379);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 15;
            label5.Text = "Email";
            // 
            // emailTxt
            // 
            emailTxt.BackColor = Color.BurlyWood;
            emailTxt.Location = new Point(131, 376);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(196, 27);
            emailTxt.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Peru;
            label6.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(62, 412);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 17;
            label6.Text = "Address";
            // 
            // statusTxt
            // 
            statusTxt.BackColor = Color.BurlyWood;
            statusTxt.Location = new Point(132, 409);
            statusTxt.Multiline = true;
            statusTxt.Name = "statusTxt";
            statusTxt.Size = new Size(195, 78);
            statusTxt.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Peru;
            label7.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(47, 496);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 19;
            label7.Text = "Citizenship";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // citizenTxt
            // 
            citizenTxt.BackColor = Color.BurlyWood;
            citizenTxt.Location = new Point(132, 493);
            citizenTxt.Name = "citizenTxt";
            citizenTxt.Size = new Size(194, 27);
            citizenTxt.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe Print", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(315, 9);
            label8.Name = "label8";
            label8.Size = new Size(508, 47);
            label8.TabIndex = 20;
            label8.Text = "CONTACT MANAGEMENT SYSTEM";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Peru;
            label9.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(63, 214);
            label9.Name = "label9";
            label9.Size = new Size(49, 15);
            label9.TabIndex = 22;
            label9.Text = "Reg No.";
            // 
            // regNoTxt
            // 
            regNoTxt.BackColor = Color.BurlyWood;
            regNoTxt.Location = new Point(131, 211);
            regNoTxt.Name = "regNoTxt";
            regNoTxt.Size = new Size(196, 27);
            regNoTxt.TabIndex = 21;
            // 
            // printBtn
            // 
            printBtn.BackColor = Color.Firebrick;
            printBtn.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            printBtn.ForeColor = SystemColors.ButtonHighlight;
            printBtn.Location = new Point(729, 504);
            printBtn.Name = "printBtn";
            printBtn.Size = new Size(94, 25);
            printBtn.TabIndex = 23;
            printBtn.Text = "Print to Excel";
            printBtn.UseVisualStyleBackColor = false;
            printBtn.Click += printBtn_Click;
            // 
            // deleteBox
            // 
            deleteBox.BackColor = Color.BurlyWood;
            deleteBox.Location = new Point(483, 506);
            deleteBox.Name = "deleteBox";
            deleteBox.Size = new Size(100, 27);
            deleteBox.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(365, 514);
            label10.Name = "label10";
            label10.Size = new Size(112, 15);
            label10.TabIndex = 25;
            label10.Text = "Delete with Reg No.";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // searchBox
            // 
            searchBox.BackColor = Color.BurlyWood;
            searchBox.Location = new Point(523, 91);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(352, 27);
            searchBox.TabIndex = 28;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.FromArgb(255, 192, 128);
            searchBtn.ForeColor = Color.Black;
            searchBtn.Location = new Point(800, 124);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(75, 25);
            searchBtn.TabIndex = 27;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(471, 94);
            label12.Name = "label12";
            label12.Size = new Size(43, 15);
            label12.TabIndex = 29;
            label12.Text = "Search";
            label12.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._845fa20f_12dc_4ba3_8009_77818c7d2c85;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(131, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 83);
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1122, 658);
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
            Text = "Form1";
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
    }
}
