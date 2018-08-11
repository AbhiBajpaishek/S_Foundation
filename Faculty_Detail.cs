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
using System.IO;
using System.Drawing.Imaging;
namespace S_Foundation
{
    public partial class Faculty_Detail : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F1LPI1N\MSSQLSERVER1;Initial Catalog=S_Foundation;User ID=sa;password=1234");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        string sql;
        DataTable dt = new DataTable();
        string name;
        int ID;

        string[] course = { "C", "ASP.NET", "CCC", "PHP", "JAVA", "Python", "MVC" };

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
                OpenFile.Filter = "Image files: (*.jpg)|*.jpg|(*.jpeg)|*.jpeg|(*.png)|*.png|(*.Gif)|*.Gif|(*.bmp)|*.bmp| All Files (*.*)|*.*";
                DialogResult res = OpenFile.ShowDialog();
                if (res == DialogResult.OK)
                {
                    this.pb_Pic.Image = System.Drawing.Image.FromFile(OpenFile.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pb_Pic.Image.Save(ms, ImageFormat.Jpeg);
            PhotoByte = ms.ToArray();

            try
            {
                cmd = new SqlCommand("insert into tbl_faculty(Name,DOB,Address,Contact_no,Email,exp_year,started_on,photograph,Submitted_On,Submitted_By) values(@Name,@dob,@Address,@Contact_no,@Email,@exp_year,@started_on,@photograph,GETDATE(),@Submitted_By)", con);
                con.Open();

                cmd.Parameters.AddWithValue("@name", txt_Name.Text);
                cmd.Parameters.AddWithValue("@dob", dp_dob.Value);
                cmd.Parameters.AddWithValue("@address", txt_Address.Text);
                cmd.Parameters.AddWithValue("@contact_no", txt_Contact.Text);
                cmd.Parameters.AddWithValue("@email", txt_Email.Text);
                cmd.Parameters.AddWithValue("@exp_year", txt_expyear.Text);
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
        void conv_photo()
        {

            if (pb_Pic.Image != null)
            {

                ms = new MemoryStream();
                pb_Pic.Image.Save(ms, ImageFormat.Jpeg);
                byte[] photo_aray = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo_aray, 0, photo_aray.Length);
                cmd.Parameters.AddWithValue("@photo", photo_aray);
            }
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
        //}


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Faculty_Detail_Load(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                Bydate();
            else if (radioButton2.Checked == true)
                Byname();
            else if (radioButton3.Checked == true)
                Bycourse();
        }
        public void Bydate()
        {
            //con.Open();
            //DataTable dt = new DataTable();
            //sql = "select * from tbl_enquiry where  submitted_on >= Convert(datetime,'" + dateTimePicker1.Value + "',103) and submitted_on <= Convert(datetime,'" + dateTimePicker2.Value + "',103)+1-0.0009;";
            //adapt = new SqlDataAdapter(sql, con);
            //adapt.Fill(dt);
            //dataGridView1.DataSource = dt;
            //con.Close();
        }
        public void Byname()
        {
            con.Open();
            DataTable dt = new DataTable();
            sql = "select * from tbl_faculty where name='" + txt_Byname.Text + "'";
            adapt = new SqlDataAdapter(sql, con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        public void Bycourse()
        {
            //con.Open();
            //DataTable dt = new DataTable();
            //sql = "select * from tbl_enquiry where course_seek_for='" + comboBox3.SelectedItem + "'";
            //adapt = new SqlDataAdapter(sql, con);
            //adapt.Fill(dt);
            //dataGridView1.DataSource = dt;
            //con.Close();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_Name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Address.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_Contact.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_Email.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
         
            txt_expyear.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
           
        }
    }
}
