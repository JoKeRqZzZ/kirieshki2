namespace rabotyaga
{
    internal class Kirieshki
    {
        static void Main()
        {
            deistviya();
        }
        static void ugadayChislo()
        {
            Random randomnik = new Random();
            int chislo = randomnik.Next(0, 100);
            Console.WriteLine("угадай рандомное число ");
            while (true)
            {
                int chisloman = Convert.ToInt32(Console.ReadLine());
                if (chisloman == chislo)
                {
                    Console.WriteLine("красавчик брат");
                }
                else if (chisloman > chislo)
                {
                    Console.WriteLine("много даешь брат");
                }
                else if (chisloman < chislo)
                {
                    Console.WriteLine("мало даешь брат");
                    break;
                }
            }
        }
        static void tablicaUmnozheniya()
        {
            
            for (int i = 1; i<=9;i++)   
            {
                for (int h = 1; h<=9; h++)
                {
                    Console.Write(i * h + " \t " );
                }
                Console.WriteLine();
            }
        }
        static void deliteliChisla()
        {
            Console.WriteLine("введи число");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (i <= num)
            {
                i++;
                if (num % i == 0)
                    Console.WriteLine("число  делится на "+ i);
            }
        }
        static void deistviya()
        {
            while (true)
            {
                Console.WriteLine("1 - угадайка ");
                Console.WriteLine("2 - таблица умножения");
                Console.WriteLine("3 - делители числа");
                Console.WriteLine("выбор действия");
                int deisviye = Convert.ToInt32(Console.ReadLine());
                if (deisviye == 1)
                {
                    ugadayChislo();
                }
                else if (deisviye == 2)
                {
                    tablicaUmnozheniya();
                }
                else if (deisviye == 3)
                {
                    deliteliChisla();
                }
            }

        }
    }
}
