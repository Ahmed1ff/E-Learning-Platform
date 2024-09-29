using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Learning_Platform
{
    public class Exam
    {
        public int ExamId { get; set; }
        public Course Course { get; set; }
        public List<Question> Questions { get; set; } = new();
        public DateTime Date { get; set; }

        public void AddQuestion(Question question)
        {
            Questions.Add(question);
            Console.WriteLine($"Question added to exam: {question.Content}");
        }
    }

}
