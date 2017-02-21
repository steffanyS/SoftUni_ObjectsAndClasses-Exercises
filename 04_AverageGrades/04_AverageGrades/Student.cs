using System.Collections.Generic;
using System.Linq;

namespace _04_AverageGrades
{
    class Student
    {
        // name, list of grades and average grade 

        public string Name { get; set; }
        public List<double> Grades { get; set; }

        public double AverageGrades => Grades.Average();
    }
}
