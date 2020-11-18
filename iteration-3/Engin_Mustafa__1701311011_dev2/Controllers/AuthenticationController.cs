using Edventage.Main.Code;
using Edventage.Models.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Edventage.Controllers
{
    public class AuthenticationController : ApiController
    {

        //Authenticate user by id * api/Authentication {json}
        public AuthOUT Get(AuthIN model)
        {
            AuthOUT result = new AuthOUT();

            if(!model.validate())
            {
                result.Error = model.getError()
            }
            else
            {
                User user = new User(model.getUserId());

                result.isLoggedIn = true;
                result.userType = user.getUserType();
                result.userId = user.Id;
            }

            return result;
        }

    }
}
