using System.Text;

namespace CalculatorExample;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Calculator<double> calculator = new Calculator<double>();

        while (true)
        {
            Console.WriteLine("\n1. Toplama");
            Console.WriteLine("2. Çıxma");
            Console.WriteLine("3. Vurma");
            Console.WriteLine("4. Bölmə");
            Console.WriteLine("0. Çıxış");

            Console.Write("\nSeçiminizi edin: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 0)
            {
                Console.WriteLine("Proqramdan çıxılır...");
                break;
            }

            Console.Write("Birinci ədədi daxil edin: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci ədədi daxil edin: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Nəticə: {calculator.Add(num1, num2)}");
                    break;
                case 2:
                    Console.WriteLine($"Nəticə: {calculator.Subtract(num1, num2)}");
                    break;
                case 3:
                    Console.WriteLine($"Nəticə: {calculator.Multiply(num1, num2)}");
                    break;
                case 4:
                    Console.WriteLine($"Nəticə: {calculator.Divide(num1, num2)}");
                    break;
                default:
                    Console.WriteLine("Yanlış seçim! Zəhmət olmasa düzgün seçim edin.");
                    break;
            }
        }
    }
}