using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbri 1-10;
            //kasutaja peab selle numbri ära arvama;
            //kui kasutaja suutis numbri ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu
            //*programm genereerib juhusliku numbri 1 korra

            bool loopActive = true;
            Random rnd = new Random();
            int CPUNumber = rnd.Next(1,11);
            int i = 0;

            while (loopActive)
            {
                Console.WriteLine("Arva number ära:");
                int userGuess = Convert.ToInt32(Console.ReadLine());
                i++;
                if (userGuess == CPUNumber)
                {
                    Console.WriteLine("Palju õnne! Oled mängu võitnud.");
                    loopActive = false;
                }
                else { Console.WriteLine($"Valesid vastuseid: {i}"); }

            }

        }
    }
}
