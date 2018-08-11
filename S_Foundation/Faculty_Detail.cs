using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace S_Foundation
{
    public partial class Faculty_Detail : Form
    {
        DBClass db = new DBClass();
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=S_Foundation;Integrated Security=true");
        SqlCommand cmd;
        DataTable dt = new DataTable();
        string name;
        MemoryStream ms = new MemoryStream();
        byte[] PhotoByte = null;

        public Faculty_Detail( string name)
        {
            InitializeComponent();
            this.name = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            try
            {
                OpenFile.FileName = "";
                OpenFile.Title = "Photo:";
                OpenFile.Filter = "All Images(*.jpg;*.jpeg)|*.jpg;*.jpeg| (*.jpg)|*.jpg|(*.jpeg)|*.jpeg";
                DialogResult res = OpenFile.ShowDialog();
                if (res == DialogResult.OK)
                {
                    this.pb_Pic.Image = Image.FromFile(OpenFile.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            pb_Pic.Image.Save(ms, ImageFormat.Jpeg);
            PhotoByte = ms.ToArray();
            try
            {                
                cmd = new SqlCommand("insert into tbl_faculty(Name,DOB,Address,Contact_no,Email,started_on,photograph,Submitted_On,Submitted_By) values(@Name,@dob,@Address,@Contact_no,@Email,@started_on,@photograph,GETDATE(),@Submitted_By)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@name", txt_Name.Text);
                cmd.Parameters.AddWithValue("@dob", dp_dob.Value);
                cmd.Parameters.AddWithValue("@address", txt_Address.Text);
                cmd.Parameters.AddWithValue("@contact_no", txt_Contact.Text);
                cmd.Parameters.AddWithValue("@email", txt_Email.Text);
                cmd.Parameters.AddWithValue("@started_on", dp_startedon.Value);
                cmd.Parameters.AddWithValue("@photograph", PhotoByte);
                cmd.Parameters.AddWithValue("@Submitted_by", name);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //Clear();
        }

        //void Clear()
        //{
        //    comboBox1.SelectedIndex = 0;
        //    txt_Name.Text = "";
        //    txt_Address.Text = "";
        //    txt_Contact.Text = "";
        //    txt_Email.Text = "";
        //    txt_referred.Text = "";
        //    comboBox2.SelectedIndex = 0;
        ////}


        private void Faculty_Detail_Load(object sender, EventArgs e)
        {
            fillSearchFilters();
            dataGridViewFacultyDetails.DataSource = db.ReadBulkData("select * from Tbl_faculty");
        }

        //for data binding of search filters
         void fillSearchFilters()
        {
            radioBtnId.Checked = true;
            comboBoxFilterBy.DataSource = db.ReadBulkData("select Faculty_id from tbl_faculty");
            comboBoxFilterBy.DisplayMember = "Faculty_id";
         }


        private void button4_Click(object sender, EventArgs e)
        {
            if (radioBtnId.Checked == true)
                byId();
            else if (radioBtnName.Checked == true)
                byName();
            else if (radioBtnCourse.Checked == true)
                byCourse();
        }

        public void readData(DataTable dt)
        {
            if (dt.Rows.Count > 0)
            {
                txt_Name.Text = dt.Rows[0][1].ToString();
                dp_dob.Value = (DateTime)dt.Rows[0][2];
                txt_Address.Text = dt.Rows[0][3].ToString();
                txt_Contact.Text = dt.Rows[0][4].ToString();
                txt_Email.Text = dt.Rows[0][5].ToString();
                dp_startedon.Value = (DateTime)dt.Rows[0][6];
                if (dt.Rows[0][7] != null)
                {
                    byte[] arr = (byte[])dt.Rows[0][7];
                    ms = new MemoryStream(arr);
                    Image returnImage = Image.FromStream(ms);
                    pb_Pic.Image = returnImage;
                }
            }
            else
            {
                MessageBox.Show("No Record Found");
            }
            
            
        }

        public void byId()
        {
            dt= db.ReadBulkData("select * from tbl_faculty where Faculty_id=" + comboBoxFilterBy.Text);
            dataGridViewFacultyDetails.DataSource = dt;
            readData(dt);            
        }
        public void byName()
        {
            dt= db.ReadBulkData("select * from tbl_faculty where name='" + comboBoxFilterBy.Text + "'");
            dataGridViewFacultyDetails.DataSource = dt;
            readData(dt);
        }
        public void byCourse()
        {
            //con.Open();            //DataTable dt = new DataTable();           //sql = "select * from tbl_enquiry where course_seek_for='" + comboBox3.SelectedItem + "'";
            //adapt = new SqlDataAdapter(sql, con);
            //adapt.Fill(dt);
            //dataGridViewFacultyDetails.DataSource = db.ReadBulkData("select * from tbl_enquiry where course_seek_for='" + comboBoxCourse.SelectedItem + "'");
            //con.Close();
        }

        private void radioBtnId_CheckedChanged(object sender, EventArgs e)
        {
            if(radioBtnId.Checked)
            {
                comboBoxFilterBy.DataSource = db.ReadBulkData("select Faculty_id from tbl_Faculty");
                comboBoxFilterBy.DisplayMember = "Faculty_id";
            }
        }

        private void radioBtnName_CheckedChanged(object sender, EventArgs e)
        {
            if(radioBtnName.Checked)
            {
                comboBoxFilterBy.DataSource = db.ReadBulkData("select Name from tbl_Faculty");
                comboBoxFilterBy.DisplayMember = "Name";
            }
        }

        private void radioBtnCourse_CheckedChanged(object sender, EventArgs e)
        {
            if(radioBtnCourse.Checked)
            {
                //comboBoxFilterBy.DataSource="select "
            }
        }

        private void radioButtonShowAll_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonShowAll.Checked)
            {
                dataGridViewFacultyDetails.DataSource = db.ReadBulkData("select * from Tbl_faculty");
            }
        }
    }
}
