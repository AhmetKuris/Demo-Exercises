using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {


            int randomNumber = GenerateDistinctRandomNumber();

            int[] arrayOfRandomNumber = GetIntArray(randomNumber);

            Console.WriteLine("Try to find 4 digit distinct number, you have 8 rights for each! ");

            Console.WriteLine(randomNumber);

            int countTurn = 0;
            for (int i = 0; i < 16; i++) //8 rights
            {
                if (countTurn%2==0)
                {
                    int countContains = 0;
                    int countCorrect = 0;
                    int countWrong = 0;

                    Console.WriteLine("Player1:");
                    int guess = Convert.ToInt32(Console.ReadLine());

                    int[] arrayOfGuessedNumber = GetIntArray(guess);

                    for (int j = 0; j < 4; j++)
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            if (arrayOfGuessedNumber[j] == arrayOfRandomNumber[k])
                            {
                                countContains++;

                            }
                        }

                        if (arrayOfGuessedNumber[j] == arrayOfRandomNumber[j])
                        {
                            countCorrect++;
                        }

                        countWrong = countContains - countCorrect;
                    }

                    Console.WriteLine(countCorrect + " numbers are well placed " + countWrong + " numbers are wrong placed");

                    if (countCorrect == 4)
                    {
                        Console.WriteLine("Congratulations you guessed it correct! Player1 wins!");
                        break;
                    }

                    countTurn++;
                }

                else
                {
                    
                    int countContains = 0;
                    int countCorrect = 0;
                    int countWrong = 0;

                    Console.WriteLine("Player2:");
                    int guess = Convert.ToInt32(Console.ReadLine());

                    int[] arrayOfGuessedNumber = GetIntArray(guess);

                    for (int j = 0; j < 4; j++)
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            if (arrayOfGuessedNumber[j] == arrayOfRandomNumber[k])
                            {
                                countContains++;

                            }
                        }

                        if (arrayOfGuessedNumber[j] == arrayOfRandomNumber[j])
                        {
                            countCorrect++;
                        }

                        countWrong = countContains - countCorrect;
                    }

                    Console.WriteLine(countCorrect + " numbers are well placed " + countWrong + " numbers are wrong placed");

                    if (countCorrect == 4)
                    {
                        Console.WriteLine("Congratulations you guessed it correct! Player2 wins!");
                        break;
                    }

                    countTurn++;
                }

            }

            Console.ReadLine();



            int GenerateRandomNumber()
            {
                Random random = new Random();

                int randomNum = random.Next(1000, 9999);

                return randomNum;

            }

            //Make sure numbers are distinct
            int GenerateDistinctRandomNumber()
            {

                int randomNum = 0;
                var hashSet = new HashSet<int>();

                int randomNumForLoop = GenerateRandomNumber();

                int[] testArray = GetIntArray(randomNumForLoop);

                for (int i = 0; i < 4; i++)
                {

                    if (testArray.GroupBy(x => x).Any(g => g.Count() > 1))
                    {
                        randomNumForLoop = GenerateRandomNumber();
                        testArray = GetIntArray(randomNumForLoop);
                        i = 0;
                    }

                    randomNum = randomNumForLoop;

                }

                return randomNum;

            }




            //Convert int number to an array.
            int[] GetIntArray(int num)
            {
                List<int> tempList = new List<int>();

                while (num > 0)
                {
                    tempList.Add(num % 10);
                    num = num / 10;

                }

                tempList.Reverse();
                return tempList.ToArray();

            }


        }


    }
}
