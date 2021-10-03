using System;

namespace PINInfiniteLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada PIN-kood;
            //võrdleb sisestatud PIN-koodi arvuga 1234;
            //kui sisestatud PIN-kood on sama, konsool kuvab "Tere tulemast!";
            //kui sisestatud PIN-kood on erinev, konsool kuvab "Vale PIN, proovi uuesti";
            //kasutajal on piiramatu arv katseid

            bool loopActive = true; //boolean --> true/false
            int i = 0;

            while (loopActive)
            {
                Console.WriteLine("Sisesta PIN:"); //cw+double TAB
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if (userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    loopActive = false;
                }
                else
                {
                    Console.WriteLine("Vale PIN. Proovi uuesti!");
                    i++; //i=i+1
                    Console.WriteLine($"Oled vale PIN-koodi sisestanud {i} korda.");
                }
            }

            Console.WriteLine("Kena päeva!");

        }
    }
}
