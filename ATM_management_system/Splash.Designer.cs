namespace ATM_management_system
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            Myprogress = new ProgressBar();
            Percentage = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(309, 40);
            label1.Name = "label1";
            label1.Size = new Size(557, 40);
            label1.TabIndex = 0;
            label1.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(322, 110);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(544, 213);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Myprogress
            // 
            Myprogress.Dock = DockStyle.Bottom;
            Myprogress.ForeColor = SystemColors.GradientActiveCaption;
            Myprogress.Location = new Point(0, 422);
            Myprogress.Margin = new Padding(3, 4, 3, 4);
            Myprogress.Name = "Myprogress";
            Myprogress.Size = new Size(1122, 29);
            Myprogress.TabIndex = 2;
            // 
            // Percentage
            // 
            Percentage.AutoSize = true;
            Percentage.Font = new Font("Mongolian Baiti", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            Percentage.ForeColor = Color.White;
            Percentage.Location = new Point(559, 343);
            Percentage.Name = "Percentage";
            Percentage.Size = new Size(48, 40);
            Percentage.TabIndex = 4;
            Percentage.Text = "%";
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Crimson;
            ClientSize = new Size(1122, 451);
            Controls.Add(Percentage);
            Controls.Add(Myprogress);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlDark;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Splash_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private ProgressBar Myprogress;
        private Label Percentage;
    }
}