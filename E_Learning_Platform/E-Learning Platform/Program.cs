using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Learning_Platform
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    class Program
    {
        static async Task Main(string[] args)
        {
            var userService = new UserService();
            var courseRepository = new CourseRepository();
            var courseService = new CourseService(courseRepository);

            userService.UserRegistered += (name) =>
            {
                Console.WriteLine($"Welcome, {name}!");
            };

            var instructor = new Instructor { UserId = 1, Name = "Alice", Email = "alice@example.com" };
            userService.RegisterUser(instructor);

            var course = new Course { CourseId = 1, Title = "C# Programming", Description = "Learn C# from scratch.", Instructor = instructor };
            courseService.AddCourse(course);

            var student = new Student { UserId = 2, Name = "Bob", Email = "bob@example.com" };
            userService.RegisterUser(student);

            await Task.Run(() => student.EnrollCourse(course));

            student.ViewCourses();

            var allCourses = courseService.GetAllCourses();
            Console.WriteLine("Available Courses:");
            foreach (var c in allCourses)
            {
                c.GetDetails();
            }
            var assessmentService = new AssessmentService();
            var assessment1 = new Assessment { AssessmentId = 1, Title = "Math Quiz", Description = "Quiz on Algebra." };
            assessmentService.CreateAssessment(assessment1);

            student.AddAssessment(assessment1);

            assessment1.AddScore(student, 95);

            student.ViewAssessments();
        }


    }

}
