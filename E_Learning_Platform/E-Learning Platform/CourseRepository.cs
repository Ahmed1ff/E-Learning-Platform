using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Learning_Platform
{
    public class CourseRepository : IRepository<Course>
    {
        private List<Course> courses = new();

        public void Add(Course course) => courses.Add(course);

        public IEnumerable<Course> GetAll() => courses;

        public Course GetById(int id) => courses.FirstOrDefault(c => c.CourseId == id);
    }

}
