using System;
using System.Collections.Generic;
using System.Linq;

namespace ATM.Models
{
    class ProfileForm
    {
        public static string FirstName = "";
        public static string LastName = "";
        public static string UserName = "";
        public static string Password = "";
        public static string Title = "";
        public static string Address = "";
        public static string City = "";
        public static string PostalCode = "";

        public bool MyProfile()
        {
            User userModel = new User();
            if (userModel.Profile(LoginForm.UserId))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Update()
        {
            User model = new User();
            if(model.UpdateProfile(LoginForm.UserId,FirstName,LastName,Title,Address,City,PostalCode))
            {
                return true;
            }
            else
            {
                return false;
            }
       
        }

        public bool ChangePassword()
        {
            User model = new User();
            if (model.ChangePassword(LoginForm.UserId, Password))
            {
                return true;
            }
            else
            {
                return false;
            }


        }

    }

}
