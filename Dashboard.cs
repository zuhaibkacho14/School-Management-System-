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

namespace sms
{
    public partial class Dashboard : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V3OM59N;Initial Catalog=schooldb;Integrated Security=True");
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            stddisplay();
            teachdisplay();
            coursedisplay();
            enrolldisplay();
        }
        private void stddisplay()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select Count(*) from students", conn);
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if(count > 0)
            {
                lblstdcount.Text = Convert.ToString(count.ToString());
            }
            else
            {
                lblstdcount.Text = "0";
            }
            conn.Close();

        }
        private void teachdisplay()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select Count(*) from teacher", conn);
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count > 0)
            {
                lblteachcount.Text = Convert.ToString(count.ToString());
            }
            else
            {
                lblteachcount.Text = "0";
            }
            conn.Close();

        }
        private void coursedisplay()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select Count(*) from courses", conn);
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count > 0)
            {
                lblcoursecount.Text = Convert.ToString(count.ToString());
            }
            else
            {
                lblcoursecount.Text = "0";
            }
            conn.Close();


        }
        private void enrolldisplay()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select Count(*) from enrollment", conn);
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count > 0)
            {
                lblenrollcount.Text = Convert.ToString(count.ToString());
            }
            else
            {
                lblenrollcount.Text = "0";
            }
            conn.Close();


        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
