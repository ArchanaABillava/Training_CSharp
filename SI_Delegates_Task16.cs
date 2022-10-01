using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_CSharp
{
    public delegate void SI_Delegates(string bname, double interest, double p, int time);
    public class Calcu
    {
        /// <summary>
        /// Add
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void SBI(string bname, double interest, double p, int time)
        {
            double amt1;
            amt1 = (interest * p * time) / 100;
            Console.WriteLine($"Bank Name:{bname} ---- Interest: {interest}");
            Console.WriteLine($"Simple Interest for {bname} : {amt1}");
            Console.WriteLine("----------------------------------------");
        }
        /// <summary>
        /// Sub
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void HDFC(string bname, double interest, double p, int time)
        {
            double amt2;
            amt2 = (interest * p * time) / 100;
            Console.WriteLine($"Bank Name:{bname} ---- Interest:{interest}");
            Console.WriteLine($"Simple Interest for {bname} : {amt2}");
            Console.WriteLine("----------------------------------------");
        }
        /// <summary>
        /// Mul
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void KOTAK(string bname, double interest, double p, int time)
        {
            double amt3;
            amt3 = (interest * p * time) / 100;
            Console.WriteLine($"Bank Name:{bname} ---- Interest:{interest}");
            Console.WriteLine($"Simple Interest for {bname} : {amt3}");
            Console.WriteLine("----------------------------------------");
        }
        /// <summary>
        /// Div
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void AXIS(string bname, double interest, double p, int time)
        {
            double amt4;
            amt4 = (interest * p * time) / 100;
            Console.WriteLine($"Bank Name:{bname} ---- Interest:{interest}");
            Console.WriteLine($"Simple Interest for {bname} : {amt4}");
            Console.WriteLine("----------------------------------------");
        }
        public void ICICI(string bname, double interest, double p, int time)
        {
            double amt5;
            amt5 = (interest * p * time) / 100;
            Console.WriteLine($"Bank Name:{bname} ---- Interest:{interest}");
            Console.WriteLine($"Simple Interest for {bname} : {amt5}");
            Console.WriteLine("----------------------------------------");
        }
    }
    internal class SI_Delegates_Task16
    {
        public static void Main()
        {
            Calcu calculator = new Calcu();
            //reference of the methods are passed as the parameter to the Values method
            Values(calculator.SBI, "SBI", 2.70, 10000, 2);
            Values(calculator.HDFC, "HDFC", 3.10, 10000, 2);
            Values(calculator.KOTAK, "KOTAK", 3.50, 10000, 2);
            Values(calculator.AXIS, "AXIS", 3.20, 10000, 2);
            Values(calculator.ICICI, "ICICI", 3.40, 10000, 2);


        }
        /// <summary>
        /// delegate as the 1st parameter
        /// </summary>
        /// <param name="dlgt"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void Values(SI_Delegates dlgt, string bname, double interest, double p, int time)
        {
            dlgt(bname, interest, p, time);//calculator.Add(10,20)
        }

    }
}
