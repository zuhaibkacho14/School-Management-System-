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
using static System.Collections.Specialized.BitVector32;

namespace sms
{
    public partial class Attendance : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V3OM59N;Initial Catalog=schooldb;Integrated Security=True");
        public Attendance()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert into attendance values(@id,@name,@status)", conn);
            cmd.Parameters.AddWithValue(@"id", int.Parse(txtattendid.Text));
            cmd.Parameters.AddWithValue(@"name", txtattendancestdname.Text);
            cmd.Parameters.AddWithValue(@"status", cbattendancestatus.Text);


            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("save successfully");
            conn.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from attendance", conn);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from attendance where attendanceid=@id", conn);
            cmd.Parameters.AddWithValue(@"id", int.Parse(txtattendid.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete successfully");
            conn.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update attendance set studentName=@name, status=@status where attendanceid=@id", conn);
            cmd.Parameters.AddWithValue(@"id", int.Parse(txtattendid.Text));
            cmd.Parameters.AddWithValue(@"name", txtattendancestdname.Text);
            cmd.Parameters.AddWithValue(@"status", cbattendancestatus.Text);


            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("update successfully");
            conn.Close();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtattendid.Text = "";
            txtattendancestdname.Text = "";
            cbattendancestatus.Text = "";
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from attendance", conn);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from attendance", conn);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
