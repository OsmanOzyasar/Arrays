using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                Random rnd = new Random();
                int number = rnd.Next(1, 50); //Dizinin her indexine random bir sayı giriliyor
                numbers[i] = number;
            }

            Console.WriteLine("Oluşturulan dizinin elemanları: ");

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.Write($"Lütfen dizinin {numbers.Length + 1}. elemanını giriniz: ");

            int userInput = Convert.ToInt32(Console.ReadLine());
            Array.Resize(ref numbers, numbers.Length + 1);     //Kullanıcıdan alınan değer diziye yeni eleman olarak ekleniyor
            numbers[numbers.Length - 1] = userInput;

            Console.WriteLine("Dizinin yeni hali: ");

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            Array.Sort(numbers);//dizi küçükten büyüğe sıralanıyor
            Array.Reverse(numbers); //Dizi ters çevriliyor ve büyükten küçüğe sıralanıyor

            Console.WriteLine("Dizinin yeniden düzenlenmiş hali: ");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}