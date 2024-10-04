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
    public partial class Section : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V3OM59N;Initial Catalog=schooldb;Integrated Security=True");
        public Section()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert into sections values(@id,@name,@section)", conn);
            cmd.Parameters.AddWithValue(@"id", int.Parse(txtsectionid.Text));
            cmd.Parameters.AddWithValue(@"name", txtstdname.Text);
            cmd.Parameters.AddWithValue(@"section", cbsection.Text);
           

            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("save successfully");
            conn.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from sections", conn);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from sections where sectionid=@id", conn);
            cmd.Parameters.AddWithValue(@"id", int.Parse(txtsectionid.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete successfully");
            conn.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update sections set studentName=@name, section=@section where sectionid=@id", conn);
            cmd.Parameters.AddWithValue(@"id", int.Parse(txtsectionid.Text));
            cmd.Parameters.AddWithValue(@"name", txtstdname.Text);
            cmd.Parameters.AddWithValue(@"section", cbsection.Text);
            

            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("update successfully");
            conn.Close();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtsectionid.Text = "";
            txtstdname.Text = "";
            cbsection.Text = "";
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from sections", conn);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void Section_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from sections", conn);
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
