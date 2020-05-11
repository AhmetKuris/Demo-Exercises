using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Find the maximum number
            int[] testArray = new[] {4,3,3,5,-1,6,0,3,7,8 };

            int max = testArray[0]; 

            for (int i =1; i <testArray.Length; i++)
            {
                if (testArray[i]> max)
                {
                    max = testArray[i];
                }
            }

            Console.WriteLine("Maximum number: "+max);



            //Find the minimum number
            int min = testArray[0];

            for (int i = 1; i < testArray.Length; i++)
            {
                if (testArray[i] < min )
                {
                    min = testArray[i];
                }
            }

            Console.WriteLine("Minimum number: "+min);


            //Sort from small to big, ind ascending order
           
               
                for (int i = 0; i < testArray.Length; i++)
                {
                  

                    for (int j = i+1; j < testArray.Length; j++)
                    {
                        if (testArray[j] < testArray[i])
                        {
                           
                            Swap(ref testArray[i], ref testArray[j]);
                        }
                    }
                }
            

            void Swap(ref int x, ref int y)
            {
                var temp = x;
                x = y;
                y = temp;
            }

            foreach (var item in testArray)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
