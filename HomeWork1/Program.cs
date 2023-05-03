using HomeWork.ConsoleApp.DomainModel;

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
            Console.WriteLine("Test Class for Rationals and Polynomials");
            Console.WriteLine("================================================");
            Console.WriteLine("Rationals:");
            Console.WriteLine("");
            var r1 = new Rational(3,2);
            var r2 = new Rational(5);

            Console.WriteLine($"{r1} + {r2} = {r1 + r2}");
            Console.WriteLine($"{r1} - {r2} = {r1 - r2}");
            Console.WriteLine($"{r1} * {r2} = {r1 * r2}");
            Console.WriteLine($"{r1} / {r2} = {r1 / r2}");
            r1.ValueOf();
            r2.ValueOf();

            Console.WriteLine("================================================");
            Console.WriteLine("Polynomials:");
            Console.WriteLine("");
            Random rnd = new Random();
            var m1 = new Monomial(1, "x",4 );
            var m3 = new Monomial(2, "x",2 );
            var m2 = new Monomial(5, "x", 1);

            Console.WriteLine($"{m1} + {m3} / {m2} = {m1} + {m3 / m2}");
            Console.WriteLine($"{m1} + {m3} * {m2} = {m1} + {m3 * m2}");

        }

    }

}
