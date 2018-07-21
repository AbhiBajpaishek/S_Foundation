using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Data.SqlClient;


namespace S_Foundation
{
    public partial class Admin_registration : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F1LPI1N\MSSQLSERVER1;Initial Catalog=S_Foundation;User ID=sa;password=1234");
        SqlCommand cmd;
        MemoryStream ms = new MemoryStream();
        byte[] PhotoByte = null;
        
        public Admin_registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                admin_register();
            else if (radioButton2.Checked == true)
                user_register();
        }
        public void admin_register()
        {
            pb_Pic.Image.Save(ms, ImageFormat.Jpeg);
            PhotoByte = ms.ToArray();

            cmd = new SqlCommand("insert into s_admin(Name,dob,userid,password,email_id,photograph) values(@name,@dob,@userid,@password,@emailid,@pic)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@name", txt_Name.Text);         
            cmd.Parameters.AddWithValue("@dob", dp_Dob.Value.Date);
            cmd.Parameters.AddWithValue("@userid", txt_Userid.Text);
            cmd.Parameters.AddWithValue("@password", txt_password.Text);
            cmd.Parameters.AddWithValue("@emailid", txt_Emailid.Text);
            cmd.Parameters.AddWithValue("@pic", PhotoByte);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Successfully");

        }
        //void conv_photo()
        //{
            
        //    if (pb_Pic.Image != null)
        //    {
                
        //        ms = new MemoryStream();
        //        pb_Pic.Image.Save(ms, ImageFormat.Jpeg);
        //        byte[] photo_aray = new byte[ms.Length];
        //        ms.Position = 0;
        //        ms.Read(photo_aray, 0, photo_aray.Length);
        //        cmd.Parameters.AddWithValue("@photo", photo_aray);
        //    }
        //}

        public void user_register()
        {
            pb_Pic.Image.Save(ms, ImageFormat.Jpeg);
            PhotoByte = ms.ToArray();

            cmd = new SqlCommand("insert into s_user(Name,dob,userid,password,email_id,photograph) values(@name,@dob,@userid,@password,@emailid,@pic)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@name", txt_Name.Text);
            cmd.Parameters.AddWithValue("@dob", dp_Dob.Value.Date);
            cmd.Parameters.AddWithValue("@userid", txt_Userid.Text);
            cmd.Parameters.AddWithValue("@password", txt_password.Text);
            cmd.Parameters.AddWithValue("@emailid", txt_Emailid.Text);
            cmd.Parameters.AddWithValue("@pic", PhotoByte);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Successfully");
        }
        private void button4_Click(object sender, EventArgs e)
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            dp_Dob.Value = DateTime.Today;
        }

        private void button5_Click(object sender, EventArgs e)
        {
          

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginPanel loginPanel = new LoginPanel();
            this.Hide();
            loginPanel.Show();
        }
    }
}
