namespace Pack_Test_Program
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gSetting = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ResBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timeTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ConBtn = new System.Windows.Forms.Button();
            this.gcomList = new System.Windows.Forms.ComboBox();
            this.gConnect = new System.Windows.Forms.GroupBox();
            this.SavBtn = new System.Windows.Forms.Button();
            this.Startbtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gSetting.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gConnect.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(131, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pack 용량 Test Program";
            // 
            // CurrTxt
            // 
            this.CurrTxt.Location = new System.Drawing.Point(94, 21);
            this.CurrTxt.Name = "CurrTxt";
            this.CurrTxt.Size = new System.Drawing.Size(116, 21);
            this.CurrTxt.TabIndex = 7;
            this.CurrTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("함초롬돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(37, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "전류 :";
            // 
            // gSetting
            // 
            this.gSetting.Controls.Add(this.CurrTxt);
            this.gSetting.Controls.Add(this.label3);
            this.gSetting.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gSetting.Location = new System.Drawing.Point(100, 131);
            this.gSetting.Name = "gSetting";
            this.gSetting.Size = new System.Drawing.Size(240, 55);
            this.gSetting.TabIndex = 12;
            this.gSetting.TabStop = false;
            this.gSetting.Text = "2. Set";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.ResBtn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(100, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 88);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(326, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 21);
            this.label6.TabIndex = 31;
            this.label6.Text = "0.00Ah";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(241, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 25);
            this.label10.TabIndex = 30;
            this.label10.Text = "적산값 :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(154, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "0.00A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(154, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "0.00V";
            // 
            // ResBtn
            // 
            this.ResBtn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ResBtn.Location = new System.Drawing.Point(337, 17);
            this.ResBtn.Name = "ResBtn";
            this.ResBtn.Size = new System.Drawing.Size(50, 24);
            this.ResBtn.TabIndex = 5;
            this.ResBtn.Text = "Reset";
            this.ResBtn.UseVisualStyleBackColor = true;
            this.ResBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "전   류 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "전   압 :";
            // 
            // timeTxt
            // 
            this.timeTxt.Font = new System.Drawing.Font("돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timeTxt.Location = new System.Drawing.Point(405, 162);
            this.timeTxt.Name = "timeTxt";
            this.timeTxt.ReadOnly = true;
            this.timeTxt.Size = new System.Drawing.Size(100, 25);
            this.timeTxt.TabIndex = 29;
            this.timeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("함초롬돋움", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(356, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Time :";
            // 
            // ConBtn
            // 
            this.ConBtn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ConBtn.Location = new System.Drawing.Point(188, 16);
            this.ConBtn.Name = "ConBtn";
            this.ConBtn.Size = new System.Drawing.Size(41, 29);
            this.ConBtn.TabIndex = 17;
            this.ConBtn.Text = "연결";
            this.ConBtn.UseVisualStyleBackColor = true;
            this.ConBtn.Click += new System.EventHandler(this.ConnetBtn_Click);
            // 
            // gcomList
            // 
            this.gcomList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gcomList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gcomList.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gcomList.FormattingEnabled = true;
            this.gcomList.Location = new System.Drawing.Point(20, 20);
            this.gcomList.Name = "gcomList";
            this.gcomList.Size = new System.Drawing.Size(160, 19);
            this.gcomList.TabIndex = 18;
            // 
            // gConnect
            // 
            this.gConnect.Controls.Add(this.gcomList);
            this.gConnect.Controls.Add(this.ConBtn);
            this.gConnect.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gConnect.Location = new System.Drawing.Point(100, 70);
            this.gConnect.Name = "gConnect";
            this.gConnect.Size = new System.Drawing.Size(240, 55);
            this.gConnect.TabIndex = 19;
            this.gConnect.TabStop = false;
            this.gConnect.Text = "1. Connect";
            // 
            // SavBtn
            // 
            this.SavBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.SavBtn.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SavBtn.Location = new System.Drawing.Point(90, 32);
            this.SavBtn.Name = "SavBtn";
            this.SavBtn.Size = new System.Drawing.Size(60, 32);
            this.SavBtn.TabIndex = 24;
            this.SavBtn.Text = "저장";
            this.SavBtn.UseVisualStyleBackColor = true;
            this.SavBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Startbtn
            // 
            this.Startbtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Startbtn.Location = new System.Drawing.Point(13, 32);
            this.Startbtn.Name = "Startbtn";
            this.Startbtn.Size = new System.Drawing.Size(60, 32);
            this.Startbtn.TabIndex = 16;
            this.Startbtn.Text = "시작";
            this.Startbtn.UseVisualStyleBackColor = true;
            this.Startbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Startbtn);
            this.groupBox2.Controls.Add(this.SavBtn);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(346, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 86);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "3. Test 시작/종료";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(100, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(411, 300);
            this.dataGridView1.TabIndex = 31;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(23, 32);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.LegendText = "전압";
            series1.MarkerBorderWidth = 10;
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.LegendText = "전류";
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.LegendText = "적산값";
            series3.Name = "Series3";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(581, 448);
            this.chart1.TabIndex = 32;
            this.chart1.Text = "chart1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chart1);
            this.groupBox3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(544, 70);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(626, 527);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "4. Chart";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1190, 609);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.timeTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gConnect);
            this.Controls.Add(this.gSetting);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Pack Test Program";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gSetting.ResumeLayout(false);
            this.gSetting.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gConnect.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CurrTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gSetting;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ConBtn;
        private System.Windows.Forms.ComboBox gcomList;
        private System.Windows.Forms.GroupBox gConnect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ResBtn;
        private System.Windows.Forms.Button SavBtn;
        private System.Windows.Forms.Button Startbtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox timeTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

