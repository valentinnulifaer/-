using System.Diagnostics;

namespace для_практической
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            for (; ; )
            {

                Console.WriteLine("Друг, выбери программу, я постараюсь использовать всё, чтобы она запустилась :)");
                Console.WriteLine("1 - Угадай число");
                Console.WriteLine("2 - Таблица умножения");
                Console.WriteLine("3 - Вывод делителей числа");
                Console.WriteLine("4 - Закрыть программу");
                string number = Console.ReadLine();
                int x = Convert.ToInt32(number);
                if (x == 1)
                {
                    NumberNamber();
                }
                if (x == 2)
                {
                    UmnoJenie();
                }
                if (x == 3)
                {
                    Delit();
                }
                if (x == 4)
                {
                    Zakrit();
                }
            }

            static void NumberNamber()
            {
                Console.WriteLine("Угадайте число от 0 до 100");
                Random random = new Random();
                int h = 0;
                int chislo = random.Next(0, 101);
                while (h != chislo)
                {
                    string d = Console.ReadLine();
                    h = Convert.ToInt32(d);
                    if (h > chislo)
                    {
                        Console.WriteLine("Надо меньше");
                    }
                    if (h < chislo)
                    {
                        Console.WriteLine("Надо больше");
                    }
                }
                Console.WriteLine("Ты угадал");
            }

            static void UmnoJenie()
            {
                int[,] l = new int[10, 10];
                for (int n = 1; n < l.GetLength(0); n++)
                {
                    for (int v = 1; v < l.GetLength(1); v++)
                    {
                        l[n, v] = n * v;
                    }
                }

                for (int f = 1;f < l.GetLength(0); f++)
                {
                    Console.WriteLine();
                    for(int p = 1;p < l.GetLength(1); p++)
                    {
                        Console.Write(l[f, p] + "\t");
                    }
                }
                Console.WriteLine();
            }
            static void Delit()
            {
               string i = Console.ReadLine();
               int x = Convert.ToInt32(i);
               for(int a = 1; a <= x; a++)
                {
                    if (x % a == 0)
                    {
                        Console.Write(a + " ");
                    }
                }
                
            }

            static void Zakrit()
            {
                Process.GetCurrentProcess().Kill();
            }
        }
    }
}