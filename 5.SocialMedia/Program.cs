using System.Text;

namespace SocialMediaExample;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        SocialMedia socialMedia = new SocialMedia();

        while (true)
        {
            Console.WriteLine("\n1. Dost əlavə et");
            Console.WriteLine("2. Dostu sil");
            Console.WriteLine("3. Bütün dostları göstər");
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
                    socialMedia.AddFriend(usernameToAdd, friendToAdd);
                    break;
                case 2:
                    Console.Write("İstifadəçinin adını daxil edin: ");
                    string usernameToRemove = Console.ReadLine();
                    Console.Write("Silmək istədiyiniz dostun adını daxil edin: ");
                    string friendToRemove = Console.ReadLine();
                    socialMedia.RemoveFriend(usernameToRemove, friendToRemove);
                    break;
                case 3:
                    Console.Write("İstifadəçinin adını daxil edin: ");
                    string usernameForFriends = Console.ReadLine();
                    Console.WriteLine($"Bütün dostlar: {string.Join(", ", socialMedia.GetAllFriendsByUsername(usernameForFriends))}");
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