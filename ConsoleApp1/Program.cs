using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] objects = new object[]{24,"hello",23.14,'b'};
            foreach(object obj in objects)
            {
                Console.Write($"{obj} ");
            }
            Console.WriteLine();
            int k = int.Parse(Console.ReadLine());
            rrotate(objects, k);
            foreach(object obj in objects)
            {
                Console.Write($"{obj} ");
            }
            Console.ReadLine();
        }

        static object rrotate(object[] objects, int k)
        {
            if ( objects.Length > 1 )
            {
                int n = objects.Length;
                k %= n;
                
                Array.Reverse(objects, 0, n - k);
                Array.Reverse(objects, n - k, k);
                Array.Reverse(objects);
            }
            return objects;
        }
    }
}
