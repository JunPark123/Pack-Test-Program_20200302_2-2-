using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace Pack_Test_Program
{
    public partial class Form1 : Form
    {

        subTest _stest = new subTest();
        ChartData _cData = new ChartData();

        DischargeData dd = new DischargeData();

        List<DischargeData> aa = new List<DischargeData>(); //데이터 저장할 곳

        private bool bLoad = true;
        private bool bTime = true;

        private delegate void _myDel();
        private _myDel MyDel;

        double x = 0;
        double Acc;
        double number;
        Stopwatch sw = new Stopwatch();
        Stopwatch stopwatch = new Stopwatch();

        private Thread _threadTimer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Titles.Add("방전 테스트");
            chart1.ChartAreas[0].BackColor = Color.Black;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 100;
            /*
               Random r = new Random();

               for (int i=0; i<10; i++)
               {
                hart1.Series[0].Points.Add(r.Next(100));                
               }
             */
            //chart1.Series[0].Points.AddY(1);
            //chart1.Series[0].Points.AddXY(1, 2);
            aa.Add(dd);
            string a = aa[0].cCurr;

            dataGridView1.ColumnCount = 4;

            dataGridView1.Columns[0].Name = "시간";
            dataGridView1.Columns[1].Name = "전압";
            dataGridView1.Columns[2].Name = "전류";
            dataGridView1.Columns[3].Name = "적산값";
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 90;
            dataGridView1.Columns[2].Width = 90;
            dataGridView1.Columns[3].Width = 118;

            ResBtn.Enabled = false;
            CurrTxt.Enabled = false;
            Startbtn.Enabled = false;
            SavBtn.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_threadTimer != null)
            {
                _threadTimer.Abort();
                _threadTimer.Join(); //?
                _threadTimer = null;
                MessageBox.Show("테스트 종료");
            }
        }

        private void ConnetBtn_Click(object sender, EventArgs e)
        {
            List<string> _measlist = null;
            
            _measlist = _stest.measurementList(0);

            gcomList.Items.Clear();

            foreach (string strmeas in _measlist)
            {
                gcomList.Items.Add(strmeas);
            }

            if (gcomList.Items.Count > 0)
            {
                gcomList.SelectedIndex = 0;
                ConBtn.Enabled = false;
                CurrTxt.Enabled = true;
                Startbtn.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e) //로더 ON 버튼
        {
            if (bLoad == true)
            {
                try
                {
                    double b = _stest.sCurrent(Convert.ToDouble(CurrTxt.Text));
                    if (b == -1)
                    {
                        MessageBox.Show("툴에 맞는 장비인지 확인하세요");
                    }
                    else
                    {
                        _stest.sLoad("MODE CCH");
                        string a = _stest.sLoad("LOAD ON");
                        Thread.Sleep(900);
                        sw.Start();
                        Startbtn.Text = "종료";
                        bLoad = false;

                        if (a == "true" && bTime == true)
                        {
                            //MessageBox.Show(DateTime.Now.ToString() + "\r\n테스트를 시작합니다.");
                            _threadTimer = new Thread(new ThreadStart(thread_Timer));
                            _threadTimer.Start();
                            stopwatch.Start();
                            MyDel = new _myDel(UI);
                        }
                        else if (a == "false") MessageBox.Show("오류");
                    }
                }
                catch
                {
                    MessageBox.Show("전류값을 입력하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (bLoad == false)
            {
                bLoad = true;
                Startbtn.Text = "시작";
                SavBtn.Enabled = true;
                ResBtn.Enabled = true;
                sw.Stop();

                _stest.sLoad("LOAD OFF");

                if (_threadTimer != null)
                {
                    _threadTimer.Interrupt();
                    _threadTimer.Abort();
                    _threadTimer.Join();//?
                    _threadTimer = null;
                }
            }
        }

        public void thread_Timer()
        {
            //stopwatch.Start();
            while (bTime)
            {
                try
                {
                    if (bLoad == true) continue;
                    number++;
                    //_stest.t_volt("MEAS:VOLT?");
                    //_stest.t_volt("MEAS:CURR?");



                    this.Invoke(MyDel);

                    //stopwatch.Stop();

                    Thread.Sleep(930);

                }
                catch (Exception exp)
                {
                    exp.ToString();
                    Debug.WriteLine("Exception : " + exp.ToString());
                }
            }
        }
        private void Chartgraph(double value)
        {
            chart1.Series[0].Points.AddXY(x, value);
            
            if (chart1.Series[0].Points.Count > 20) chart1.Series[0].Points.RemoveAt(0);
            chart1.ChartAreas[0].AxisX.Minimum = chart1.Series[0].Points[0].XValue;
            chart1.ChartAreas[0].AxisX.Maximum = x;
            x++;
        }

        private void UI() ///화면 표시 작업하는 함수
        {
            try
            {
                TimeSpan ts = sw.Elapsed;

                //double a = Convert.ToDouble(_stest.t_volt("MEAS:VOLT?"));
                double c = Math.Truncate((_stest.t_volt()) * 1000) / 1000; //전압
                double b = _stest.t_curr();
                double d = Math.Truncate(b * 1000) / 1000; // 전류

                double hour = Math.Truncate(number / 3600);
                double min = Math.Truncate((number % 3600) / 60);
                double sec = Math.Truncate(number % 3600 % 60);
                
                double wjrtks = b / 3600.0;
                Acc += wjrtks; //Acc = Acc + wjrtks; 같은거

                double wjrt = Math.Truncate(Acc * 10000) / 10000; //적산값
                
                timeTxt.Text = String.Format("{0:00}:{1:00}:{2:00}", hour, min, sec);
                //timeTxt.Text = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);

                label8.Text = c + "V";  
                label9.Text = d + "A";
                label6.Text = wjrt + "Ah";
                //label2.Text = ("time : " + stopwatch.ElapsedMilliseconds + "ms");
                Chartgraph(c);
                dataGridView1.Rows.Add(timeTxt.Text, c, d, wjrt);
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;
                stopwatch.Stop(); 
                
            }
            catch
            {
                MessageBox.Show("Error code1", "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e) ///리셋버튼 
        {
            if (MessageBox.Show("확인 버튼을 누르면 초기화 됩니다", "주의", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dataGridView1.Rows.Clear();
                Acc = 0;
                sw.Reset();

                timeTxt.Text = "00:00:00";

                label8.Text = "0.00V";
                label9.Text = "0.00A";
                label6.Text = "0.00Ah";

                CurrTxt.Text = null;
                CurrTxt.Enabled = true;

                Startbtn.Enabled = true;
                SavBtn.Enabled = false;

                //if (gcomList.Items.Count > 0)
                //{
                //    gcomList.Items.Clear();
                //    ConBtn.Enabled = false;
                //    ResBtn.Enabled = false;
                //}
            }
            else
            {

            }
        }

        private void button2_Click(object sender, EventArgs e) ///파일 저장
        {

            StreamWriter sw = new StreamWriter("PackData.csv", false, Encoding.UTF8);
            sw.WriteLine("{0},{1},{2},{3}", dataGridView1.Columns[0].HeaderText, dataGridView1.Columns[1].HeaderText, dataGridView1.Columns[2].HeaderText, dataGridView1.Columns[3].HeaderText);

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sw.WriteLine("{0},{1},{2},{3}", dataGridView1[0, i].Value.ToString(), dataGridView1[1, i].Value.ToString(), dataGridView1[2, i].Value.ToString(), dataGridView1[3, i].Value.ToString());
                //sw.WriteLine("{0},{1},{2},{3}", dataGridView1[0, 1].Value.ToString(), dataGridView1[1, 1].Value.ToString(), dataGridView1[2, 1].Value.ToString(), dataGridView1[3, 1].Value.ToString());
            }
            sw.Close();
        }
    }
}


