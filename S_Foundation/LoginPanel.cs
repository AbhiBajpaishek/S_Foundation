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
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=S_Foundation;Integrated Security=true");
        SqlCommand cmd;
        SqlDataReader dr;
        string sql;
        DBClass db = new DBClass();
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
            if (emptyCheck(txt_Userid.Text,txt_Password.Text) == false)
                return;
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
                sql = "select password from s_admin where userid='" + admin_name + "'";                
                if (db.readScalarData(sql) == null)
                {
                    MessageBox.Show("Invalid UserId");
                    return;
                }
                string pass = db.readScalarData(sql).ToString();
                if (pass==admin_pass)
                {
                    this.Hide();
                    Form1 f1 = new Form1(rb_admin.Text,admin_name);
                    f1.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Password");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.Beep();
            }
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
            string user_name, user_pass;
            user_name = txt_Userid.Text.Trim();
            user_pass = txt_Password.Text.Trim();
                try
                {
                    sql = "select password from s_user where userid='" + user_name + "'";
                    if (db.readScalarData(sql) == null)
                    {
                        MessageBox.Show("Invalid UserId");
                        return;
                    }
                    string pass = db.readScalarData(sql).ToString();
                    if (pass == user_pass)
                    {
                        this.Hide();
                        Form1 f1 = new Form1(rb_admin.Text, user_name);
                        f1.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Password");
                    }
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }


        public bool emptyCheck(String id,String pass)
        {
            if (id == "")
            {
                if (pass == "")
                    MessageBox.Show("Please Enter Id and Password");
                else
                    MessageBox.Show("Please Enter Id");
                return false;
            }
            else if(pass=="")
            {
                MessageBox.Show("Please Enter Password");
                return false;
            }
            return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
