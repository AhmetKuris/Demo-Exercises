using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer number:");
            
            var number= Convert.ToInt32(Console.ReadLine());

            int[] digitsArray = GetIntArray(number);

           digitsArray = digitsArray.Reverse().ToArray();

            for (int i = 0; i < digitsArray.Length; i++)
            {
                Console.WriteLine(PowerOf10(10,i + 1)  +"s digit  " +digitsArray[i]);
            }

            Console.ReadLine();

            int PowerOf10(int num, int pow)
            {
                int result = 1;

                if (pow > 0)
                {
                    for (int i = 1; i <= pow; ++i)
                    {
                        result *= num;
                    }
                }
                else if(pow < 0)
                {
                    for (int i = -1; i > pow; i--)
                    {
                        result *= num;
                    }
                }
                else if (pow == 0)
                {
                    result = 1;
                }

                return result;
            }


            int[] GetIntArray(int num)
            {
                List<int> listOfInts = new List<int>();
                while (num > 0)
                {
                    listOfInts.Add(num % 10);
                    num = num / 10;
                }
                listOfInts.Reverse();
                return listOfInts.ToArray();
            }

        }
    }
}
