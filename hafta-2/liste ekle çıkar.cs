using System;

class Node
{
    public int data;
    public Node next;

    public Node(int data)
    {
        this.data = data;
        this.next = null;
    }
}

class BagliList
{
    private Node head;

    public void Display()
    {
        if (head == null)
        {
            Console.WriteLine("Liste boş!");
            return;
        }

        Node temp = head;
        Console.Write("Listedeki elemanlar: ");
        while (temp != null)
        {
            Console.Write(temp.data + " ");
            temp = temp.next;
        }
        Console.WriteLine();
    }

    public void BasaEkle(int value)
    {
        Node newNode = new Node(value);
        newNode.next = head;
        head = newNode;
        Console.WriteLine($"{value} başa eklendi.");
    }

    public void SonaEkle(int value)
    {
        Node newNode = new Node(value);
        if (head == null)
        {
            head = newNode;
            Console.WriteLine($"{value} sona eklendi.");
            return;
        }

        Node temp = head;
        while (temp.next != null)
            temp = temp.next;

        temp.next = newNode;
        Console.WriteLine($"{value} sona eklendi.");
    }

    public void SonrasinaEkle(int varolanDeger, int yeniDeger)
    {
        Node temp = head;
        while (temp != null && temp.data != varolanDeger)
            temp = temp.next;

        if (temp == null)
        {
            Console.WriteLine($"{varolanDeger} bulunamadı!");
            return;
        }

        Node newNode = new Node(yeniDeger);
        newNode.next = temp.next;
        temp.next = newNode;
        Console.WriteLine($"{varolanDeger} değerinden sonra {yeniDeger} eklendi.");
    }

    public void BastanSil()
    {
        if (head == null)
        {
            Console.WriteLine("Liste boş, silinecek eleman yok!");
            return;
        }

        Console.WriteLine($"{head.data} baştan silindi.");
        head = head.next;
    }

    public void SondanSil()
    {
        if (head == null)
        {
            Console.WriteLine("Liste boş, silinecek eleman yok!");
            return;
        }

        if (head.next == null)
        {
            Console.WriteLine($"{head.data} sondan silindi.");
            head = null;
            return;
        }

        Node temp = head;
        while (temp.next.next != null)
            temp = temp.next;

        Console.WriteLine($"{temp.next.data} sondan silindi.");
        temp.next = null;
    }

    public void ElemanSil(int value)
    {
        if (head == null)
        {
            Console.WriteLine("Liste boş!");
            return;
        }

        if (head.data == value)
        {
            head = head.next;
            Console.WriteLine($"{value} listeden silindi.");
            return;
        }

        Node temp = head;
        while (temp.next != null && temp.next.data != value)
            temp = temp.next;

        if (temp.next == null)
        {
            Console.WriteLine($"{value} bulunamadı!");
            return;
        }

        temp.next = temp.next.next;
        Console.WriteLine($"{value} listeden silindi.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        BagliList listim = new BagliList();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n---- LinkedList İşlemleri ----");
            Console.WriteLine("1. Listeyi Göster");
            Console.WriteLine("2. Başa Eleman Ekle");
            Console.WriteLine("3. Sona Eleman Ekle");
            Console.WriteLine("4. Belirli Bir Değerin Sonrasına Eleman Ekle");
            Console.WriteLine("5. İlk Elemanı Sil");
            Console.WriteLine("6. Son Elemanı Sil");
            Console.WriteLine("7. Belirli Elemanı Sil");
            Console.WriteLine("8. Çıkış");
            Console.Write("Bir işlem seçin (1-8): ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    listim.Display();
                    break;

                case "2":
                    Console.Write("Başa eklenecek değeri girin: ");
                    int basaDeger = Convert.ToInt32(Console.ReadLine());
                    listim.BasaEkle(basaDeger);
                    break;

                case "3":
                    Console.Write("Sona eklenecek değeri girin: ");
                    int sonaDeger = Convert.ToInt32(Console.ReadLine());
                    listim.SonaEkle(sonaDeger);
                    break;

                case "4":
                    Console.Write("Sonrasına ekleme yapılacak değeri girin: ");
                    int varolan = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Eklenecek yeni değeri girin: ");
                    int yeni = Convert.ToInt32(Console.ReadLine());
                    listim.SonrasinaEkle(varolan, yeni);
                    break;

                case "5":
                    listim.BastanSil();
                    break;

                case "6":
                    listim.SondanSil();
                    break;

                case "7":
                    Console.Write("Silinecek değeri girin: ");
                    int silDeger = Convert.ToInt32(Console.ReadLine());
                    listim.ElemanSil(silDeger);
                    break;

                case "8":
                    running = false;
                    Console.WriteLine("Programdan çıkılıyor...");
                    break;

                default:
                    Console.WriteLine("Geçersiz seçim! 1-8 arasında bir değer girin.");
                    break;
            }
        }
    }
}
