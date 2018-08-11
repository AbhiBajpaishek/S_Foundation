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
using System.Drawing.Imaging;
using System.IO;

namespace S_Foundation
{
    public partial class Admission_form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=S_Foundation;Integrated Security=true");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        string sql;
        int discount, course_fee, total_fee;
        int discount_store;

        MemoryStream ms = new MemoryStream();
        byte[] PhotoByte = null;

        String name;
        public Admission_form(String name)
        {
            InitializeComponent();
            combo_course_name_fill();
            combo_batch_name_fill();
            this.name = name;
        }
        private void cmb_Course_Name_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            sql = "select duration,course_fee,discount from tbl_course where course_name='" + cmb_Course_Name.Text + "'";
            adapt = new SqlDataAdapter(sql, con);
            adapt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txt_CourseDuration.Text = Convert.ToString(dt.Rows[0]["duration"]);
                txt_CourseFee.Text = Convert.ToString(dt.Rows[0]["course_fee"]);
                course_fee = Convert.ToInt32(dt.Rows[0]["course_fee"]);
                discount = Convert.ToInt32(dt.Rows[0]["discount"]);

                chkb_discount.CheckedChanged += chkb_discount_CheckedChanged;
            }
        }
        private void chkb_discount_CheckedChanged(object sender, EventArgs e)
        {

            if (chkb_discount.Checked == true)
            {
                total_fee = course_fee - discount;
                discount_store = discount;
                txt_CourseFee.Text = total_fee.ToString();
            }
            else
            {
                total_fee = course_fee;
                txt_CourseFee.Text = total_fee.ToString();
            }
        }

        private void cmb_batch_name_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            sql = "select start_time ,end_time from tbl_batchdetail where batch_name='" + cmb_batch_name.Text + "'";
            adapt = new SqlDataAdapter(sql, con);
            adapt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txt_batchtiming.Text = Convert.ToString(dt.Rows[0]["start_time"]);
                txt_batchtiming.Text += " - " + Convert.ToString(dt.Rows[0]["end_time"]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(pb_photo.Image!=null)
            pb_photo.Image.Save(ms, ImageFormat.Jpeg);
            PhotoByte = ms.ToArray();
            string rb_gender = "";
            if (rb_male.Checked == true)
                rb_gender = rb_male.Text;

            else if (rb_female.Checked == true)
                rb_gender = rb_female.Text;

            string rb_category = "";

            if (rb_general.Checked == true)
                rb_category = rb_general.Text;

            else if (rb_obc.Checked == true)
                rb_category = rb_obc.Text;

            else if (rb_sc.Checked == true)
                rb_category = rb_sc.Text;

            else if (rb_st.Checked == true)
                rb_category = rb_st.Text;

            string rb_marital = "";
            if (rb_married.Checked == true)
                rb_marital = rb_married.Text;
            else if (rb_unmarried.Checked == true)
                rb_marital = rb_unmarried.Text;
            
            cmd = new SqlCommand("insert into tbl_student(Student_Id,Name,Fathersname_or_husbandsname,dob,gender,category,marial_status,Address,city,district,state,Pincode,Contact_No,Email_id,Parent_MobileNo,Fathers_Occ,photograph," +
               " HighSchool_stream,HighSchool_board,HighSchool_yearpassing,HighSchool_Marks,HighSchool_percentage,Inter_stream,Inter_board,Inter_yearpassing,Inter_Marks,Inter_percentage,Graduation_Stream,Graduation_university,Graduation_yearpassing,Graduation_Marks," +
               " Graduation_percentage,PostGraduation_Stream,PostGraduation_university,PostGraduation_yearpassing,PostGraduation_Marks,PostGraduation_percentage," +
               " Otherq_stream,Otherq_university,Otherq_yearpassing,Otherq_marks,Otherq_percentage," +
               "Admitted_on,CenterCode,RegistrationFee, Submitted_On,Submitted_By) " +
               "values(@Student_Id,@Name,@Fathersname_or_husbandsname,@dob,@gender,@category,@marial_status,@Address,@city,@district,@state,@Pincode,@Contact_No,@Email_id,@Parent_MobileNo,@Fathers_Occ,@photograph," +
               " @HighSchool_stream,@HighSchool_board,@HighSchool_yearpassing,@HighSchool_Marks,@HighSchool_percentage,@Inter_stream,@Inter_board,@Inter_yearpassing,@Inter_Marks,@Inter_percentage,@Graduation_Stream,@Graduation_university,@Graduation_yearpassing,@Graduation_Marks," +
               " @Graduation_percentage,@PostGraduation_Stream,@PostGraduation_university,@PostGraduation_yearpassing,@PostGraduation_Marks,@PostGraduation_percentage," +
               " @Otherq_stream,@Otherq_university,@Otherq_yearpassing,@Otherq_marks,@Otherq_percentage," +
               "@Admitted_on,@CenterCode,@RegistrationFee,GETDATE(),@Submitted_By)", con);
            Random r = new Random();
            String stdid = txt_Name.Text + r.Next(0, 10000) + txt_Address.Text.Substring(txt_Address.Text.Length - 1, 1);
            cmd.Parameters.AddWithValue("@Student_Id", stdid);
            cmd.Parameters.AddWithValue("@Name", txt_Name.Text.Trim());
            cmd.Parameters.AddWithValue("@Fathersname_or_husbandsname", txt_FatherName.Text.Trim());
            cmd.Parameters.AddWithValue("@dob", date_dob.Value);
            cmd.Parameters.AddWithValue("@gender", rb_gender);
            cmd.Parameters.AddWithValue("@category", rb_category);
            cmd.Parameters.AddWithValue("@marial_status", rb_marital);
            cmd.Parameters.AddWithValue("@Address", txt_Address.Text.Trim());
            cmd.Parameters.AddWithValue("@city", txt_City.Text.Trim());
            cmd.Parameters.AddWithValue("@district", txt_District.Text.Trim());
            cmd.Parameters.AddWithValue("@state", txt_State.Text.Trim());
            cmd.Parameters.AddWithValue("@Pincode", txt_pincode.Text.Trim());
            cmd.Parameters.AddWithValue("@Contact_No", txt_Contact.Text.Trim());
            cmd.Parameters.AddWithValue("@Email_id", txt_Email.Text.Trim());
            cmd.Parameters.AddWithValue("@Parent_MobileNo", txt_ParentMobile.Text.Trim());
            cmd.Parameters.AddWithValue("@Fathers_Occ", txt_FathersOcc.Text.Trim());
            cmd.Parameters.AddWithValue("@photograph", PhotoByte);
            cmd.Parameters.AddWithValue("@HighSchool_stream", txt_High_Stream.Text.Trim());
            cmd.Parameters.AddWithValue("@HighSchool_board", txt_High_Board.Text.Trim());
            cmd.Parameters.AddWithValue("@HighSchool_yearpassing", txt_High_Yearofpassing.Text.Trim());
            cmd.Parameters.AddWithValue("@HighSchool_Marks", txt_High_Marks.Text.Trim());
            cmd.Parameters.AddWithValue("@HighSchool_percentage", txt_High_Percentage.Text.Trim());
            cmd.Parameters.AddWithValue("@Inter_stream", txt_Inter_Stream.Text.Trim());
            cmd.Parameters.AddWithValue("@Inter_board", txt_Inter_Board.Text.Trim());
            cmd.Parameters.AddWithValue("@Inter_yearpassing", txt_Inter_Yearofpassing.Text.Trim());
            cmd.Parameters.AddWithValue("@Inter_Marks", txt_Inter_Marks.Text.Trim());
            cmd.Parameters.AddWithValue("@Inter_percentage", txt_Inter_Percentage.Text.Trim());
            cmd.Parameters.AddWithValue("@Graduation_Stream", txt_Graduation_Stream.Text.Trim());
            cmd.Parameters.AddWithValue("@Graduation_university", txt_graduation_University.Text.Trim());
            cmd.Parameters.AddWithValue("@Graduation_yearpassing", txt_Graduation_Yearofpassing.Text.Trim());
            cmd.Parameters.AddWithValue("@Graduation_Marks", txt_Graduation_Marks.Text.Trim());
            cmd.Parameters.AddWithValue("@Graduation_percentage", txt_Graduation_Percentage.Text.Trim());
            cmd.Parameters.AddWithValue("@PostGraduation_Stream", txt_PostGraduation_Stream.Text.Trim());
            cmd.Parameters.AddWithValue("@PostGraduation_university", txt_Postgraduation_University.Text.Trim());
            cmd.Parameters.AddWithValue("@PostGraduation_yearpassing", txt_PostGraduation_Yearofpassing.Text.Trim());
            cmd.Parameters.AddWithValue("@PostGraduation_Marks", txt_Postgraduation_Marks.Text.Trim());
            cmd.Parameters.AddWithValue("@PostGraduation_percentage", txt_pg_Percentage.Text.Trim());
            cmd.Parameters.AddWithValue("@Otherq_stream", txt_Otherq_Stream.Text.Trim());
            cmd.Parameters.AddWithValue("@Otherq_university", txt_Otherq_University.Text.Trim());
            cmd.Parameters.AddWithValue("@Otherq_yearpassing", txt_Otherq_Yearofpassing.Text.Trim());
            cmd.Parameters.AddWithValue("@Otherq_marks", txt_Otherq_Marks.Text.Trim());
            cmd.Parameters.AddWithValue("@Otherq_percentage", txt_Otherq_Percentage.Text.Trim());
            cmd.Parameters.AddWithValue("@Admitted_on", date_Admittedon.Value);
            cmd.Parameters.AddWithValue("@CenterCode", txt_CenterCode.Text);
            cmd.Parameters.AddWithValue("@RegistrationFee", txt_RegistrationFee.Text.Trim());
            cmd.Parameters.AddWithValue("@Submitted_By", name);
            con.Open();
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("INSERT INTO Tbl_StudentBatch(Student_Id, Batch_id) values('"+stdid+"',"+cmb_batch_name.SelectedValue+")", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Successfully");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            try
            {
                OpenFile.FileName = "";
                OpenFile.Title = "Photo:";
                OpenFile.Filter = "Image files:  All Files (*.*)|*.*|(*.jpg)|*.jpg|(*.jpeg)|*.jpeg|(*.png)|*.png|(*.Gif)|*.Gif|(*.bmp)|*.bmp";
                DialogResult res = OpenFile.ShowDialog();
                if (res == DialogResult.OK)
                {
                    this.pb_photo.Image = System.Drawing.Image.FromFile(OpenFile.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void combo_course_name_fill()
        {
            DataTable dt = new DataTable();
            sql = "select course_id,Course_name from tbl_course";
            adapt = new SqlDataAdapter(sql, con);
            adapt.Fill(dt);
            cmb_Course_Name.DataSource = dt;
            cmb_Course_Name.DisplayMember = "Course_name";
            cmb_Course_Name.ValueMember = "Course_id";
        }
        void combo_batch_name_fill()
        {
            DataTable dt = new DataTable();
            sql = "select batch_id,batch_name from tbl_batchdetail";
            adapt = new SqlDataAdapter(sql, con);
            adapt.Fill(dt);
            cmb_batch_name.DataSource = dt;
            cmb_batch_name.DisplayMember = "batch_name";
            cmb_batch_name.ValueMember = "batch_id";
        }
    }
}
