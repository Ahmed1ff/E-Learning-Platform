using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Learning_Platform
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Instructor Instructor { get; set; }
        public List<Material> Materials { get; set; } = new();

        public void AddMaterial(Material material)
        {
            Materials.Add(material);
            Console.WriteLine($"Material '{material.Title}' added to {Title}.");
        }

        public void GetDetails()
        {
            Console.WriteLine($"Course: {Title}, Description: {Description}, Taught by: {Instructor.Name}");
        }
    }

}
