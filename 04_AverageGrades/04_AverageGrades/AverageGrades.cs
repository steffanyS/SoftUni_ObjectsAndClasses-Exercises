using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_AverageGrades
{
    class AverageGrades
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students=new List<Student>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new [] {' '},StringSplitOptions.RemoveEmptyEntries).ToArray();
                var grades=new List<double>();

                for (int j = 1; j < input.Length; j++)
                {
                    grades.Add(double.Parse(input[j]));
                }

                students.Add(new Student
                {
                    Name = input[0],
                    Grades = grades
                });
                
            }

            var orderedStudents=new List<Student>();
            orderedStudents = students
                .Where(s => s.AverageGrades >= 5)
                .OrderBy(s => s.Name)
                .ThenByDescending(s => s.AverageGrades)
                .ToList();

            foreach (var student in orderedStudents)
            {
                if (student.AverageGrades >= 5)
                {
                    Console.WriteLine("{0} -> {1:f2}", student.Name,student.AverageGrades);
                }
            }
        }
    }  
}
