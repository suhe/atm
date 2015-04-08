using System;
using System.Collections.Generic;
using System.Linq;

namespace ATM.Models
{
    class LoginForm
    {
        public static int UserId=0;
        public static string UserName = "";
        public static string Password = "";


        public bool isLogin()
        {
            User.UserName = UserName;
            User.Password = Password;
            User userModel = new User();
            if (userModel.LoginUser() == true)
                return true;
            else
                return false;
        }

    }


}
