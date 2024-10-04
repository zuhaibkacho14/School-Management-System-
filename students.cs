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
    public partial class students : Form
    {
        public students()
        {
            InitializeComponent();
        }

        private void dtpstd_ValueChanged(object sender, EventArgs e)
        {
            dtpstd.CustomFormat = "dd/MM/yyyy";
        }

        private void dtpstd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
                dtpstd.CustomFormat = "";
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V3OM59N;Initial Catalog=schooldb;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Insert into students values(@stdid,@name,@phone,@dob,@gender,@address)", conn);
            cmd.Parameters.AddWithValue(@"stdid", int.Parse(txtstdid.Text));
            cmd.Parameters.AddWithValue(@"name", txtstdname.Text);
            cmd.Parameters.AddWithValue(@"phone", txtstdphone.Text);
            cmd.Parameters.AddWithValue(@"dob", dtpstd.Value);
            cmd.Parameters.AddWithValue(@"gender", cbstd.Text);
            cmd.Parameters.AddWithValue(@"address", txtstdaddress.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("save successfully");
            conn.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V3OM59N;Initial Catalog=schooldb;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from students", conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            
            conn.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V3OM59N;Initial Catalog=schooldb;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Delete from students where stdid = @stdid", conn);
            cmd.Parameters.AddWithValue(@"stdid", int.Parse(txtstdid.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete successfully");
            conn.Close();

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V3OM59N;Initial Catalog=schooldb;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Update students set name=@name, phone=@phone,dob=@dob,gender=@gender,address=@address where stdid = @stdid", conn);
            cmd.Parameters.AddWithValue(@"stdid", int.Parse(txtstdid.Text));
            cmd.Parameters.AddWithValue(@"name", txtstdname.Text);
            cmd.Parameters.AddWithValue(@"phone", txtstdphone.Text);
            cmd.Parameters.AddWithValue(@"dob", dtpstd.Value);
            cmd.Parameters.AddWithValue(@"gender", cbstd.Text);
            cmd.Parameters.AddWithValue(@"address", txtstdaddress.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update successfully");
            conn.Close();

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtstdid.Text = "";
            txtstdname.Text = "";
            txtstdphone.Text = "";
            dtpstd.Value = DateTime.Now;
            cbstd.Text = "select";
            txtstdaddress.Text = "";
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V3OM59N;Initial Catalog=schooldb;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from students", conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();
        }

        private void students_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V3OM59N;Initial Catalog=schooldb;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from students", conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
