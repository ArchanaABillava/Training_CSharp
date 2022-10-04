using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_CSharp
{
    internal class Generics_Task18
    {
        public delegate T SampleDelegate<T>(T a);
        class MathOperations
        {
            public int square(int a)
            {
                return a * a;
            }
            public int cube(int x)
            {
                return 6*x*x;
            }
            public int circle(int r)
            {
                return (22*r*r)/7;
            }
            public double square(double a)
            {
                return a*a;
            }
            public double cube(double x)
            {
                return 6 * x * x;
            }
            public double circle(double r)
            {
                return 3.14*r*r;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("****Generic Delegate-Task-18****");
                Console.WriteLine("--------------------------------------------------");
                MathOperations m = new MathOperations();
                // Instantiate delegate with add method using int
                SampleDelegate<int> dlgt = new SampleDelegate<int>(m.square);
                Console.WriteLine("Area of Square  for int: " + dlgt(5));
                Console.WriteLine("\n");
                // Instantiate delegate with subtract method
                dlgt = m.cube;
                Console.WriteLine("Area of Cube for int: " + dlgt(8));
                Console.WriteLine("\n");
                dlgt = m.circle;
                Console.WriteLine("Area of circle for int: " + dlgt(7));
                Console.WriteLine("--------------------------------------------------");

                // Instantiate delegate with add method using double
                SampleDelegate<double> dlgt1 = new SampleDelegate<double>(m.square);
                Console.WriteLine("Area of Square for double: " + dlgt1(5.5));
                Console.WriteLine("\n");
                // Instantiate delegate with subtract method
                dlgt1 = m.cube;
                Console.WriteLine("Area of Cube for double: " + dlgt1(8.8));
                Console.WriteLine("\n");
                dlgt1 = m.circle;
                Console.WriteLine("Area of circle for double: " + dlgt1(2.5));
                Console.WriteLine("--------------------------------------------------");
            }
        }
    }
}

