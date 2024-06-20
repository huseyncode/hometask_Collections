using System.Text;

namespace InventoryExample
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.OutputEncoding = Encoding.UTF8;

            Inventory inventory = new Inventory();

            while (true)
            {
                Console.WriteLine("\n1. Məhsul əlavə et");
                Console.WriteLine("2. Məhsulu sil");
                Console.WriteLine("3. Sayı yenilə");
                Console.WriteLine("4. Bütün məhsulları göstər");
                Console.WriteLine("0. Çıxış");

                Console.Write("\nSeçiminizi edin: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Məhsulun adını daxil edin: ");
                        string nameToAdd = Console.ReadLine();
                        Console.Write("Sayını daxil edin: ");
                        int quantityToAdd = Convert.ToInt32(Console.ReadLine());
                        inventory.AddProduct(nameToAdd, quantityToAdd);
                        break;
                    case 2:
                        Console.Write("Məhsulun adını daxil edin: ");
                        string nameToRemove = Console.ReadLine();
                        inventory.RemoveProduct(nameToRemove);
                        break;
                    case 3:
                        Console.Write("Məhsulun adını daxil edin: ");
                        string nameToUpdate = Console.ReadLine();
                        Console.Write("Yeni sayıyı daxil edin: ");
                        int newQuantity = Convert.ToInt32(Console.ReadLine());
                        inventory.UpdateQuantity(nameToUpdate, newQuantity);
                        break;
                    case 4:
                        foreach (var product in inventory.Products)
                        {
                            Console.WriteLine($"{product.Key}: {product.Value}");
                        }
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
}