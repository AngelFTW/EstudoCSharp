using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            List<string> list2 = new List<string>{"Opa", "Uepa"};

            list.Add("Opa");
            list.Add("Uepa");
            list.Add("Upa");
            list.Add("Aaa");
            list.Insert(2, "Momi");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'U');
            Console.WriteLine("Primeiro 'U': " + s1);

            string s2 = list.FindLast(x => x[0] == 'U');
            Console.WriteLine("Ultimo 'U': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'U');
            Console.WriteLine("Primeira posição 'U':" + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'U');
            Console.WriteLine("Ultima posição 'U':" + pos2);

            List<string> list3 = list.FindAll(x => x.Length == 4);
            Console.WriteLine("----------------------------");

            foreach (string obj in list3)
            {
                Console.WriteLine(obj);
            }

            list.Remove("Uepa");
            Console.WriteLine("----------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'U');
            Console.WriteLine("----------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAt(2);
            Console.WriteLine("----------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            
            list.RemoveRange(1, 2);
            Console.WriteLine("----------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}