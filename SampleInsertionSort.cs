using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class InsertionSort
    {
        public int[] Sort(int[] data)
        {
            int[] sortedData = new int[data.Length];
            for(int i = 0; i < data.Length; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    if(j == i)
                    {
                        sortedData[j] = data[i];
                    }
                    else if(data[i] < sortedData[j])
                    {
                        for(int k = i; k > j; k--)
                        {
                            sortedData[k] = sortedData[k - 1];
                        }
                        sortedData[j] = data[i];
                        break;
                    }
                }
                Console.WriteLine("Sorting Data:");
                for(int j = 0; j <= i; j++)
                {
                    Console.Write(sortedData[j] + " ");
                }
                Console.WriteLine();
            }
            return sortedData;
        }
    }
}
