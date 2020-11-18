using Edventage.Models;
using Edventage.Models.Courses.Create;
using Edventage.Models.Courses.Delete;
using Edventage.Models.Courses.Enroll;
using Edventage.Models.Courses.Get;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Edventage.Controllers
{
    public class CourseController : ApiController
    {

        // GET all courses: api/Courses {json}
        public CsOUT Get(CsIN model)
        {
            CsOUT result = new CsOUT();

            if(!model.validate())
            {
                result.Error = model.getError();
            }
            else
            {
                //load courses based on user
                result.setCourses(model.UserId);
            }

            return result;
        }

        // POST: enroll to a course
        public CommonOUT Post(EnrIN model)
        {
            CommonOUT result = new CommonOUT();

            if (!model.validate())
            {
                result.Error = model.getError();
            }
            else
            {
                result.Success = true;
            }

            return result;
        }

        // Create new course : api/Courses {json}
        public CommonOUT Put(CrIN model)
        {
            CommonOUT result = new CommonOUT();

            if (!model.validate())
            {
                result.Error = model.getError();
            }
            else
            {
                result.Success = true;
            }

            return result;
        }

        // Dlete a course: api/Courses {json}
        public CommonOUT Delete(DeIN model)
        {
            CommonOUT result = new CommonOUT();

            if (!model.validate())
            {
                result.Error = model.getError();
            }
            else
            {
                result.Success = true;
            }

            return result;
        }
    }
}
