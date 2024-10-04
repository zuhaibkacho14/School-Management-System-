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
    public partial class courses : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V3OM59N;Initial Catalog=schooldb;Integrated Security=True");
        public courses()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert into courses values(@courseid,@coursename)", conn);
            cmd.Parameters.AddWithValue(@"courseid", int.Parse(txtcorseid.Text));
            cmd.Parameters.AddWithValue(@"coursename", txtcorsename.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("successfully save");
            conn.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from courses", conn);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from courses where courseid= @courseid", conn);
            cmd.Parameters.AddWithValue(@"courseid", int.Parse(txtcorseid.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted data");
            conn.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update courses set coursename= @coursename where courseid= @courseid", conn);
            cmd.Parameters.AddWithValue(@"courseid", int.Parse(txtcorseid.Text));
            cmd.Parameters.AddWithValue(@"coursename", txtcorsename.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("update successfully");
            conn.Close();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtcorseid.Text = "";
            txtcorsename.Text = "";

        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from courses", conn);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void courses_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from courses", conn);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
