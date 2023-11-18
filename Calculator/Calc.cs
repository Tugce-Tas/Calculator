namespace Calculator;

public class Calc
{
    public void Calculate()
    {
        int n1, n2, t;

        Console.Write("ilk sayıyı girin: ");
        n1 = Convert.ToInt16(Console.ReadLine());

        Console.Write("ikinci sayıyı girin: ");
        n2 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("1: Topla");
        Console.WriteLine("2: Çıkart");
        Console.WriteLine("3: Böl");
        Console.WriteLine("4: Çarp");

        Console.WriteLine("Seçim yapınız: ");
        t = Convert.ToInt16(Console.ReadLine());

        if (t == 1)
        {
            Console.WriteLine("Toplam: {0}", n1 + n2);
        }
        else if (t == 2)
        {
            Console.WriteLine("Çıkarma: {0}", n1 - n2);
        }
        else if (t == 3)
        {
            if (n2 == 0)
            {
                Console.WriteLine("Tanımsız");
            }
            else
            {
                Console.WriteLine("Bölüm: {0}", n1 / n2);
            }
        }
        else if (t == 4)
        {
            Console.WriteLine("Çarpım: {0}", n1 * n2);
        }
        else
        {
            Console.WriteLine("Seçim 1-4 aralığında değil");
        }

    }
}