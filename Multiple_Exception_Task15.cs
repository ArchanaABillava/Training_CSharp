using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_CSharp
{
    public class task15
    {
        //float result = 0;
        /// <summary>
        /// DivideByZeroException 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>

        /// <summary>
        /// IndexOutOfRangeException
        /// </summary>

        /// <summary>
        /// Multiple catch blocks
        /// </summary>
        public void MultipleCatch()
        {
            int[] a = { 10, 8, 6, 4, 8, 2 };
            int[] b = { 5, 0, 3, 0, 2 };
            for (int i = 0; i < a.Length; i++)
            {
                try
                {
                    Console.WriteLine(a[i] / b[i]);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }

            }

        }

    }

    internal class Multiple_Exception_Task15
    {
        public static void Main()
        {
            task15 ex = new task15();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("----------Task-15(Multiple Catch-----------");
            Console.WriteLine("-------------------------------------------");
            ex.MultipleCatch();
        }
    }
}
