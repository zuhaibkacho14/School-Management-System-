namespace sms
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnenrollment = new System.Windows.Forms.Button();
            this.btnattedeance = new System.Windows.Forms.Button();
            this.btnsection = new System.Windows.Forms.Button();
            this.btnteacher = new System.Windows.Forms.Button();
            this.btncourse = new System.Windows.Forms.Button();
            this.btnstudent = new System.Windows.Forms.Button();
            this.btndashboard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(917, 553);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btnenrollment);
            this.panel2.Controls.Add(this.btnsection);
            this.panel2.Controls.Add(this.btnstudent);
            this.panel2.Controls.Add(this.btnattedeance);
            this.panel2.Controls.Add(this.btncourse);
            this.panel2.Controls.Add(this.btndashboard);
            this.panel2.Controls.Add(this.btnteacher);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 453);
            this.panel2.TabIndex = 1;
            // 
            // btnenrollment
            // 
            this.btnenrollment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnenrollment.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnenrollment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnenrollment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnenrollment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnenrollment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenrollment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnenrollment.Location = new System.Drawing.Point(24, 395);
            this.btnenrollment.Name = "btnenrollment";
            this.btnenrollment.Size = new System.Drawing.Size(184, 43);
            this.btnenrollment.TabIndex = 6;
            this.btnenrollment.Text = "Enrollment";
            this.btnenrollment.UseVisualStyleBackColor = false;
            this.btnenrollment.Click += new System.EventHandler(this.btnenrollment_Click);
            // 
            // btnattedeance
            // 
            this.btnattedeance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnattedeance.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnattedeance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnattedeance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnattedeance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnattedeance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnattedeance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnattedeance.Location = new System.Drawing.Point(24, 336);
            this.btnattedeance.Name = "btnattedeance";
            this.btnattedeance.Size = new System.Drawing.Size(184, 43);
            this.btnattedeance.TabIndex = 5;
            this.btnattedeance.Text = "Attendance";
            this.btnattedeance.UseVisualStyleBackColor = false;
            this.btnattedeance.Click += new System.EventHandler(this.btnattedeance_Click);
            // 
            // btnsection
            // 
            this.btnsection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnsection.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnsection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnsection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnsection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnsection.Location = new System.Drawing.Point(24, 272);
            this.btnsection.Name = "btnsection";
            this.btnsection.Size = new System.Drawing.Size(184, 43);
            this.btnsection.TabIndex = 4;
            this.btnsection.Text = "Section";
            this.btnsection.UseVisualStyleBackColor = false;
            this.btnsection.Click += new System.EventHandler(this.btnsection_Click);
            // 
            // btnteacher
            // 
            this.btnteacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnteacher.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnteacher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnteacher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnteacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnteacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnteacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnteacher.Location = new System.Drawing.Point(24, 211);
            this.btnteacher.Name = "btnteacher";
            this.btnteacher.Size = new System.Drawing.Size(184, 43);
            this.btnteacher.TabIndex = 3;
            this.btnteacher.Text = "Teacher";
            this.btnteacher.UseVisualStyleBackColor = false;
            this.btnteacher.Click += new System.EventHandler(this.btnteacher_Click);
            // 
            // btncourse
            // 
            this.btncourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btncourse.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btncourse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btncourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btncourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btncourse.Location = new System.Drawing.Point(24, 146);
            this.btncourse.Name = "btncourse";
            this.btncourse.Size = new System.Drawing.Size(184, 43);
            this.btncourse.TabIndex = 2;
            this.btncourse.Text = "Course";
            this.btncourse.UseVisualStyleBackColor = false;
            this.btncourse.Click += new System.EventHandler(this.btncourse_Click);
            // 
            // btnstudent
            // 
            this.btnstudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnstudent.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnstudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnstudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnstudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnstudent.Location = new System.Drawing.Point(24, 84);
            this.btnstudent.Name = "btnstudent";
            this.btnstudent.Size = new System.Drawing.Size(184, 43);
            this.btnstudent.TabIndex = 1;
            this.btnstudent.Text = "Student";
            this.btnstudent.UseVisualStyleBackColor = false;
            this.btnstudent.Click += new System.EventHandler(this.btnstudent_Click);
            // 
            // btndashboard
            // 
            this.btndashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btndashboard.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btndashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btndashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btndashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btndashboard.Location = new System.Drawing.Point(24, 26);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Size = new System.Drawing.Size(184, 43);
            this.btndashboard.TabIndex = 0;
            this.btndashboard.Text = "Dashboard";
            this.btndashboard.UseVisualStyleBackColor = false;
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(768, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(149, 100);
            this.panel4.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "x";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "_";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(17, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "School Management System";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 553);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btndashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnenrollment;
        private System.Windows.Forms.Button btnattedeance;
        private System.Windows.Forms.Button btnsection;
        private System.Windows.Forms.Button btnteacher;
        private System.Windows.Forms.Button btncourse;
        private System.Windows.Forms.Button btnstudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
    }
}