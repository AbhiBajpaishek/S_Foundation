namespace S_Foundation
{
    partial class Faculty_Detail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dp_startedon = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pb_Pic = new System.Windows.Forms.PictureBox();
            this.dp_dob = new System.Windows.Forms.DateTimePicker();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Contact = new System.Windows.Forms.TextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridViewFacultyDetails = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxFilterBy = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.radioBtnCourse = new System.Windows.Forms.RadioButton();
            this.radioBtnName = new System.Windows.Forms.RadioButton();
            this.radioBtnId = new System.Windows.Forms.RadioButton();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.radioButtonShowAll = new System.Windows.Forms.RadioButton();
            this.contextMenuStripImageBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacultyDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.contextMenuStripImageBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dp_startedon);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnSubmit);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.pb_Pic);
            this.groupBox2.Controls.Add(this.dp_dob);
            this.groupBox2.Controls.Add(this.txt_Email);
            this.groupBox2.Controls.Add(this.txt_Contact);
            this.groupBox2.Controls.Add(this.txt_Address);
            this.groupBox2.Controls.Add(this.txt_Name);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(137, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(771, 306);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add faculty details";
            // 
            // dp_startedon
            // 
            this.dp_startedon.Location = new System.Drawing.Point(225, 216);
            this.dp_startedon.Name = "dp_startedon";
            this.dp_startedon.Size = new System.Drawing.Size(200, 20);
            this.dp_startedon.TabIndex = 19;
            this.dp_startedon.Value = new System.DateTime(2017, 7, 22, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Started On:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(137, 265);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(248, 23);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(555, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(555, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pb_Pic
            // 
            this.pb_Pic.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pb_Pic.ContextMenuStrip = this.contextMenuStripImageBox;
            this.pb_Pic.ErrorImage = global::S_Foundation.Properties.Resources.user;
            this.pb_Pic.Image = global::S_Foundation.Properties.Resources.user;
            this.pb_Pic.InitialImage = global::S_Foundation.Properties.Resources.user;
            this.pb_Pic.Location = new System.Drawing.Point(538, 26);
            this.pb_Pic.Name = "pb_Pic";
            this.pb_Pic.Size = new System.Drawing.Size(145, 168);
            this.pb_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Pic.TabIndex = 14;
            this.pb_Pic.TabStop = false;
            // 
            // dp_dob
            // 
            this.dp_dob.Location = new System.Drawing.Point(225, 54);
            this.dp_dob.Name = "dp_dob";
            this.dp_dob.Size = new System.Drawing.Size(200, 20);
            this.dp_dob.TabIndex = 13;
            this.dp_dob.Value = new System.DateTime(2017, 7, 22, 0, 0, 0, 0);
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(225, 177);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(200, 20);
            this.txt_Email.TabIndex = 10;
            // 
            // txt_Contact
            // 
            this.txt_Contact.Location = new System.Drawing.Point(225, 142);
            this.txt_Contact.Name = "txt_Contact";
            this.txt_Contact.Size = new System.Drawing.Size(200, 20);
            this.txt_Contact.TabIndex = 9;
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(225, 87);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(200, 43);
            this.txt_Address.TabIndex = 8;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(225, 22);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(200, 20);
            this.txt_Name.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(97, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "E-mail:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(97, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Contact No.:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(97, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Address:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(97, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Date of Birth:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(97, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Name:";
            // 
            // dataGridViewFacultyDetails
            // 
            this.dataGridViewFacultyDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFacultyDetails.Location = new System.Drawing.Point(12, 371);
            this.dataGridViewFacultyDetails.Name = "dataGridViewFacultyDetails";
            this.dataGridViewFacultyDetails.Size = new System.Drawing.Size(1005, 238);
            this.dataGridViewFacultyDetails.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonShowAll);
            this.groupBox1.Controls.Add(this.comboBoxFilterBy);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.radioBtnCourse);
            this.groupBox1.Controls.Add(this.radioBtnName);
            this.groupBox1.Controls.Add(this.radioBtnId);
            this.groupBox1.Location = new System.Drawing.Point(72, 315);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(887, 50);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Searching Filter";
            // 
            // comboBoxFilterBy
            // 
            this.comboBoxFilterBy.FormattingEnabled = true;
            this.comboBoxFilterBy.Location = new System.Drawing.Point(554, 17);
            this.comboBoxFilterBy.Name = "comboBoxFilterBy";
            this.comboBoxFilterBy.Size = new System.Drawing.Size(158, 21);
            this.comboBoxFilterBy.TabIndex = 15;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(738, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // radioBtnCourse
            // 
            this.radioBtnCourse.AutoSize = true;
            this.radioBtnCourse.Location = new System.Drawing.Point(233, 23);
            this.radioBtnCourse.Name = "radioBtnCourse";
            this.radioBtnCourse.Size = new System.Drawing.Size(76, 17);
            this.radioBtnCourse.TabIndex = 14;
            this.radioBtnCourse.TabStop = true;
            this.radioBtnCourse.Text = "By Course:";
            this.radioBtnCourse.UseVisualStyleBackColor = true;
            this.radioBtnCourse.CheckedChanged += new System.EventHandler(this.radioBtnCourse_CheckedChanged);
            // 
            // radioBtnName
            // 
            this.radioBtnName.AutoSize = true;
            this.radioBtnName.Location = new System.Drawing.Point(115, 23);
            this.radioBtnName.Name = "radioBtnName";
            this.radioBtnName.Size = new System.Drawing.Size(71, 17);
            this.radioBtnName.TabIndex = 13;
            this.radioBtnName.TabStop = true;
            this.radioBtnName.Text = "By Name:";
            this.radioBtnName.UseVisualStyleBackColor = true;
            this.radioBtnName.CheckedChanged += new System.EventHandler(this.radioBtnName_CheckedChanged);
            // 
            // radioBtnId
            // 
            this.radioBtnId.AutoSize = true;
            this.radioBtnId.Location = new System.Drawing.Point(13, 23);
            this.radioBtnId.Name = "radioBtnId";
            this.radioBtnId.Size = new System.Drawing.Size(52, 17);
            this.radioBtnId.TabIndex = 12;
            this.radioBtnId.TabStop = true;
            this.radioBtnId.Text = "By Id:";
            this.radioBtnId.UseVisualStyleBackColor = true;
            this.radioBtnId.CheckedChanged += new System.EventHandler(this.radioBtnId_CheckedChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(313, 625);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 23);
            this.button5.TabIndex = 26;
            this.button5.Text = "Update";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(491, 625);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(133, 23);
            this.button6.TabIndex = 27;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // radioButtonShowAll
            // 
            this.radioButtonShowAll.AutoSize = true;
            this.radioButtonShowAll.Location = new System.Drawing.Point(367, 23);
            this.radioButtonShowAll.Name = "radioButtonShowAll";
            this.radioButtonShowAll.Size = new System.Drawing.Size(69, 17);
            this.radioButtonShowAll.TabIndex = 19;
            this.radioButtonShowAll.TabStop = true;
            this.radioButtonShowAll.Text = "Show All:";
            this.radioButtonShowAll.UseVisualStyleBackColor = true;
            this.radioButtonShowAll.CheckedChanged += new System.EventHandler(this.radioButtonShowAll_CheckedChanged);
            // 
            // contextMenuStripImageBox
            // 
            this.contextMenuStripImageBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStripImageBox.Name = "contextMenuStripImageBox";
            this.contextMenuStripImageBox.Size = new System.Drawing.Size(148, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItem1.Text = "Open Camera";
            // 
            // Faculty_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 657);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewFacultyDetails);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Faculty_Detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faculty_Detail";
            this.Load += new System.EventHandler(this.Faculty_Detail_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacultyDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStripImageBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dp_dob;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Contact;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pb_Pic;
        private System.Windows.Forms.DataGridView dataGridViewFacultyDetails;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnCourse;
        private System.Windows.Forms.RadioButton radioBtnName;
        private System.Windows.Forms.RadioButton radioBtnId;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DateTimePicker dp_startedon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxFilterBy;
        private System.Windows.Forms.RadioButton radioButtonShowAll;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripImageBox;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}