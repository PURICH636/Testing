using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication2
{
    class TestStack
    {
        public static void Main(string[] args)
        {
            SimpleStack stack = new SimpleStack(5);
            Console.WriteLine("============ Push data into stack ============" );
            for(int i = 1; i < 5; i++)
            {
                Console.WriteLine("Push :" + i);
                stack.push(i);
            }

            Console.WriteLine("============ Pop data into stack ============");
            for(int j = 1; j < 5; j++)
            {
                Console.WriteLine("Pop = {0}", stack.pop());
            }
            Console.ReadKey();
        }
    }
}
