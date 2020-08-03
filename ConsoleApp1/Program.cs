using System;
using System.IO;

namespace AgeCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            for (;;) 
            {
                Console.WriteLine("1. Pokaż wszystkie osoby z wiekiem!");
                Console.WriteLine("2. Pokaż najstarszą osobe!");
                Console.WriteLine("3. Pokaż najmłodszą osobę!");
                Console.WriteLine("4. Pokaż średnią wieku!");
                Console.WriteLine("0. Wyłącz Program!");

                Console.WriteLine("Wybierz 1, 2, 3, 4...");
                string choice = Console.ReadLine();
                Console.Clear();
                Age ag = new Age();
                ag.FileToPerson();
                ag.SelectedOption(choice);
                Console.Clear();
            }


        }
    }
}
