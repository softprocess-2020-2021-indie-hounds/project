using Edventage.Main.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Edventage.Models.Courses.Get
{
    public class CsOUT
    {
        public List<Course> courses;
        public string Error;

        //get courses based on user 
        public void setCourses(int userId)
        {
            courses = new List<Course>();
        }
        
    }
}