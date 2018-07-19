using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S_Foundation
{
    public partial class Form1 : Form
    {
        String name,rb_selected;
        public Form1(string rb_selected,string name)
        {
            InitializeComponent();
            this.name = name;
            this.rb_selected = rb_selected;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = "Time : "+DateTime.Now.ToLongTimeString().ToString();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Enquiry_Form objef = new Enquiry_Form(name);
            objef.MdiParent = this;
            objef.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Do you want to Logout?";
            string title = "Logout";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                LoginPanel objlp = new LoginPanel();
                this.Close();
                objlp.Show();            
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Admission_form objaf = new Admission_form(name);
            objaf.MdiParent = this;
            objaf.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Faculty_Detail objfd = new Faculty_Detail(name);
            objfd.MdiParent = this;
            objfd.Show();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            CourseDetail objcd = new CourseDetail();
            objcd.MdiParent = this;
            objcd.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Batch_details objbd = new Batch_details(name);
            objbd.MdiParent = this;
            objbd.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            toolStripStatusLabel1.Text =rb_selected.ToString()+" : "+ name.ToString();
            toolStripStatusLabel2.Text = "Date : "+String.Format(DateTime.Now.ToLongDateString());
           
        }
    }
}
