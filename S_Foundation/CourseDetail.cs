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
namespace S_Foundation
{
    public partial class CourseDetail : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=S_Foundation;Integrated Security=true");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        String sql;
        public CourseDetail()
        {
            InitializeComponent();
            Display();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            cmd = new SqlCommand("insert into tbl_couse(course_name,duration,course_fee,discount) values(@course_name,@duration,@course_fee,@discount)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@course_name", txt_CourseName.Text);
            cmd.Parameters.AddWithValue("@duration", txt_Duration.Text);
            cmd.Parameters.AddWithValue("@course_fee", txt_CourseFee.Text);
            cmd.Parameters.AddWithValue("@discount", txt_Discount.Text);
            

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Successfully");
            clear();
            Display();
        }
        public void clear()
        {
            txt_CourseName.Text = "";
            txt_Duration.Text = "";
            txt_CourseFee.Text = "";
            txt_Discount.Text = "";

        }

        void Display()
        {
            con.Open();
            DataTable dt = new DataTable();
            sql = "select * from tbl_couse ";
            adapt = new SqlDataAdapter(sql, con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void CourseDetail_Load(object sender, EventArgs e)
        {

        }
    }
}
