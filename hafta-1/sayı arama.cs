using System;

class Program
{
    static void Main()
    {
        int[] sayilar = { 3, 7, 12, 19, 25 };
        Console.Write("Aranacak sayıyı gir: ");
        int aranan = int.Parse(Console.ReadLine());

        bool bulundu = false;
        for (int i = 0; i < sayilar.Length; i++)
        {
            if (sayilar[i] == aranan)
            {
                bulundu = true;
                break;
            }
        }

        if (bulundu)
            Console.WriteLine("Sayı dizide bulundu!");
        else
            Console.WriteLine("Sayı dizide yok!");
    }
}
