namespace ATM_management_system
{
    partial class HOME
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel2 = new Panel();
            label5 = new Label();
            AccNumlbl = new Label();
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
            panel1.Size = new Size(1008, 125);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(976, 0);
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
            label1.Location = new Point(309, 51);
            label1.Name = "label1";
            label1.Size = new Size(418, 31);
            label1.TabIndex = 2;
            label1.Text = "Select Your Transaction Please";
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(117, 215);
            button1.Name = "button1";
            button1.Size = new Size(332, 70);
            button1.TabIndex = 9;
            button1.Text = "DEPOSIT";
            button1.UseCompatibleTextRendering = true;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(568, 215);
            button2.Name = "button2";
            button2.Size = new Size(332, 70);
            button2.TabIndex = 10;
            button2.Text = "WITHDRAW";
            button2.UseCompatibleTextRendering = true;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(117, 328);
            button3.Name = "button3";
            button3.Size = new Size(332, 70);
            button3.TabIndex = 11;
            button3.Text = "FAST CASH";
            button3.UseCompatibleTextRendering = true;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Crimson;
            button4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(568, 328);
            button4.Name = "button4";
            button4.Size = new Size(332, 70);
            button4.TabIndex = 12;
            button4.Text = "MINI STATEMENT";
            button4.UseCompatibleTextRendering = true;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Crimson;
            button5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(117, 456);
            button5.Name = "button5";
            button5.Size = new Size(332, 70);
            button5.TabIndex = 13;
            button5.Text = "CHANGE PIN";
            button5.UseCompatibleTextRendering = true;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Crimson;
            button6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(568, 456);
            button6.Name = "button6";
            button6.Size = new Size(332, 70);
            button6.TabIndex = 14;
            button6.Text = "BALANCE";
            button6.UseCompatibleTextRendering = true;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Crimson;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 608);
            panel2.Name = "panel2";
            panel2.Size = new Size(1008, 20);
            panel2.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Mongolian Baiti", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Crimson;
            label5.Location = new Point(442, 554);
            label5.Name = "label5";
            label5.Size = new Size(140, 30);
            label5.TabIndex = 16;
            label5.Text = "LOG OUT";
            label5.Click += label5_Click;
            // 
            // AccNumlbl
            // 
            AccNumlbl.AutoSize = true;
            AccNumlbl.Font = new Font("Mongolian Baiti", 20F, FontStyle.Regular, GraphicsUnit.Point);
            AccNumlbl.ForeColor = Color.Crimson;
            AccNumlbl.Location = new Point(384, 150);
            AccNumlbl.Name = "AccNumlbl";
            AccNumlbl.Size = new Size(250, 36);
            AccNumlbl.TabIndex = 4;
            AccNumlbl.Text = "Account Number";
            // 
            // HOME
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 628);
            Controls.Add(AccNumlbl);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HOME";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HOME";
            Load += HOME_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Panel panel2;
        private Label label5;
        private Label AccNumlbl;
    }
}