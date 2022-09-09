using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> evens = new List<int>();
            List<int> notEvens = new List<int>();


            for (int i = 0; i < 100; i++)
            {
                int a = rnd.Next(1, 10);
                if (decomposer(a) == 0)
                {
                    evens.Add(a);
                }
                else
                {
                    notEvens.Add(a);
                }
            }
            int evenSum = summator("evens", evens);
            int notEvenSum = summator("not evens", notEvens);
            Console.WriteLine();
            Console.WriteLine($"Sum in \"Evens\" list is : {evenSum}");
            Console.WriteLine($"Sum in \"Not Evens\" list is : {notEvenSum}");

            Console.ReadKey();

        }

        public static int decomposer(int a)
        {
            if (a % 2 == 0)
                return 0; 
            else
                return 1;
        }
        public static int summator(string name, List<int>lst)
        {
            Console.WriteLine($"...Numbers in {name} list");
            int sum = 0;
            foreach (int i in lst)
            {
                Console.WriteLine(i);
                sum += i;
            }
            return sum;
        }
    }
}