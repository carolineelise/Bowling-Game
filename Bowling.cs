using System;
using System.Collections.Generic;

namespace collections_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var frames= new List<int>();
            

            for (var idx = 0; idx < 10; idx++) 
            { var frame = rnd.Next(0, 31);
                frames.Add(frame);
            }
            
            var game = 0;
            foreach(var score in frames)
            { game += score; }
            Console.WriteLine($"Game is {game}");
            // ListofNumbers.Add(20);
           // ListofNumbers.Add(7);
            //ListofNumbers.Add(16);
            //ListofNumbers.Add(23);
            //ListofNumbers.Add(22);
            //ListofNumbers.Add(12);
            //ListofNumbers.Add(4);
            //ListofNumbers.Add(28);
            //ListofNumbers.Add(9);
            //ListofNumbers.Add(18); var sum = 0; 
            // foreach(var nbr in ListofNumbers)
            //  { sum += nbr; }
            // Console.WriteLine($"Sum is {sum}");
        }
    }
}
