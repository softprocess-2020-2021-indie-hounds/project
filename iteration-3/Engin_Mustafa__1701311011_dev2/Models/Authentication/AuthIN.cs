using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Edventage.Models.Authentication
{
    public class AuthIN
    {
        public string Username;
        public string Password;
        public string Token;

        private int _userId = 0;

        private string _errMessage;


        //make internal checks, return  result
        public bool validate()
        {
            _errMessage = null;

            if(!validateFields())
            {
                _errMessage = "Fields are not valid.";
            }
            else if(!validateToken())
            {
                _errMessage = "Token is not valid.";
            }
            else if(!validateUser())
            {
                _errMessage = "User credentials are not valid.";
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

        //check credentials on db
        private bool validateUser()
        {
            //get user id from db for furhter use (if user exists)
            _userId = 1;

            return true;
        }

        public int getUserId()
        {
            if (_userId > 0)
                return _userId;
            else
                //get user id when user is not logged in
                throw new Exception();
        }

        public string getError()
        {
            return _errMessage;
        }
    }
}