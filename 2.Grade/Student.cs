using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentGradesExample
{
    class Student
    {
        // Grades property-si
        public Dictionary<string, List<int>> Grades { get; } = new Dictionary<string, List<int>>();

        // Qiymət əlavə etmək
        public void AddGrade(string studentName, int grade)
        {
            if (!Grades.ContainsKey(studentName))
                Grades[studentName] = new List<int>();

            Grades[studentName].Add(grade);
        }

        // Qiyməti silmək
        public void RemoveGrade(string studentName, int grade)
        {
            if (Grades.ContainsKey(studentName))
                Grades[studentName].Remove(grade);
        }

        // Ortalama qiyməti hesablamaq
        public double GetAverageGrade(string studentName)
        {
            if (Grades.ContainsKey(studentName))
                return Grades[studentName].Average();
            else
                return 0; // Tələbə tapılmadı
        }

        // Bütün qiymətləri göstərmək
        public List<int> GetAllGradesByStudent(string studentName)
        {
            if (Grades.ContainsKey(studentName))
                return Grades[studentName];
            else
                return new List<int>(); // Tələbə tapılmadı
        }
    }
}