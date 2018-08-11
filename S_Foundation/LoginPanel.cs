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
        string sql;
        DBClass db = new DBClass();
        public LoginPanel()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (emptyCheck(txt_Userid.Text,txt_Password.Text) == false)
                return;
            if (rb_admin.Checked == true)
                admincheck("Admin");
            else if (rb_user.Checked == true)
                admincheck("User");
        }

        public void admincheck(string type)
        {
            try
            {
                sql = "select Password from Tbl_users where Email='" + txt_Userid.Text + "' and Type= '"+type+"'";                
                if (db.readScalarData(sql) == null)
                {
                    MessageBox.Show("Invalid UserId");
                    return;
                }
                string pass = db.readScalarData(sql).ToString();
                if (pass==txt_Password.Text)
                {
                    this.Hide();
                    Form1 f1 = new Form1(rb_admin.Text,txt_Userid.Text);
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
            }
        }

        private void LoginPanel_Load(object sender, EventArgs e)
        {
            txt_Userid.Focus();
            rb_admin.Checked = true;                
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
