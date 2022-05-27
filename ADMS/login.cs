using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMS
{
    public partial class login : Form
    {
        bool haveAcc = true;
        public login()
        {
            InitializeComponent();
        }

        private void swapLoginState()
        {
            if (haveAcc)
            {
                for (int i = 81; i > 0; i--)
                {
                  //  repswPanel.Height = i;
                   // Thread.Sleep(1);
                }
                titleLabel.Text = "Login Here";
                repswPanel.Visible = false;
                btnsign.Text = "Sign in";
                accountLabel.Text = "Don't you have an account";
                registerLabel.Text = "Register Here";


            }
            else
            {
                titleLabel.Text = "Create an Account";
                repswPanel.Visible = true;
                for (int i = 0; i <= 81; i++)
                {
                  //  repswPanel.Height = i;
                 //   Thread.Sleep(1);

                }
                btnsign.Text = "Sign up";
                accountLabel.Text = "Already have an account";
                registerLabel.Text = "Login Here";
            }
        }

        private void accountLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnsign_Click(object sender, EventArgs e)
        {
            if (haveAcc)
            {
                HomeScreen hs = new HomeScreen();
                hs.Show();
                this.Close();
            }
            else
            {
                if(pswTextBox.Text == repswTextBox.Text)
                {
                    user_settings.Default.email = emailTextBox.Text;
                    user_settings.Default.password = pswTextBox.Text;
                    user_settings.Default.Save();

                    //Console.WriteLine(user_settings.Default.email);
                    // Console.WriteLine(user_settings.Default.password);
                    emailClass ec = new emailClass();
                    ec.sendEmail("shenalakalanka404@gmail.com", "Hello!", "All ok");
                     OTP OTP = new OTP();
                    OTP.Show();
                    this.Close();
                }

                
            }
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            if (haveAcc)
            {
                haveAcc = false;
            }
            else
            {
                haveAcc = true;
            }
            swapLoginState();
        }

        private void login_Load(object sender, EventArgs e)
        {
            swapLoginState();
        }
    }

       
    
}
