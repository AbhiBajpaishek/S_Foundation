using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S_Foundation
{
    public partial class demo : Form
    {
        public demo()
        {
            InitializeComponent();
        }

        private void demo_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Aishwarya";
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.Text ="verma";

            }
        }
    }
}
