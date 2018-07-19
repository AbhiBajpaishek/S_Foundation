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
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=S_Foundation;Integrated Security=true");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        string sql;
        String name;
        public Batch_details(string name)
        {
            InitializeComponent();
            this.name = name;
            FillCmbHousMinutes();
        }

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
      
        private void button1_Click(object sender, EventArgs e)
        {
            int start_time_hr = Convert.ToInt32(cmbHourStart.Text);
            int start_tim_min = Convert.ToInt32(cmbMinutesStart.Text);
            cmd = new SqlCommand("insert into tbl_batchdetail(batch_name,start_date,start_time,end_date,end_time,Submitted_On,Submitted_By) values "+
                "(@batch_name,@start_date,@start_time,@end_date,@end_time,GETDATE(),@Submitted_By)", con);
            con.Open();

            cmd.Parameters.AddWithValue("@batch_name", txt_BatchName.Text);
            cmd.Parameters.AddWithValue("@start_date", dateStart.Value);
            cmd.Parameters.AddWithValue("@start_time", cmbHourStart.Text +":"+ cmbMinutesStart.Text);
            cmd.Parameters.AddWithValue("@end_date", dateEnd.Value);
            cmd.Parameters.AddWithValue("@end_time", cmbHourEnd.Text+":" + cmbMinuteEnd.Text);
            cmd.Parameters.AddWithValue("@submitted_by", name);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Successfully");

        }
    }
}
