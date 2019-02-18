using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Challenge_13
{
    class Program
    {
        static void Main(string[] args)
        {
            double summe = 0;
            int i = 0;
            double[] marks = { 1, 9, 7, 3, 2 };
            double[] percent = new double[marks.Length];
            double[] candies = new double[marks.Length];
            foreach (var item in marks)
            {
                summe = summe + marks[i];
                i++;
            }
            i = 0;
            foreach (var item in marks)
            {
                percent[i] = marks[i] / summe;
                i++;
            }
            i = 0;
            foreach (var item in marks)
            {
                candies[i] = 15 * percent[i];
                i++;
            }
            i = 0;
            //Output

            Console.WriteLine("Marks:");
            foreach (var item in marks)
            {
                Console.Write(marks[i]);
                i++;
            }
            i = 0;
            Console.WriteLine();
            //-----------------------------------------------
            Console.WriteLine("Candies");
            foreach (var item in marks)
            {
                Console.Write(Math.Round( candies[i]));
                i++;
            };
            Console.ReadLine();


        }
    }
}
