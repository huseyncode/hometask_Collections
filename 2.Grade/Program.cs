using StudentGradesExample;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Student student = new Student();

        while (true)
        {
            Console.WriteLine("\n1. Qiymət əlavə et");
            Console.WriteLine("2. Qiyməti sil");
            Console.WriteLine("3. Ortalama qiyməti göstər");
            Console.WriteLine("4. Bütün qiymətləri göstər");
            Console.WriteLine("0. Çıxış");

            Console.Write("\nSeçiminizi edin: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Tələbənin adını daxil edin: ");
                    string nameToAdd = Console.ReadLine();
                    Console.Write("Qiyməti daxil edin: ");
                    int gradeToAdd = Convert.ToInt32(Console.ReadLine());
                    student.AddGrade(nameToAdd, gradeToAdd);
                    break;
                case 2:
                    Console.Write("Tələbənin adını daxil edin: ");
                    string nameToRemove = Console.ReadLine();
                    Console.Write("Silinəcək qiyməti daxil edin: ");
                    int gradeToRemove = Convert.ToInt32(Console.ReadLine());
                    student.RemoveGrade(nameToRemove, gradeToRemove);
                    break;
                case 3:
                    Console.Write("Tələbənin adını daxil edin: ");
                    string nameForAverage = Console.ReadLine();
                    Console.WriteLine($"Orta qiymət: {student.GetAverageGrade(nameForAverage)}");
                    break;
                case 4:
                    Console.Write("Tələbənin adını daxil edin: ");
                    string nameForAllGrades = Console.ReadLine();
                    Console.WriteLine($"Bütün qiymətlər: {string.Join(", ", student.GetAllGradesByStudent(nameForAllGrades))}");
                    break;
                case 0:
                    Console.WriteLine("Proqramdan çıxılır...");
                    return;
                default:
                    Console.WriteLine("Yanlış seçim! Zəhmət olmasa düzgün seçim edin.");
                    break;
            }
        }
    }
}