using MagniCollegium.Data;
using MagniCollegium.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MagniCollegium.Persistence
{
    public class CoursePersistence
    {
        public List<Course> GetCourses()
        {
            using(var context = new MagniCollegiumDBContext())
            {
                return context.Courses.ToList();
            }
        }

        public void InsertCourse(Course course)
        {
            if(course != null)
            {
                using(var context = new MagniCollegiumDBContext())
                {
                    context.Courses.Add(course);
                    context.SaveChanges();
                }
            }
        }

    }
}