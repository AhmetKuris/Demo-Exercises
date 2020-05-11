using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array4Life = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            var count = array4Life.Length;

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    for (int k = 0; k <count; k++)
                    {
                        if (array4Life[i] + array4Life[j] == array4Life[k])
                        {
                            Console.WriteLine("{0} + {1} = {2}", array4Life[i], array4Life[j], array4Life[k]);
                        }

                    }
                }

            }
            Console.ReadLine();
        }
    }
}
