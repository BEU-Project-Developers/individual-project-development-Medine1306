using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ATM_management_system
{
    public partial class ChangePin : Form
    {
        public ChangePin()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\ATMdb.mdf;Integrated Security=True;Connect Timeout=30");
        string? Acc = Login.AccNumber;
        private void button1_Click(object sender, EventArgs e)
        {
            if (Pin1Tb.Text == "" || Pin2Tb.Text == "")
            {
                MessageBox.Show("Enter And Confirm The New Pin");
            }
            else if (Pin2Tb.Text != Pin1Tb.Text)
            {
                MessageBox.Show("Pins are not matched");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set PIN=" + Pin1Tb.Text + " where Accnum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("PIN Updated Successfully");
                    Con.Close();
                    Login home = new Login();
                    home.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Hide();
        }
    }
}
