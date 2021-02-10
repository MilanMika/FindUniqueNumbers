using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_find_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 1, 3 };
            foreach (var number in FindUniqueNumbers(numbers))
                Console.WriteLine(number);
        }
        private static IEnumerable<int> FindUniqueNumbers(IEnumerable<int> numbers)
        {
            var unique = new List<int>();            

            foreach (var n in numbers)
            {
                
                if (unique.Contains(n))
                {
                    unique.Remove(n);                    
                    continue;
                }
                unique.Add(n);
            }            
            return unique;
        }
    }
    
}

