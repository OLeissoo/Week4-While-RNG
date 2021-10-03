using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbri 1-10;
            //kasutaja peab selle numbri ära arvama;
            //kui kasutaja suutis numbri ära arvata, siis ta on mängu võitnud;
            //katsete arv on 3, kui 3 katsega ära ei arva, siis mängu võidab arvuti;
            //*programm genereerib juhusliku numbri 1 korra

            Random rnd = new Random();
            int CPUNumber = rnd.Next(1, 11);
            int i = 0;

            while (i < 3) 
            {
                Console.WriteLine("Arva number ära:");
                int userGuess = Convert.ToInt32(Console.ReadLine());
                i++;
                if (userGuess == CPUNumber)
                {
                    Console.WriteLine("Palju õnne! Oled mängu võitnud.");
                    break;
                }
                Console.WriteLine($"Vale number. {3 - i} katset on jäänud.");
            }
            if (i == 3)
            {
                Console.WriteLine("Ebaõnn! Arvuti võitis.");
            }
        }
    }
}
