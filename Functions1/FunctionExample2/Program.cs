using System;

namespace FunctionExample2
{
    class Program
    {
        static int function(int k, int costs_count, int[] costs)
        {
            int canAchieve = 0;
            int temp = 0;
            int repeatControl = 0;

            for (int i=0; i < costs_count; i++)
                {
                    for(int j = i-1; j >= 0; j--)
                    {
                        temp += costs[j];
                    
                        if (temp > k && repeatControl<1)
                            {
                                i++;
                                repeatControl++;
                            }
                    }
                if (temp <= k)
                {
                    canAchieve += 1;
                }
            }
            return canAchieve;
        }
        public static void Main(string[] args)
        {
            int[] array = { 2, 3, 6, 7, 3, 4, 8 };
            int count = 7;
            int wallet = 14;
            Console.WriteLine(Program.function(wallet, count, array));
        }
    }
}
