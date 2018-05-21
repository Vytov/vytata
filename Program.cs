using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication26
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = new SortedDictionary<double, int>();

            int[] numberinput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            foreach (var result in numberinput)
            {
                if (numbers.ContainsKey(result))
                {

                    numbers[result]++;
                }
                else {


                    numbers.Add(result, 1);
                
                }
            }
         

           
        }
    }
}
