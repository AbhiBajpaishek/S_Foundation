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
    public partial class LoginPanel : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F1LPI1N\MSSQLSERVER1;Initial Catalog=s_foundation;User ID=sa;password=1234");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        SqlDataReader dr;
        string str, sql;
        public LoginPanel()
        {
            InitializeComponent();
        }
        
        private void label3_Click(object sender, EventArgs e)
        {
            Admin_registration objar = new Admin_registration();
            this.Hide();

            objar.Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (rb_admin.Checked == true)
                admincheck();
            else if (rb_user.Checked == true)
                usercheck();
        }
        
        public void admincheck()
        {
            string admin_name, admin_pass;

            admin_name = txt_Userid.Text.Trim();
            admin_pass = txt_Password.Text.Trim();
            try
            {
                sql = "select userid,password from s_admin where userid='" + admin_name + "'and password='" + admin_pass + "'";
                con.Open();
                cmd = new SqlCommand(sql, con);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    this.Hide();
                    Form1 f1 = new Form1(rb_admin.Text,admin_name);
                    f1.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Login please check username and password");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            dr.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LoginPanel_Load(object sender, EventArgs e)
        {
            txt_Userid.Focus();
            rb_admin.Checked = true;
                       
        }

        public void usercheck()
        {
            string admin_name, admin_pass;

            admin_name = txt_Userid.Text.Trim();
            admin_pass = txt_Password.Text.Trim();
            try
            {
                sql = "select userid,password from s_user where userid='" + admin_name + "'and password='" + admin_pass + "'";
                con.Open();
                cmd = new SqlCommand(sql, con);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    this.Hide();
                    Form1 f1 = new Form1(rb_user.Text,admin_name);
                    f1.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Login please check username and password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            dr.Close();
        }
    }
}
