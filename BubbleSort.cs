using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAlgorithms
{
    class BubbleSort
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int[] numbersList = new int[100];
            int loop = numbersList.Length -1;
            int length = numbersList.Length;
            int temp;
            var startTime = DateTime.Now;
            for (int i = 0; i < length; i++)
            {
                numbersList[i] = rd.Next(0, 100);
            }
            Console.WriteLine("\nUnsorted Array: ");
            foreach(var i in numbersList)
            {
                Console.Write($"{i} ");
            }
            for (int i = 0; i < loop ; i++)
            {
                for (int j = 0; j < loop; j++)
                {
                    if(numbersList[j] > numbersList[j + 1])
                    {
                        temp = numbersList[j];
                        numbersList[j] = numbersList[j + 1];
                        numbersList[j + 1] = temp;
                    }

                }
            }
            Console.WriteLine("\nSorted Array: ");
            foreach (var i in numbersList)
            {
                Console.Write($"{i} ");
            }
            var time = DateTime.Now.Subtract(startTime);
            Console.WriteLine($"\r\nExecution time: {time.Milliseconds}(ms)");
            Console.ReadKey();
        }
    }
}
