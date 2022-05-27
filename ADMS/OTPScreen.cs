using System;
using System.Timers;
using System.Windows.Forms;

namespace ADMS
{
    public partial class OTP : Form
    {
        System.Timers.Timer t;
        int m, s, mNew, sNew;
        public OTP()
        {
            InitializeComponent();
        }

        private void countDown()
        {
            t = new System.Timers.Timer();
            t.Interval = 1000;
            s = 0;
            m = 0;
           t.AutoReset = true;
            t.Elapsed += OntimeEvent;
            reSendBtn.Enabled = false;
            t.Stop();
            t.Start();

        }

        private void reSendBtn_Click(object sender, EventArgs e)
        {
           // Console.WriteLine(String.Format("{0}:{1}", mNew.ToString().PadLeft(2, '0'), sNew.ToString().PadLeft(2, '0')));
            countDown();
        }

        private void OTP_Load(object sender, EventArgs e)
        {
            countDown();
        }

        private void OntimeEvent(object sender, ElapsedEventArgs e)
        {
            //  s = 48;
            //  m = 2;

            Invoke(new Action(() =>
            {
                s += 1;
                if (s == 59)
                {
                    s = 0;
                    m += 1;
                }

                sNew = 59 - s;
                mNew = 2 - m;

              //  Console.WriteLine(String.Format("{0}:{1}", mNew.ToString().PadLeft(2, '0'), sNew.ToString().PadLeft(2, '0')));

                countDownLabel.Text = String.Format("{0}:{1}", mNew.ToString().PadLeft(2, '0'), sNew.ToString().PadLeft(2, '0'));
                if (countDownLabel.Text == "00:01")
                {
                    countDownLabel.Text = String.Format("{0}:{1}", 0.ToString().PadLeft(2, '0'), 0.ToString().PadLeft(2, '0'));
                    t.Stop();
                    reSendBtn.Enabled = true;
                }

            }));
        }

        private void nxtBtn_Click(object sender, EventArgs e)
        {
            //t.Start();
            
        }


    }
}
