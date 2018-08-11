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
    public partial class Batch_details : Form
    {
        DBClass db = new DBClass();
        String name;
        public Batch_details(string name)
        {
            InitializeComponent();
            this.name = name;
            FillCmbHousMinutes();
            fillComboBoxCourse();
            fillDataGridBatchDetails();
        }
        //initialising timing
        private void FillCmbHousMinutes()
        {
            try
            {
                string Valu = "0";
                for (int i=0; i<24;i++)
                {
                    Valu = i < 10 ? "0" + i.ToString() : i.ToString();
                    cmbHourStart.Items.Add(Valu);
                    cmbHourEnd.Items.Add(Valu);
                }
                for (int i = 0; i < 60; i++)
                {
                    Valu = i < 10 ? "0" + i.ToString() : i.ToString();
                    cmbMinutesStart.Items.Add(Valu);
                    cmbMinuteEnd.Items.Add(Valu);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // declared the datasource for Course Combo box
        void fillComboBoxCourse()
        {
          comboBoxCourse.DataSource= db.ReadBulkData("select course_id, course_name from tbl_course");
          comboBoxCourse.DisplayMember = "course_name";
          comboBoxCourse.ValueMember = "course_id";
        }
        // for filling all batches details in gridview
        void fillDataGridBatchDetails()
        {
            dataGridBatchDetails.DataSource = db.ReadBulkData("select * from tbl_batchdetail");
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            if(db.InsertUpdateDelete("insert into tbl_batchdetail(batch_name, course_id, start_date, start_time, end_date, end_time, Submitted_On, Submitted_By) values ('" + txt_BatchName.Text + "','" + comboBoxCourse.SelectedItem + "','" + dateStart.Text + "','" + cmbHourStart.Text + cmbHourEnd.Text + "','" + dateEnd.Text + "','" + cmbHourEnd.Text + cmbMinuteEnd.Text + "','" + DateTime.Now + "','" + name + "')"))
                MessageBox.Show("Record Inserted Successfully");
        }
    }
}
