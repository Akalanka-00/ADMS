using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMS
{
    public partial class companyScreen : Form
    {
        public companyScreen()
        {
            InitializeComponent();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            OTP otp = new OTP();
            otp.Show();
            this.Close();
        }
    }
}
