using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NationalInstruments.VisaNS;
using System.Threading;


namespace Pack_Test_Program
{
    public class DischargeData
    {
        string _volt = "load on";
        string _curr;

        public string cCurr
        {
            get
            {
                return _curr;
            }
            set
            {
                _curr = value;
            }
        }

        public string cVolt
        {
            get
            {
                return _volt;
            }
            set
            {
                _volt = value;
            }
        }
    }

    public class subTest
    {
        private List<string> getlist = new List<string>();
        private MessageBasedSession _visa = null;

        public List<string> get_Glist(int Aistr) ///GPIB로 연결된 장비를 찾는 부분.
        {
            MessageBasedSession tmpvisa = null;
            string resourceName = null;
            getlist.Clear();

            for (int i = 1; i <= 30; i++)
            {
                try
                {
                    resourceName = "GPIB" + Aistr.ToString() + "::" + i.ToString() + "::INSTR"; // GPIB adapter 0, Instrument address 20          

                    tmpvisa = new MessageBasedSession(resourceName);
                    tmpvisa.Write("*IDN?"); // write to instrument
                    string value = tmpvisa.ReadString();
                    getlist.Add(i.ToString() + ":" + value);
                    _visa = tmpvisa;
                }
                catch (Exception exp)
                {
                    exp.ToString();
                }
            }
            return getlist;
        }

        public double Set_Current(double Cur)
        {
            string strCurr = "CURR:STAT:L2 " + Cur; //L2 전류 Cur로 설정 
            string qCurr = "CURR:STAT:L2?";
            try
            {
                _visa.Write(strCurr);
                _visa.Write(qCurr);
                string strread = _visa.ReadString();
                return Convert.ToDouble(strread);
            }
            catch
            {
                return -1;
            }
        }

        public string Start_Load(string statLoad)
        {
            try
            {
                _visa.Write(statLoad);

                return "true";
            }
            catch (Exception exp)
            {
                exp.ToString();
                return "false";

            }
        }

        public double t_volt()
        {
            try
            {
                _visa.Write("MEAS:VOLT?");
                string av = _visa.ReadString();
                return Convert.ToDouble(av);
            }
            catch
            {
                return -1;
            }
        }
        public double t_curr()
        {
            //string mVolt = ;
            try
            {
                _visa.Write("MEAS:CURR?");
                string ac = _visa.ReadString();
                return Convert.ToDouble(ac);
            }
            catch
            {
                return -2;
            }
        }

        public List<string> measurementList(int igpib)
        {
            return get_Glist(igpib);
        }

        public double sCurrent(double Cur)
        {
            return Set_Current(Cur);
        }

        public string sLoad(string statLoad)
        {
            return Start_Load(statLoad);
        }
    }
}
