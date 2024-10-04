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
    public partial class Enrollment : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V3OM59N;Initial Catalog=schooldb;Integrated Security=True");
        public Enrollment()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert into enrollment values(@id,@name,@section,@enrolldate)", conn);
            cmd.Parameters.AddWithValue(@"id", int.Parse(txtenrollid.Text));
            cmd.Parameters.AddWithValue(@"name", txtstdname.Text);
            cmd.Parameters.AddWithValue(@"section", txtsection.Text);
            cmd.Parameters.AddWithValue(@"enrolldate", dtpenrolldate.Value);


            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("save successfully");
            conn.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from enrollment", conn);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from enrollment where enrollid=@id", conn);
            cmd.Parameters.AddWithValue(@"id", int.Parse(txtenrollid.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete successfully");
            conn.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update enrollment set studentName=@name, section=@section, enrollDate=@enrolldate where enrollid=@id", conn);
            cmd.Parameters.AddWithValue(@"id", int.Parse(txtenrollid.Text));
            cmd.Parameters.AddWithValue(@"name", txtstdname.Text);
            cmd.Parameters.AddWithValue(@"section", txtsection.Text);
            cmd.Parameters.AddWithValue(@"enrolldate", dtpenrolldate.Value);


            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("update successfully");
            conn.Close();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtenrollid.Text = "";
            txtsection.Text = "";
            txtstdname.Text = "";
            dtpenrolldate.Value = DateTime.Now;
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from enrollment", conn);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void Enrollment_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from enrollment", conn);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
