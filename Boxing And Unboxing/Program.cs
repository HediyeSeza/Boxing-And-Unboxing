using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_And_Unboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 22; // 22 will assigned to age
            
            Object Obj = age; // Boxing

            age = 100;

            System.Console.WriteLine("Value - type value of age is : {0}", age);
            
            System.Console.WriteLine("Object - type value of obj is : {0}", age);
            
            Console.ReadKey();
        }
    }
}
