using System;
using System.Collections.Generic;
using System.IO;
using Icomparable.Entities;

namespace Icomparable
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var path = @"C:\Users\JoseGabriel\Documents\C#Poo\test.txt";
            
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}