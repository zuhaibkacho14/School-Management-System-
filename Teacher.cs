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
    public partial class Teacher : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V3OM59N;Initial Catalog=schooldb;Integrated Security=True");
        public Teacher()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert into teacher values(@id, @name, @phone, @gender, @address)", conn);
            cmd.Parameters.AddWithValue(@"id", int.Parse(txttechid.Text));
            cmd.Parameters.AddWithValue(@"name", txtteachname.Text);
            cmd.Parameters.AddWithValue(@"phone", txtteachphone.Text);
            cmd.Parameters.AddWithValue(@"gender", cbteachgender.Text);
            cmd.Parameters.AddWithValue(@"address", txtteachaddress.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("save successfully");
            conn.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from teacher", conn);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from teacher where teacherid = @id", conn);
            cmd.Parameters.AddWithValue(@"id", int.Parse(txttechid.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete successfully");
            conn.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update teacher set teacherName=@name, teacherPhone=@phone, teacherGender=@gender, teacherAddress=@address where teacherid=@id", conn);
            cmd.Parameters.AddWithValue(@"id", int.Parse(txttechid.Text));
            cmd.Parameters.AddWithValue(@"name", txtteachname.Text);
            cmd.Parameters.AddWithValue(@"phone", txtteachphone.Text);
            cmd.Parameters.AddWithValue(@"gender", cbteachgender.Text);
            cmd.Parameters.AddWithValue(@"address", txtteachaddress.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("update successfully");
            conn.Close();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txttechid.Text = "";
            txtteachname.Text = "";
            txtteachphone.Text = "";
            txtteachaddress.Text = "";
            cbteachgender.Text = "";
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from teacher", conn);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from teacher", conn);
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
