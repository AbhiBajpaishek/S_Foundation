namespace S_Foundation
{
    partial class AdminDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.topPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCount3 = new System.Windows.Forms.Label();
            this.msg3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCount2 = new System.Windows.Forms.Label();
            this.msg2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCount = new System.Windows.Forms.Label();
            this.msg1 = new System.Windows.Forms.Label();
            this.downPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCount4 = new System.Windows.Forms.Label();
            this.msg4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.topPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.downPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Black;
            this.topPanel.Controls.Add(this.panel4);
            this.topPanel.Controls.Add(this.panel3);
            this.topPanel.Controls.Add(this.panel2);
            this.topPanel.Controls.Add(this.panel1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(884, 96);
            this.topPanel.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblCount3);
            this.panel3.Controls.Add(this.msg3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(466, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 96);
            this.panel3.TabIndex = 2;
            // 
            // lblCount3
            // 
            this.lblCount3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCount3.AutoSize = true;
            this.lblCount3.BackColor = System.Drawing.Color.Black;
            this.lblCount3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblCount3.ForeColor = System.Drawing.Color.Yellow;
            this.lblCount3.Location = new System.Drawing.Point(89, 21);
            this.lblCount3.Name = "lblCount3";
            this.lblCount3.Size = new System.Drawing.Size(29, 31);
            this.lblCount3.TabIndex = 1;
            this.lblCount3.Text = "3";
            // 
            // msg3
            // 
            this.msg3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.msg3.AutoSize = true;
            this.msg3.BackColor = System.Drawing.Color.Black;
            this.msg3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.msg3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.msg3.Location = new System.Drawing.Point(51, 56);
            this.msg3.Name = "msg3";
            this.msg3.Size = new System.Drawing.Size(123, 24);
            this.msg3.TabIndex = 0;
            this.msg3.Text = "Total Batches";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCount2);
            this.panel2.Controls.Add(this.msg2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(233, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 96);
            this.panel2.TabIndex = 1;
            // 
            // lblCount2
            // 
            this.lblCount2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCount2.AutoSize = true;
            this.lblCount2.BackColor = System.Drawing.Color.Black;
            this.lblCount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblCount2.ForeColor = System.Drawing.Color.Yellow;
            this.lblCount2.Location = new System.Drawing.Point(101, 21);
            this.lblCount2.Name = "lblCount2";
            this.lblCount2.Size = new System.Drawing.Size(29, 31);
            this.lblCount2.TabIndex = 1;
            this.lblCount2.Text = "6";
            this.lblCount2.Click += new System.EventHandler(this.lblCount2_Click);
            // 
            // msg2
            // 
            this.msg2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.msg2.AutoSize = true;
            this.msg2.BackColor = System.Drawing.Color.Black;
            this.msg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.msg2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.msg2.Location = new System.Drawing.Point(63, 56);
            this.msg2.Name = "msg2";
            this.msg2.Size = new System.Drawing.Size(116, 24);
            this.msg2.TabIndex = 0;
            this.msg2.Text = "Total Faculty";
            this.msg2.Click += new System.EventHandler(this.msg2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCount);
            this.panel1.Controls.Add(this.msg1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 96);
            this.panel1.TabIndex = 0;
            // 
            // lblCount
            // 
            this.lblCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCount.AutoSize = true;
            this.lblCount.BackColor = System.Drawing.Color.Black;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblCount.ForeColor = System.Drawing.Color.Yellow;
            this.lblCount.Location = new System.Drawing.Point(91, 21);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(44, 31);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "12";
            this.lblCount.Click += new System.EventHandler(this.lblCount_Click);
            // 
            // msg1
            // 
            this.msg1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.msg1.AutoSize = true;
            this.msg1.BackColor = System.Drawing.Color.Black;
            this.msg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.msg1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.msg1.Location = new System.Drawing.Point(28, 56);
            this.msg1.Name = "msg1";
            this.msg1.Size = new System.Drawing.Size(179, 24);
            this.msg1.TabIndex = 0;
            this.msg1.Text = "Registered Students";
            // 
            // downPanel
            // 
            this.downPanel.BackColor = System.Drawing.Color.DarkBlue;
            this.downPanel.Controls.Add(this.chart1);
            this.downPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downPanel.Location = new System.Drawing.Point(0, 96);
            this.downPanel.Name = "downPanel";
            this.downPanel.Size = new System.Drawing.Size(884, 319);
            this.downPanel.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblCount4);
            this.panel4.Controls.Add(this.msg4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(685, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(199, 96);
            this.panel4.TabIndex = 3;
            // 
            // lblCount4
            // 
            this.lblCount4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCount4.AutoSize = true;
            this.lblCount4.BackColor = System.Drawing.Color.Black;
            this.lblCount4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblCount4.ForeColor = System.Drawing.Color.Yellow;
            this.lblCount4.Location = new System.Drawing.Point(79, 21);
            this.lblCount4.Name = "lblCount4";
            this.lblCount4.Size = new System.Drawing.Size(44, 31);
            this.lblCount4.TabIndex = 1;
            this.lblCount4.Text = "10";
            // 
            // msg4
            // 
            this.msg4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.msg4.AutoSize = true;
            this.msg4.BackColor = System.Drawing.Color.Black;
            this.msg4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.msg4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.msg4.Location = new System.Drawing.Point(41, 56);
            this.msg4.Name = "msg4";
            this.msg4.Size = new System.Drawing.Size(126, 24);
            this.msg4.TabIndex = 0;
            this.msg4.Text = "Total Courses";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(45, 83);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(403, 196);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "Admissions(in months)";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(884, 415);
            this.ControlBox = false;
            this.Controls.Add(this.downPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminDashboard";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.topPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.downPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel downPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label msg1;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCount2;
        private System.Windows.Forms.Label msg2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblCount3;
        private System.Windows.Forms.Label msg3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblCount4;
        private System.Windows.Forms.Label msg4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}