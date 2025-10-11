using System;

class Program
{
    static void Main()
    {
        int[] sayilar = { 5, 10, 15, 20, 25 };
        int toplam = 0;

        for (int i = 0; i < sayilar.Length; i++)
        {
            toplam += sayilar[i];
        }

        Console.WriteLine("Dizideki sayıların toplamı: " + toplam);
    }
}
