namespace ATM_management_system
{
    partial class withdraw
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
            label2 = new Label();
            label7 = new Label();
            button1 = new Button();
            wdamtTb = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            label1 = new Label();
            balancelbl = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mongolian Baiti", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(361, 116);
            label2.Name = "label2";
            label2.Size = new Size(209, 36);
            label2.TabIndex = 37;
            label2.Text = "WITHDRAW";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Crimson;
            label7.Location = new Point(431, 389);
            label7.Name = "label7";
            label7.Size = new Size(95, 21);
            label7.TabIndex = 36;
            label7.Text = "LOG OUT";
            label7.Click += label7_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(299, 320);
            button1.Name = "button1";
            button1.Size = new Size(353, 45);
            button1.TabIndex = 35;
            button1.Text = "WITHDRAW";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // wdamtTb
            // 
            wdamtTb.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            wdamtTb.Location = new Point(431, 247);
            wdamtTb.Name = "wdamtTb";
            wdamtTb.Size = new Size(221, 34);
            wdamtTb.TabIndex = 34;
            wdamtTb.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(299, 257);
            label5.Name = "label5";
            label5.Size = new Size(116, 24);
            label5.TabIndex = 33;
            label5.Text = "AMOUNT:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Crimson;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(971, 94);
            panel1.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(941, 0);
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
            label1.Location = new Point(238, 28);
            label1.Name = "label1";
            label1.Size = new Size(455, 31);
            label1.TabIndex = 1;
            label1.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // balancelbl
            // 
            balancelbl.AutoSize = true;
            balancelbl.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            balancelbl.ForeColor = Color.Crimson;
            balancelbl.Location = new Point(361, 186);
            balancelbl.Name = "balancelbl";
            balancelbl.Size = new Size(256, 24);
            balancelbl.TabIndex = 39;
            balancelbl.Text = "AVAILABLE BALANCE";
            // 
            // withdraw
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 503);
            Controls.Add(balancelbl);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(wdamtTb);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "withdraw";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "withdraw";
            Load += withdraw_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label7;
        private Button button1;
        private TextBox wdamtTb;
        private Label label5;
        private Panel panel1;
        private Label label6;
        private Label label1;
        private Label balancelbl;
    }
}