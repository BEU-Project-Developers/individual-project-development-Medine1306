namespace ATM_management_system
{
    partial class Deposit
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
            label7 = new Label();
            button1 = new Button();
            DepoAmtTb = new TextBox();
            label5 = new Label();
            panel2 = new Panel();
            label2 = new Label();
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
            panel1.TabIndex = 3;
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
            label1.Location = new Point(238, 36);
            label1.Name = "label1";
            label1.Size = new Size(455, 31);
            label1.TabIndex = 1;
            label1.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Crimson;
            label7.Location = new Point(427, 366);
            label7.Name = "label7";
            label7.Size = new Size(51, 24);
            label7.TabIndex = 30;
            label7.Text = "Back";
            label7.Click += label7_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(286, 300);
            button1.Name = "button1";
            button1.Size = new Size(330, 45);
            button1.TabIndex = 29;
            button1.Text = "DEPOSIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DepoAmtTb
            // 
            DepoAmtTb.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            DepoAmtTb.Location = new Point(395, 239);
            DepoAmtTb.Name = "DepoAmtTb";
            DepoAmtTb.Size = new Size(221, 34);
            DepoAmtTb.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(286, 242);
            label5.Name = "label5";
            label5.Size = new Size(93, 24);
            label5.TabIndex = 25;
            label5.Text = "Amount:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Crimson;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 483);
            panel2.Name = "panel2";
            panel2.Size = new Size(971, 20);
            panel2.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(375, 158);
            label2.Name = "label2";
            label2.Size = new Size(138, 31);
            label2.TabIndex = 32;
            label2.Text = "DEPOSIT";
            // 
            // Deposit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 503);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(DepoAmtTb);
            Controls.Add(label5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Deposit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deposit";
            Load += Deposit_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label1;
        private Label label7;
        private Button button1;
        private TextBox DepoAmtTb;
        private Label label5;
        private Panel panel2;
        private Label label2;
    }
}