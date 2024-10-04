using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnstudent_Click(object sender, EventArgs e)
        {
            students std = new students();
            std.ShowDialog();
        }

        private void btncourse_Click(object sender, EventArgs e)
        {
            courses crse = new courses();
            crse.ShowDialog();
        }

        private void btnteacher_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.ShowDialog();
        }

        private void btnsection_Click(object sender, EventArgs e)
        {
            Section section = new Section();
            section.ShowDialog();
        }

        private void btnattedeance_Click(object sender, EventArgs e)
        {
            Attendance attendance = new Attendance();
            attendance.ShowDialog();
        }

        private void btnenrollment_Click(object sender, EventArgs e)
        {
            Enrollment enrollment = new Enrollment();
            enrollment.ShowDialog();
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
