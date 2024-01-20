namespace ATM_management_system
{
    partial class Account
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            AccNumTb = new TextBox();
            AccNametb = new TextBox();
            FanameTb = new TextBox();
            Addresstb = new TextBox();
            PhoneTb = new TextBox();
            pintb = new TextBox();
            educationcb = new ComboBox();
            dobdate = new DateTimePicker();
            button1 = new Button();
            panel2 = new Panel();
            label13 = new Label();
            occupationtb = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Crimson;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1321, 125);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1289, 0);
            label2.Name = "label2";
            label2.Size = new Size(29, 31);
            label2.TabIndex = 3;
            label2.Text = "x";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(441, 54);
            label1.Name = "label1";
            label1.Size = new Size(455, 31);
            label1.TabIndex = 2;
            label1.Text = "ATM MANAGEMENT SYSTEM";
            label1.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(169, 188);
            label5.Name = "label5";
            label5.Size = new Size(101, 21);
            label5.TabIndex = 10;
            label5.Text = "ACC NUM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(169, 282);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 11;
            label3.Text = "NAME";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(169, 397);
            label4.Name = "label4";
            label4.Size = new Size(79, 21);
            label4.TabIndex = 12;
            label4.Text = "FNAME";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.MidnightBlue;
            label6.Location = new Point(169, 504);
            label6.Name = "label6";
            label6.Size = new Size(99, 21);
            label6.TabIndex = 13;
            label6.Text = "ADDRESS";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.MidnightBlue;
            label7.Location = new Point(760, 504);
            label7.Name = "label7";
            label7.Size = new Size(75, 21);
            label7.TabIndex = 14;
            label7.Text = "PHONE";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.MidnightBlue;
            label8.Location = new Point(760, 282);
            label8.Name = "label8";
            label8.Size = new Size(124, 21);
            label8.TabIndex = 15;
            label8.Text = "EDUCATION";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.MidnightBlue;
            label9.Location = new Point(760, 397);
            label9.Name = "label9";
            label9.Size = new Size(136, 21);
            label9.TabIndex = 16;
            label9.Text = "OCCUPATION";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.MidnightBlue;
            label10.Location = new Point(760, 595);
            label10.Name = "label10";
            label10.Size = new Size(51, 21);
            label10.TabIndex = 17;
            label10.Text = "DOB";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.MidnightBlue;
            label11.Location = new Point(760, 188);
            label11.Name = "label11";
            label11.Size = new Size(42, 21);
            label11.TabIndex = 18;
            label11.Text = "PIN";
            // 
            // AccNumTb
            // 
            AccNumTb.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            AccNumTb.Location = new Point(343, 183);
            AccNumTb.Name = "AccNumTb";
            AccNumTb.Size = new Size(221, 34);
            AccNumTb.TabIndex = 20;
            // 
            // AccNametb
            // 
            AccNametb.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            AccNametb.Location = new Point(343, 274);
            AccNametb.Name = "AccNametb";
            AccNametb.Size = new Size(221, 34);
            AccNametb.TabIndex = 21;
            // 
            // FanameTb
            // 
            FanameTb.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            FanameTb.Location = new Point(343, 384);
            FanameTb.Name = "FanameTb";
            FanameTb.Size = new Size(221, 34);
            FanameTb.TabIndex = 22;
            // 
            // Addresstb
            // 
            Addresstb.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Addresstb.Location = new Point(343, 491);
            Addresstb.Multiline = true;
            Addresstb.Name = "Addresstb";
            Addresstb.Size = new Size(221, 122);
            Addresstb.TabIndex = 23;
            // 
            // PhoneTb
            // 
            PhoneTb.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneTb.Location = new Point(934, 491);
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(221, 34);
            PhoneTb.TabIndex = 24;
            // 
            // pintb
            // 
            pintb.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            pintb.Location = new Point(935, 183);
            pintb.Name = "pintb";
            pintb.Size = new Size(221, 34);
            pintb.TabIndex = 25;
            // 
            // educationcb
            // 
            educationcb.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            educationcb.FormattingEnabled = true;
            educationcb.Items.AddRange(new object[] { "Non Graduate", "Under Graduate", "Post Graduate" });
            educationcb.Location = new Point(935, 275);
            educationcb.Name = "educationcb";
            educationcb.Size = new Size(221, 32);
            educationcb.TabIndex = 27;
            // 
            // dobdate
            // 
            dobdate.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dobdate.Location = new Point(935, 582);
            dobdate.Name = "dobdate";
            dobdate.Size = new Size(221, 31);
            dobdate.TabIndex = 29;
            // 
            // button1
            // 
            button1.AccessibleRole = AccessibleRole.Cursor;
            button1.BackColor = Color.Crimson;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(472, 667);
            button1.Name = "button1";
            button1.Size = new Size(363, 45);
            button1.TabIndex = 30;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Crimson;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 776);
            panel2.Name = "panel2";
            panel2.Size = new Size(1321, 24);
            panel2.TabIndex = 31;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.DarkSlateGray;
            label13.Location = new Point(601, 725);
            label13.Name = "label13";
            label13.Size = new Size(95, 21);
            label13.TabIndex = 32;
            label13.Text = "LOG OUT";
            label13.Click += label13_Click;
            // 
            // occupationtb
            // 
            occupationtb.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            occupationtb.Location = new Point(935, 384);
            occupationtb.Name = "occupationtb";
            occupationtb.Size = new Size(221, 34);
            occupationtb.TabIndex = 33;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1321, 800);
            Controls.Add(occupationtb);
            Controls.Add(label13);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(dobdate);
            Controls.Add(educationcb);
            Controls.Add(pintb);
            Controls.Add(PhoneTb);
            Controls.Add(Addresstb);
            Controls.Add(FanameTb);
            Controls.Add(AccNametb);
            Controls.Add(AccNumTb);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Account";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Account";
            Load += Account_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox AccNumTb;
        private TextBox AccNametb;
        private TextBox FanameTb;
        private TextBox Addresstb;
        private TextBox PhoneTb;
        private TextBox pintb;
        private ComboBox educationcb;
        private DateTimePicker dobdate;
        private Button button1;
        private Panel panel2;
        private Label label13;
        private TextBox occupationtb;
    }
}