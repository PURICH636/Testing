using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication2
{
    class Program
    {
        public static void Main(string[] args)
        {
            ArrayList array = new ArrayList();
            Console.WriteLine("array size: " + array.Count);
            for(int i = 0; i < 7; i++)
            {
                array.Add(i * 2);
            }
            
            Console.WriteLine("array size: " + array.Count);
            
            printArray(array);
            for (int j = 7; j < 10; j++)
            {
                array.Add(j * 3);
            }
            Console.WriteLine();
            Console.WriteLine("array size: " + array.Count);

            printArray(array);

            Console.ReadKey();
        }

        public static void printArray(ArrayList a)
        {
            for (int i = 0; i < a.Count; i++)
            {
                Console.Write(a[i]+" ");
            }
        }
    }
}
