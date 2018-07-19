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
using Excel = Microsoft.Office.Interop.Excel;


namespace S_Foundation

{
    public partial class Enquiry_Form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=S_Foundation;Integrated Security=true");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        string sql;
        DataTable dt = new DataTable();
        string name;
        string[] timing = { "Morning", "Afternoon", "Evening" };
        int ID;
        public Enquiry_Form(string name)
        {
            InitializeComponent();
            this.name = name;
        }

        private void Enquiry_Form_Load(object sender, EventArgs e)
        {

            dateTimePicker2.Value = System.DateTime.Now;
            rb_date.Checked = true;
            combo1fill();
            combo2fill();                       
            comboBox2.DataSource = timing;
        }
        void combo1fill()
        {
            con.Open();
            DataTable dt = new DataTable();
            sql = "select Course_name from tbl_couse";
            adapt = new SqlDataAdapter(sql, con);
            adapt.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Course_name";
            comboBox1.ValueMember = "Course_name";
            con.Close();

        }
        void combo2fill()
        {
            con.Open();
            DataTable dt = new DataTable();
            sql = "select Course_name from tbl_couse";
            adapt = new SqlDataAdapter(sql, con);
            adapt.Fill(dt);
            comboBox3.DataSource = dt;
            comboBox3.DisplayMember = "Course_name";
            comboBox3.ValueMember = "Course_name";
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            cmd = new SqlCommand("insert into tbl_enquiry(Course_seek_for,Name,Address,Contact_no,Email,Referred_by,Batch_timing,Submitted_On,Submitted_By) values(@course,@name,@address,@contact,@email,@referred_by,@batch_timing, GETDATE(),@submitted_by)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@course", comboBox1.Text);
            cmd.Parameters.AddWithValue("@name", txt_Name.Text);
            cmd.Parameters.AddWithValue("@address", txt_Address.Text);
            cmd.Parameters.AddWithValue("@contact", txt_Contact.Text);
            cmd.Parameters.AddWithValue("@email", txt_Email.Text);
            cmd.Parameters.AddWithValue("@referred_by", txt_referred.Text);
            cmd.Parameters.AddWithValue("@batch_timing", comboBox2.Text);
            cmd.Parameters.AddWithValue("@submitted_by", name);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Successfully");
            Clear();
        }
        void Clear()
        {
            comboBox1.SelectedIndex = 0;
            txt_Name.Text = "";
            txt_Address.Text = "";
            txt_Contact.Text = "";
            txt_Email.Text = "";
            txt_referred.Text = "";
            comboBox2.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (rb_date.Checked == true)
                Bydate();
            else if (radioButton2.Checked == true)
                Byname();
            else if (radioButton3.Checked == true)
                Bycourse();     
            
        }
        public void Bydate()
        {
            con.Open();
            DataTable dt = new DataTable();
            sql = "select * from tbl_enquiry where  submitted_on >= Convert(datetime,'" + dateTimePicker1.Value + "',103) and submitted_on <= Convert(datetime,'" + dateTimePicker2.Value + "',103)+1-0.0009;";
            adapt = new SqlDataAdapter(sql, con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        public void Byname()
        {
            con.Open();
            DataTable dt = new DataTable();
            sql = "select * from tbl_enquiry where name='"+txt_Byname.Text+"'";
            adapt = new SqlDataAdapter(sql, con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }
        public void Bycourse()
        {

            con.Open();
            DataTable dt = new DataTable();
            sql = "select * from tbl_enquiry where course_seek_for='" + comboBox3.Text+ "'";
            adapt = new SqlDataAdapter(sql, con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            cmd = new SqlCommand("update tbl_enquiry set course_seek_for=@course,name=@name,address=@address,contact_no=@contact,email=@email where enquiry_no=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", ID);
            cmd.Parameters.AddWithValue("@course", comboBox1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@name", txt_Name.Text);
            cmd.Parameters.AddWithValue("@address", txt_Address.Text);
            cmd.Parameters.AddWithValue("@contact", txt_Contact.Text);
            cmd.Parameters.AddWithValue("@email", txt_Email.Text);
            cmd.Parameters.AddWithValue("@referred_by", txt_referred.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated Successfully");
            con.Close();
            Clear();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            comboBox1.Text= dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Name.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_Address.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_Contact.Text= dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_Email.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_referred.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            comboBox2.Text=dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("delete from tbl_enquiry where enquiry_no='" + ID + "'", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                int Result = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                Clear();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            sql = "select * from tbl_enquiry ";
            adapt = new SqlDataAdapter(sql, con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
                    Excel.Application xlApp;
                    Excel.Workbook xlWorkBook;
                    Excel.Worksheet xlWorkSheet;
                    object misValue = System.Reflection.Missing.Value;
                    
                    xlApp = new Excel.Application();
                    xlWorkBook = xlApp.Workbooks.Add(misValue);
                    xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                   

                    int a = 1;
                    for (a = 1; a < dataGridView1.Columns.Count + 1; a++)
                    {
                        xlWorkSheet.Cells[1, a] = dataGridView1.Columns[a - 1].HeaderText;
                    }
                    int i = 0;
                    int j = 0;

                    for (i = 0; i <= dataGridView1.RowCount - 1; i++)
                    {
                        for (j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                        {
                            DataGridViewCell cell = dataGridView1[j, i];
                            xlWorkSheet.Cells[i + 2, j + 1] = cell.Value;
                        }
                    }

                    xlWorkBook.SaveAs("Enquiry_details.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                    xlWorkBook.Close(true, misValue, misValue);
                    xlApp.Quit();

                    releaseObject(xlWorkSheet);
                    releaseObject(xlWorkBook);
                    releaseObject(xlApp);

                    MessageBox.Show("Excel file created");
               
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
