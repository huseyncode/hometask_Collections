using System;
using System.Text;

namespace StringReverseExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Zəhmət olmasa bir string daxil edin: ");
            string inputString = Console.ReadLine();

            string reversedString = ReverseString(inputString);

            Console.WriteLine($"Tərsinə çevrilmiş string: {reversedString}");
        }

        static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
