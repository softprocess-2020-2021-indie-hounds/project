using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Edventage.Main.Code
{
    public class User
    {
        public int Id { get; private set; }

        private int _userType;

        public User(int userId)
        {
            Id = userId;
        }

        public int getUserType()
        {
            return _userType;
        }

        //get user type from db * 1 - Admin, 2 - Lecturer, 3 - Student
        private void setUserType()
        {
            _userType = 1;
        }


    }
}