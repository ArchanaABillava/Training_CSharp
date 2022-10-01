using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Training_CSharp
{
    internal class Mobile_RegularExp_Task14
    {
        public static void Main()
        {
           
            mobile();

        }
        
        public static void mobile()
        {
            Console.WriteLine("mobile validation");
            string mobile = "9741023905";
            var validate_mobile = Regex.IsMatch(mobile, @"^(?:(?:\+|0{0,2})91(\s*[\-]\s*)?|[0]?)?[789]\d{9}$");
            Console.WriteLine(validate_mobile);
            Console.WriteLine($"Mobile Number:{mobile}");
        }
    }
}
