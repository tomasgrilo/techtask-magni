using MagniCollegium.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagniCollegium.Data
{
    //DEV Initializer, drops database everytime a entity is changed (see "Handle code-first migrations")
    public class DBInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MagniCollegiumDBContext>
    {
        protected override void Seed(MagniCollegiumDBContext context)
        {
            var students = new List<Student>
            {
                new Student{Name="Carson",Birthday=DateTime.Parse("2005-09-01"), RegistationNumber= new Random().Next(100000,199999)},
                new Student{Name="Meredith",Birthday=DateTime.Parse("2002-09-01"), RegistationNumber= new Random().Next(100000,199999)},
                new Student{Name="Arturo",Birthday=DateTime.Parse("2003-09-01"), RegistationNumber= new Random().Next(100000,199999)},
                new Student{Name="Gytis",Birthday=DateTime.Parse("2002-09-01"), RegistationNumber= new Random().Next(100000,199999)},
                new Student{Name="Yan",Birthday=DateTime.Parse("2002-09-01"), RegistationNumber= new Random().Next(100000,199999)},
                new Student{Name="Peggy", Birthday=DateTime.Parse("2001-09-01"), RegistationNumber= new Random().Next(100000,199999)},
                new Student{Name="Laura",Birthday=DateTime.Parse("2003-09-01"), RegistationNumber= new Random().Next(100000,199999)},
                new Student{Name="Nino",Birthday=DateTime.Parse("2005-09-01"), RegistationNumber= new Random().Next(100000,199999)}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            var courses = new List<Course>
            {
                new Course{Name="Filosofia", MaxStudents=100},
                new Course{Name="Eng mecanica", MaxStudents=500},
                new Course{Name="Eng informatica", MaxStudents=200},
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();


            var teachers = new List<Teacher>
            {
                new Teacher{Name="Joao", Birthday= new DateTime(1943, 03,10), Salary=40000},
                new Teacher{Name="Maria", Birthday=new DateTime(1963, 03,10), Salary=35000},
                new Teacher{Name="Tiago", Birthday=new DateTime(1933, 03,10), Salary=60000}
            };
            teachers.ForEach(s => context.Teachers.Add(s));
            context.SaveChanges();

            var subjects = new List<Subject>
            {
                new Subject{Name="Matematica",Teacher=teachers[0], Courses=courses , },
                new Subject{Name="Filosofia",Teacher=teachers[1] ,Courses=courses, },
                new Subject{Name="Ed fisica",Teacher=teachers[2],Courses=courses,}
            };
            subjects.ForEach(s => context.Subjects.Add(s));
            context.SaveChanges();

            var grades = new List<Grade>
            {
                new Grade{Score=13, Student=students[1], Subject=subjects[0]},
                new Grade{Score=20, Student=students[1], Subject=subjects[1]},
                new Grade{Score=12, Student=students[1], Subject=subjects[2]},
                new Grade{Score=12, Student=students[2], Subject=subjects[0]},
                new Grade{Score=12, Student=students[2], Subject=subjects[2]},

            };
            grades.ForEach(s => context.Grades.Add(s));
            context.SaveChanges();
        }
    }
}