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

namespace sms
{
    public partial class loginform : Form
    {
        
        public loginform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V3OM59N;Initial Catalog=schooldb;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from Admin where username = '" + txtuserame.Text + "' and password = '" + txtpass.Text + "'", conn);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                Home hm = new Home();
                hm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed");
            }
            conn.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
