using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMS
{
    public class firebaseConn
    {
        IFirebaseConfig conn;
        IFirebaseClient client;

        public void startConn()
        {
            conn = new FirebaseConfig()
            {
                AuthSecret = "VWurrTemhi0qne6Fac4QkzBDGTUFH2uqsS8Fmc0Y",
                BasePath = "https://vc-room-8cb9f-default-rtdb.firebaseio.com/",

            };
            try
            {
                client = new FireSharp.FirebaseClient(conn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public void insertData(int pk, Company u)
        {
            var setter = client.Set("users/" + pk, u);
            MessageBox.Show("Data add successfully");
        }

        public bool login(String uname, String psw)
        {
            bool loginState = false;

            var result = client.Get("users/" + 1);
            Company u = result.ResultAs<Company>();
            if (u.uname == uname && u.psw == psw)
            {
                MessageBox.Show("Connected");
                loginState = true;
            }
            else { MessageBox.Show("not Connected"); }

            return loginState;
        }


    }

}
