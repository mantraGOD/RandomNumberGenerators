﻿using System;

namespace RandomNumberGenerators
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
           
            int MyRandomNumber = rnd.Next(1, 11);
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //programm kontrollib,kas genereeritud number on suurem kui 5.;
            //kui number on suurem,kui 5,siis konsool kuvab juhuslik number on {MyRandomNumber},see on suurem kui 5";
            //kui number 5,siis konsool kuvab "juhuslik number on 5";
            Console.WriteLine(MyRandomNumber);
            Console.WriteLine($"Arvuti genereeris: {MyRandomNumber}");

            if(MyRandomNumber > 5)
            {
                Console.WriteLine($"juhuslik number on {MyRandomNumber},see on suurem, kui 5");
            }
            else if(MyRandomNumber < 5)
            {
                Console.WriteLine($"juhuslik number on {MyRandomNumber},see on väiksem, kui 5");
            }
            else
            {
                Console.WriteLine("juhuslik number ongi 5");
            }


        }
    }
}
