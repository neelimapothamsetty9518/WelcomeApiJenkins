using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeApp1
{
    public class SignIn
    {
        public  string Authenticate(string Username,string Userpwd)
        {
            string Msg;
            if (String.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Userpwd))
            {
                Msg = "username and pasword required";
            }
            else
            {
                if ((Username == "admin") && (Userpwd == "admin@1256"))
                {
                    Msg = "Auth pass";
                }
                else
                {
                    Msg = "fail";

                }
            }
                return Msg;
            
        }
    }
}
