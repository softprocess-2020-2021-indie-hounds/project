using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Edventage.Models.Authentication
{
    public class AuthOUT
    {
        public bool isLoggedIn; // true if everything is ok
        public int userId;
        public int userType; // 1 - Admin, 2 - Lecturer, 3 - Student
        public string Error; // empty is no error is present
    }
}