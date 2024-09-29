using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Learning_Platform
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string Content { get; set; }
        public List<string> Options { get; set; } = new();
        public string CorrectAnswer { get; set; }
    }

}
