using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Learning_Platform
{
    public class AssessmentService
    {
        private List<Assessment> _assessments = new();

        public void CreateAssessment(Assessment assessment)
        {
            _assessments.Add(assessment);
            Console.WriteLine($"Assessment '{assessment.Title}' created.");
        }

        public IEnumerable<Assessment> GetAllAssessments() => _assessments;

        public Assessment GetAssessmentById(int id) => _assessments.FirstOrDefault(a => a.AssessmentId == id);
    }

}
