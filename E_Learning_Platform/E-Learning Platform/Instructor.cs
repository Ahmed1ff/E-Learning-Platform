using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Learning_Platform
{
    public class Instructor : User
    {
        public List<Course> CoursesTaught { get; set; } = new();

        public void CreateCourse(Course course)
        {
            CoursesTaught.Add(course);
            Console.WriteLine($"{Name} created {course.Title}.");
        }
    }

}
