using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter you GPA: ");
            double gpa = double.Parse(Console.ReadLine());

            if (gpa >= 3.5)
                Console.WriteLine("Congratulations, you made the honor roll!");
            else if(gpa <= 2.0)
                Console.WriteLine("Sorry, you are on probation...");
            else
                Console.WriteLine("Great job, you are in good standing");



        }
    }
}
