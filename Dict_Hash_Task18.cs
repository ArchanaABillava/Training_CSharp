using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_CSharp
{
    internal class Dict_Hash_Task18
    {
        public static void Dictionary_Task()
        {
            Dictionary<int, string> vs = new Dictionary<int, string>();
            vs.Add(1, ".NET Stream");
            vs.Add(2, "Database");
            vs.Add(3, "Testing");
            Console.WriteLine("DICTIONARY");
            foreach (var obj in vs)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------------------------------------");
            var key = new List<int>(vs.Keys);
            foreach (var obj in key)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------------------------------------");
            var values = new List<string>(vs.Values);
            foreach (var obj in values)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Key: {vs[1]}");
            //Console.WriteLine($"Key: {vs[0]}");//If the key is not found -> raise an exception

        }
        /// <summary>
        /// Hastable
        /// </summary>

        public static void Hashtable_Task()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "Sam");
            ht.Add(2, 121);
            ht.Add(3, "John");
            ht.Add(4, 131);
            ht.Add(5, "Archana@123");
            ht.Add(6, 1331411);
            Console.WriteLine("HASHTABLE");
            //ICollection Interface
            ICollection key = ht.Keys;
            foreach (var obj in key)
            {
                Console.WriteLine(ht[obj]);
            }
            Console.WriteLine($"Key: {ht[1]}");
            Console.WriteLine($"Key: {ht[3]}");
        }

        public static void Main()
        {
            ///Comparision of Dictionary and Hashtable
            ///Dictionary
            ///In Dictionary, we can store key/value pairs of same type.
            ///We must specify the type of key and value.
            ///Hashtable
            ///In Hashtable, we can store key/value pairs of the same type or of the different type.
            ///there is no need to specify the type of the key and value

            Dictionary_Task();
            Console.WriteLine("-----------------------------------------");
            Hashtable_Task();
        }

    }
}
