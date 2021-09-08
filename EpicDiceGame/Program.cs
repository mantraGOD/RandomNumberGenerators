using System;

namespace EpicDiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat
            //iga mängija viskab täringut (1-6)
            //programm kuvab nende visete tulemused ja kuvab,kes võidab,ehk kes viskas
            Random rnd = new Random();
            int MyRandomNumber = rnd.Next(1, 7);

            string playerOne = "Dodo";
            string playerTwo = "SoSo";
            int DodoThrow = rnd.Next(1, 7);
            int SoSoThrow = rnd.Next(1, 7);

            Console.WriteLine($"{playerOne} threw {DodoThrow}");
            Console.WriteLine($"{playerTwo} threw {SoSoThrow}");


            if(DodoThrow >SoSoThrow )
            {
                Console.WriteLine($"{playerOne} Wins! ");
            }
            else if (DodoThrow < SoSoThrow)
            {
                Console.WriteLine($"{playerTwo} wins!");
            }
            else
            {
                Console.WriteLine("Draw! Lets them try again.");
            }






        }
    }
}
