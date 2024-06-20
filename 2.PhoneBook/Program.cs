using System.Text;

namespace PhoneBookExample;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        PhoneBook phoneBook = new PhoneBook();

        while (true)
        {
            Console.WriteLine("\n1. Əlaqə əlavə et");
            Console.WriteLine("2. Əlaqəni sil");
            Console.WriteLine("3. Bütün əlaqələri göstər");
            Console.WriteLine("0. Çıxış");

            Console.Write("\nSeçiminizi edin: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("İstifadəçinin adını daxil edin: ");
                    string usernameToAdd = Console.ReadLine();
                    Console.Write("Dostun adını daxil edin: ");
                    string friendToAdd = Console.ReadLine();
                    phoneBook.AddContact(usernameToAdd, friendToAdd);
                    break;
                case 2:
                    Console.Write("İstifadəçinin adını daxil edin: ");
                    string usernameToRemove = Console.ReadLine();
                    phoneBook.RemoveContact(usernameToRemove);
                    break;
                case 3:
                    Console.Write("İstifadəçinin adını daxil edin: ");
                    string usernameForFriends = Console.ReadLine();
                    Console.WriteLine($"Bütün dostlar: {string.Join(", ", phoneBook.GetAllContacts())}");
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