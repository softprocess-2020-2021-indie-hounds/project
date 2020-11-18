using Edventage.Main.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Edventage.Models.Courses.Create
{
    public class CrIN : Course
    {
        public int UserID;

        private string _errMessage;

        //make internal checks, return  result
        public bool validate()
        {
            _errMessage = null;

            if (!validateFields())
            {
                _errMessage = "Fields are not valid.";
            }
            else if (!validateToken())
            {
                _errMessage = "Token is not valid.";
            }
            else if (!validatePermissions())
            {
                _errMessage = "User does not have permission to create new course.";
            }

            if (_errMessage is null)
                return false;
            else
                return true;
        }

        //validate fields(length, empty fields, numeric values)
        private bool validateFields()
        {
            return true;
        }

        //check if token is valid
        private bool validateToken()
        {
            return true;
        }

        //check permission of user
        private bool validatePermissions()
        {
            return true;
        }


        public string getError()
        {
            return _errMessage;
        }
    }
}