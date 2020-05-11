using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = 10;
            for (int i = 0; i < numberOfRows; i++)
            {
               int middle= numberOfRows / 2;
               int remaining = numberOfRows % 2;
               int together = middle + remaining;

               for (int j = -numberOfRows; j < (numberOfRows*3); j++)
               {
                   if (j >together-i && j<together+i)
                   {
                       Console.Write("*");
                   }
                   else if (j==(numberOfRows*2)-2)
                   {
                       Console.WriteLine(" ");
                   }
                   else
                   {
                       Console.Write(" ");

                   }
               }



            }

            Console.ReadLine();
        }
    }
}
