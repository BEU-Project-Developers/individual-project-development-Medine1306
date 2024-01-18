namespace ATM_management_system
{
    partial class ministatement
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            MinistatementDGV = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MinistatementDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Crimson;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 125);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Mongolian Baiti", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(268, 47);
            label3.Name = "label3";
            label3.Size = new Size(455, 31);
            label3.TabIndex = 4;
            label3.Text = "ATM MANAGEMENT SYSTEM";
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
            label1.Font = new Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(360, 138);
            label1.Name = "label1";
            label1.Size = new Size(269, 31);
            label1.TabIndex = 24;
            label1.Text = "MINI STATEMENT";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Mongolian Baiti", 16.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Crimson;
            label7.Location = new Point(431, 568);
            label7.Name = "label7";
            label7.Size = new Size(73, 30);
            label7.TabIndex = 26;
            label7.Text = "Back";
            label7.Click += label7_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Crimson;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 608);
            panel2.Name = "panel2";
            panel2.Size = new Size(1008, 20);
            panel2.TabIndex = 27;
            // 
            // MinistatementDGV
            // 
            MinistatementDGV.BackgroundColor = Color.White;
            MinistatementDGV.BorderStyle = BorderStyle.None;
            MinistatementDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MinistatementDGV.Location = new Point(0, 172);
            MinistatementDGV.Name = "MinistatementDGV";
            MinistatementDGV.RowHeadersWidth = 51;
            MinistatementDGV.RowTemplate.Height = 29;
            MinistatementDGV.Size = new Size(1008, 393);
            MinistatementDGV.TabIndex = 28;
            // 
            // ministatement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1008, 628);
            Controls.Add(MinistatementDGV);
            Controls.Add(panel2);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ministatement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ministatement";
            Load += ministatement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MinistatementDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Panel panel2;
        private DataGridView MinistatementDGV;
    }
}