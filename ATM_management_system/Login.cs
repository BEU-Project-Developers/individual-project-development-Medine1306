using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_management_system
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.Show();
            this.Hide();
        }
        public static String? AccNumber;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\ATMdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            //create a SqlDataAdapter to execute an SQL query
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AccountTbl where Accnum='" + AccNumTb.Text + "' and PIN = " + PinTb.Text + "", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt); //fill a DataTable with the result.
            if (dt.Rows[0][0].ToString() == "1")
            {
                AccNumber = AccNumTb.Text; //sets the AccNumber static variable
                HOME home = new HOME();
                home.Show();
                this.Hide();
                Con.Close();
            }
            else
            {
                MessageBox.Show("Wrong Account Number Or PIN Code");
            }
            Con.Close();
        }

        private void AccNumTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void PinTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
