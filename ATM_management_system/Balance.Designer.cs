namespace ATM_management_system
{
    partial class Balance
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
            label6 = new Label();
            label1 = new Label();
            label5 = new Label();
            label2 = new Label();
            Balancelbl = new Label();
            AccNumberlbl = new Label();
            label7 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
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
            panel1.Size = new Size(971, 94);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
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
            label1.Location = new Point(238, 33);
            label1.Name = "label1";
            label1.Size = new Size(455, 31);
            label1.TabIndex = 1;
            label1.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Mongolian Baiti", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(200, 195);
            label5.Name = "label5";
            label5.Size = new Size(259, 36);
            label5.TabIndex = 17;
            label5.Text = "Account Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mongolian Baiti", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(200, 256);
            label2.Name = "label2";
            label2.Size = new Size(212, 36);
            label2.TabIndex = 18;
            label2.Text = "Your Balance:";
            // 
            // Balancelbl
            // 
            Balancelbl.AutoSize = true;
            Balancelbl.Font = new Font("Mongolian Baiti", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Balancelbl.ForeColor = Color.DarkSlateGray;
            Balancelbl.Location = new Point(493, 256);
            Balancelbl.Name = "Balancelbl";
            Balancelbl.Size = new Size(232, 36);
            Balancelbl.TabIndex = 20;
            Balancelbl.Text = "BalanceInMAN";
            // 
            // AccNumberlbl
            // 
            AccNumberlbl.AutoSize = true;
            AccNumberlbl.Font = new Font("Mongolian Baiti", 20F, FontStyle.Regular, GraphicsUnit.Point);
            AccNumberlbl.ForeColor = Color.DarkSlateGray;
            AccNumberlbl.Location = new Point(493, 195);
            AccNumberlbl.Name = "AccNumberlbl";
            AccNumberlbl.Size = new Size(138, 36);
            AccNumberlbl.TabIndex = 19;
            AccNumberlbl.Text = "AccNum";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Mongolian Baiti", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.MidnightBlue;
            label7.Location = new Point(441, 408);
            label7.Name = "label7";
            label7.Size = new Size(70, 30);
            label7.TabIndex = 21;
            label7.Text = "Back";
            label7.Click += label7_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Crimson;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 483);
            panel2.Name = "panel2";
            panel2.Size = new Size(971, 20);
            panel2.TabIndex = 22;
            // 
            // Balance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 503);
            Controls.Add(panel2);
            Controls.Add(label7);
            Controls.Add(Balancelbl);
            Controls.Add(AccNumberlbl);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Balance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Balance";
            Load += Balance_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label1;
        private Label label5;
        private Label label2;
        private Label Balancelbl;
        private Label AccNumberlbl;
        private Label label7;
        private Panel panel2;
    }
}