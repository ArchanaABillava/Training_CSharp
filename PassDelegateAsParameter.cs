using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_CSharp
{
    /// <summary>
    /// Declaration of the delegate
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    public delegate void PassDelegateAsParameterDelegate(string a, string b);

    public class Calculator
    {
        /// <summary>
        /// Add
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void SBI(string bname , string interest)
        {
            
            
            Console.WriteLine($"Bank Name:{bname} ---- Interest: {interest}");//10+20=30
            Console.WriteLine("");
        }
        /// <summary>
        /// Sub
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void HDFC(string bname, string interest)
        {
            Console.WriteLine($"Bank Name:{bname} ---- Interest:{interest}");
            Console.WriteLine("");
        }
        /// <summary>
        /// Mul
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void KOTAK(string bname, string interest)
        {
            Console.WriteLine($"Bank Name:{bname} ---- Interest:{interest}");
            Console.WriteLine("");
        }
        /// <summary>
        /// Div
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void AXIS(string bname, string interest)
        {
            Console.WriteLine($"Bank Name:{bname} ---- Interest:{interest}");
            Console.WriteLine("");
        }
        public void ICICI(string bname, string interest)
        {
            Console.WriteLine($"Bank Name:{bname} ---- Interest:{interest}");
            Console.WriteLine("");
        }
    }
    internal class PassDelegateAsParameter
    {
        public static void Main()
        {
            Calculator calculator = new Calculator();
            //reference of the methods are passed as the parameter to the Values method
            Values(calculator.SBI,"SBI", "2.70 %");
            Values(calculator.HDFC, "HDFC", "3.00% – 3.50%");
            Values(calculator.KOTAK, "KOTAK", "3.50%");
            Values(calculator.AXIS, "AXIS", "3.00% – 3.50%");
            Values(calculator.ICICI, "ICICI", "3.00% – 3.50%");


        }
        /// <summary>
        /// delegate as the 1st parameter
        /// </summary>
        /// <param name="dlgt"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void Values(PassDelegateAsParameterDelegate dlgt, string bname, string interest)
        {
            dlgt(bname, interest);//calculator.Add(10,20)
        }



    }
}
