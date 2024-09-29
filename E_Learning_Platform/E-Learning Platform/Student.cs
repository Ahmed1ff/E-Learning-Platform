using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Learning_Platform
{

    public class Student : User
    {
        public List<Course> Courses { get; set; } = new();
        public List<Assessment> Assessments { get; set; } = new();

        public void EnrollCourse(Course course)
        {
            Courses.Add(course);
            Console.WriteLine($"{Name} enrolled in {course.Title}.");
        }

        public void ViewCourses()
        {
            Console.WriteLine($"{Name}'s Courses:");
            foreach (var course in Courses)
            {
                Console.WriteLine(course.Title);
            }
        }

        public void AddAssessment(Assessment assessment)
        {
            Assessments.Add(assessment);
            Console.WriteLine($"{Name} added assessment: {assessment.Title}.");
        }

        public void ViewAssessments()
        {
            Console.WriteLine($"{Name}'s Assessments:");
            foreach (var assessment in Assessments)
            {
                assessment.GetScores();
            }
        }
    }

}
