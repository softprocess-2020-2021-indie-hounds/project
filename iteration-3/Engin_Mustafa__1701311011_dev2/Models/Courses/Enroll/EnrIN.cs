using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Edventage.Models.Courses.Enroll
{
    public class EnrIN
    {
        public int UserId;
        public int CourseId;
        public string Token;

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
            else if (!validateToken())
            {
                _errMessage = "User is not compatible for this course.";
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

        //check if user is compatible for course
        private bool validateCompliance()
        {
            return true;
        }


        public string getError()
        {
            return _errMessage;
        }
    }
}