using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Learning_Platform
{
    public class Assessment
    {
        public int AssessmentId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Dictionary<Student, double> Scores { get; set; } = new();

        public void AddScore(Student student, double score)
        {
            if (!Scores.ContainsKey(student))
            {
                Scores[student] = score;
                Console.WriteLine($"Score of {score} added for {student.Name} in {Title}.");
            }
            else
            {
                Console.WriteLine($"{student.Name} already has a score recorded for {Title}.");
            }
        }

        public void GetScores()
        {
            Console.WriteLine($"Scores for {Title}:");
            foreach (var entry in Scores)
            {
                Console.WriteLine($"{entry.Key.Name}: {entry.Value}");
            }
        }
    }

}
