using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4POO
{
    class Program
    {
        static void Main(string[] args)
        {
            int s, l;
            
                Reading Vasya = new Reading();
                Console.WriteLine("Welcome, Vasya.");
                do
                {
                    Console.Write("Enter the tavel total hours: ");
                    Vasya.N = int.Parse(Console.ReadLine());
                    l = Vasya.N;
                } while (Vasya.N < 1);
                do
                {
                    Console.Write("Enter the reading total hours: ");
                    Vasya.K = int.Parse(Console.ReadLine());
                    s = Vasya.K;
                } while (Vasya.K > Vasya.N);



                Console.Write("Enter the Light levels per hour, separated by space: ");
                Vasya.StringLL = Console.ReadLine();

                Vasya.getLL();
                Vasya.ReadingHours(s, l);
            Console.ReadKey();
                
        }
    }
}
