using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            string desen = "*";
            var cleaned = desen.Replace("\n", "").Replace("\r", "");
            var space = " ";

            int squareSide = 15;
            for (int i = 0; i < squareSide; i++)
            {
                

                for (int j = 0; j <squareSide; j++)
                {
                    if (i==0 || i==squareSide-1 )
                    {
                    

                        if (j == squareSide - 1)
                        {
                            Console.WriteLine(cleaned);
                        }
                        else
                        {
                            Console.Write(cleaned);

                        }
                    }
                    else
                    {
                      

                        if (j == squareSide - 1)
                        {
                           
                            Console.WriteLine(cleaned);
                        }
                        else if (j==0)
                        {
                            Console.Write(cleaned);
                        }
                        else
                        {
                            Console.Write(" ");

                        }
                    }
                    



                }

            }

            Console.ReadLine();
        }
    }
}
