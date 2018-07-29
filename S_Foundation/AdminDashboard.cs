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
    public partial class AdminDashboard : Form
    {
        DBClass db = new DBClass();
        public AdminDashboard()
        {
            InitializeComponent();
            updateStats();
        }

        private void lblCount_Click(object sender, EventArgs e)
        {

        }

        private void msg2_Click(object sender, EventArgs e)
        {

        }

        private void lblCount2_Click(object sender, EventArgs e)
        {

        }

        public void updateStats()
        {
            lblCount.Text = db.readScalarData("select Count(*) from tbl_student;").ToString();
            lblCount2.Text = db.readScalarData("select Count(*) from tbl_faculty;").ToString();
            lblCount3.Text = db.readScalarData("select Count(*) from tbl_batchdetail;").ToString();
            lblCount4.Text = db.readScalarData("select Count(*) from tbl_course;").ToString();
        }
    }
}
