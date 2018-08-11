using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace S_Foundation
{
    public partial class CourseDetail : Form
    {
        String name;
        DBClass db = new DBClass();
        public CourseDetail(String name)
        {
            this.name = name;
            InitializeComponent();
            Display();
        }

        private void CourseDetail_Load(object sender, EventArgs e)
        {
            initDuration();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(db.InsertUpdateDelete("insert into tbl_course(course_name,duration,course_fee,discount,submittedBy) values('"+txt_CourseName.Text+"','"+cmbDuration.Text+"','"+txt_CourseFee.Text+"','"+txt_Discount.Text+"','"+name+"')"))
            {
                MessageBox.Show("Record Inserted Successfully");
                clear();
                Display();
            }
             
        }
        //for clearing fields
        public void clear()
        {
            txt_CourseName.Text = "";
            cmbDuration.SelectionStart = 0;
            txt_CourseFee.Text = "";
            txt_Discount.Text = "";

        }

        //for displayinmg full courses details
        void Display()
        {
            dataGridView1.DataSource = db.ReadBulkData("select * from tbl_course");
        }


        //for initialising duration 
        void initDuration()
        {
            List<int> duration = new List<int>();
            for (int i = 1; i <= 24; i++)
                duration.Add(i);
            cmbDuration.DataSource = duration;
        }
    }
}
