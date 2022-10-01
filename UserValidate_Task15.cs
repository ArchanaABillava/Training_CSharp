using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_CSharp
{
    /// <summary>
    /// Step 1 :Create the user-defined exception class
    /// </summary>
    public class UserValidate : ApplicationException
    {
        //Constructor 
        public UserValidate(string message) : base(message)
        {

        }
    }
    /// <summary>
    /// Step 2:Implementing the exception in the try and catch block
    /// </summary>
    internal class UserValidate_Task15
    {
        public static void Main()
        {
            int total_trainees;
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("-----Task-15 User Defined Validation-----");
            Console.WriteLine("-----------------------------------------");
            try
            {
                Console.WriteLine("Enter Your age");
                total_trainees = Convert.ToInt32(Console.ReadLine());
                if (total_trainees < 22)
                {
                    throw (new UserValidate("You are not eligible "));
                }
                else
                {
                    Console.WriteLine("Eligible");
                }
            }
            catch (UserValidate e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
