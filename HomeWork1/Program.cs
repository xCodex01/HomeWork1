using HomeWork.ConsoleApp.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1.ConsoleApp.App
{
    public class Program
    {

        /// <summary>
        /// Main Test Classi in Class Library: "HomeWork.ConsoleApp.DomainModel"
        /// </summary>
        public static void Main()
        {

            Console.WriteLine("HomeWork #1");
            Console.WriteLine("Test Class for Rational and Polynomials");
            Console.WriteLine("================================================");
            Console.WriteLine("Rationals:");
            var r1 = new Rational(3,2);
            var r2 = new Rational(5);

            Console.WriteLine($"{r1} + {r2} = {r1 + r2}");
            Console.WriteLine($"{r1} - {r2} = {r1 - r2}");
            Console.WriteLine($"{r1} * {r2} = {r1 * r2}");
            Console.WriteLine($"{r1} / {r2} = {r1 / r2}");
            r1.ValueOf();
            r2.ValueOf();
            
        }

    }
}
