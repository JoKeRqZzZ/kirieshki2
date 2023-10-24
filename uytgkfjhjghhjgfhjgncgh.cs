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
                    break;
                }
                else if (chisloman > chislo)
                {
                    Console.WriteLine("много даешь брат");
                }
                else if (chisloman < chislo)
                {
                    Console.WriteLine("мало даешь брат");
                }
            }
        }
        static void tablicaUmnozheniya()
        {
            int[ , ] matrica = new int[9, 9];

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    matrica[i - 1, j - 1] = i * j;
                }
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(matrica[i, j] + "\t");
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
            int deistviye = 0;

            while (deistviye !=4)
            { 
                Console.WriteLine("1 - угадайка ");
                Console.WriteLine("2 - таблица умножения");
                Console.WriteLine("3 - делители числа");
                Console.WriteLine("4 - выход");
                Console.WriteLine("выбор действия");
                deistviye = Convert.ToInt32(Console.ReadLine());

                if (deistviye == 1)
                {
                    ugadayChislo();
                }
                else if (deistviye == 2)
                {
                    tablicaUmnozheniya();
                }
                else if (deistviye == 3)
                {
                    deliteliChisla();
                }
            }

        }
    }
}
