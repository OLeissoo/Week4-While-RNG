using System;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbri 1-10;
            //kui genereeritud number on 5, programm lõpetab töö ja soovib kasutajale "kena päeva";
            //kui genereeritud number on midagi muud, siis jätkab oma tööd.

            Random rnd = new Random();
            int i = 0;

            while (i != 5)
            {
                int myRandomNumber = rnd.Next(1, 11); //random number max peab olema +1 sellele, mis sa tahad, et genereeritud max on
                Console.WriteLine($"Juhuslik number on {myRandomNumber}");
                if(myRandomNumber == 5)
                {
                    i = myRandomNumber;
                }
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
