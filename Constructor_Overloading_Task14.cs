using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_CSharp
{
    public class addition
    {
        public int num1;
        public int num2;
        public int tot1;
        public float tot2;
        public string id, name;


        public addition(int num1, int num2)
        {

            tot1 = num1 + num2;
            Console.WriteLine($"Addition of 2 integer numbers:{tot1}");
        }

        public addition(float num1, float num2, float num3)
        {

            tot2 = num1 + num2 + num3;
            Console.WriteLine($"Addition of 2 float numbers:{tot2}");
        }
        public addition(string id, string name)
        {
            Console.WriteLine("Using string");

            Console.WriteLine($"{name} :{id}");
        }


    }
    internal class Constructor_Overloading_Task14
    {
        public static void Main()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("working of Constructor Overloading-Task14");
            Console.WriteLine("-----------------------------------------");
            addition add1 = new addition(10, 20);
            addition add2 = new addition(100, 200, 300);
            addition add3 = new addition("CS001", "Archana");

        }
    }
}

