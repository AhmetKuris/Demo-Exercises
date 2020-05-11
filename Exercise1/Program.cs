using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;

            var N = 0;
            var M = 0;

            Console.WriteLine("Please Enter a value for the N(The length of the A array:");
            N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter a value for the M(The length of the B array:");
            M = Convert.ToInt32(Console.ReadLine());

            int[] A = new int[N];
            int[] B = new int[M];
            List<int> C=new List<int>();

            Console.WriteLine(N+" integer numbers are needed for the A array:");
            for (int i = 0; i <N; i++)
            {
               A[i] = Convert.ToInt32(Console.ReadLine());
            } 
            
            Console.WriteLine(M+ " integer numbers are needed for the A array:");
            for (int i = 0; i <M; i++)
            {
               B[i] = Convert.ToInt32(Console.ReadLine());
            }


            //Main logic block

            for (int i = 0; i < M; i++)
            {
                if (C.Contains(B[i]))
                {
                    count = -1;

                }
                else
                {
                    for (int j = 0; j < N; j++)
                    {

                        if (B[i] == A[j])
                        {

                            count++;

                            if (count >= 2)
                            {
                                C.Add(B[i]);
                            }

                        }


                    }
                }
                    
                    
                Console.WriteLine("You have "+ count + " numbers in A array from B array's "+ i +" indexed number.");
                    
                count = 0;
            }

            Console.ReadLine();
        }





    }
}

