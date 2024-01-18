namespace ATM_management_system
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            AccNumTb = new TextBox();
            PinTb = new TextBox();
            button1 = new Button();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Crimson;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(766, 94);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(737, 0);
            label6.Name = "label6";
            label6.Size = new Size(29, 31);
            label6.TabIndex = 10;
            label6.Text = "x";
            label6.Click += label6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(159, 32);
            label1.Name = "label1";
            label1.Size = new Size(455, 31);
            label1.TabIndex = 1;
            label1.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(317, 109);
            label2.Name = "label2";
            label2.Size = new Size(108, 31);
            label2.TabIndex = 2;
            label2.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(37, 194);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(251, 197);
            label3.Name = "label3";
            label3.Size = new Size(95, 24);
            label3.TabIndex = 4;
            label3.Text = "Acc num";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(251, 256);
            label4.Name = "label4";
            label4.Size = new Size(91, 24);
            label4.TabIndex = 5;
            label4.Text = "Pin code";
            // 
            // AccNumTb
            // 
            AccNumTb.BackColor = SystemColors.InactiveBorder;
            AccNumTb.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            AccNumTb.Location = new Point(393, 194);
            AccNumTb.Name = "AccNumTb";
            AccNumTb.Size = new Size(221, 34);
            AccNumTb.TabIndex = 6;
            AccNumTb.TextChanged += AccNumTb_TextChanged;
            // 
            // PinTb
            // 
            PinTb.BackColor = SystemColors.InactiveBorder;
            PinTb.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            PinTb.Location = new Point(393, 253);
            PinTb.Name = "PinTb";
            PinTb.PasswordChar = '*';
            PinTb.Size = new Size(221, 34);
            PinTb.TabIndex = 7;
            PinTb.TextChanged += PinTb_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(251, 317);
            button1.Name = "button1";
            button1.Size = new Size(363, 39);
            button1.TabIndex = 8;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Mongolian Baiti", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Crimson;
            label5.Location = new Point(384, 370);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 9;
            label5.Text = "SIGN UP";
            label5.Click += label5_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 449);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(PinTb);
            Controls.Add(AccNumTb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private TextBox AccNumTb;
        private TextBox PinTb;
        private Button button1;
        private Label label5;
        private Label label6;
    }
}