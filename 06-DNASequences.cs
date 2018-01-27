using System;
class DNASequence
{
    static void Main()
    {
		{

           
            int sum = int.Parse(Console.ReadLine());
            int count = 0;
            for (int firstLEtter = 1; firstLEtter <= 4; firstLEtter++)
            {
                for (int secondLetter = 1; secondLetter <= 4; secondLetter++)
                {
                    for (int thirdLetter = 1; thirdLetter <= 4; thirdLetter++)
                    {
                        count++;
                        if (firstLEtter + secondLetter + thirdLetter >= sum)
                        {
                            Console.Write("O" + ("" + firstLEtter + secondLetter + thirdLetter).Replace('1', 'A').Replace('2', 'C').Replace('3', 'G').Replace('4', 'T') + "O ");

                            // A  1, C  2, G  3, T  4.
                        }
                        else
                        {
                            Console.Write("X" + ("" + firstLEtter + secondLetter + thirdLetter).Replace('1', 'A').Replace('2', 'C').Replace('3', 'G').Replace('4', 'T') + "X ");
                        }

                        if (count % 4 == 0)
                        {
                            Console.WriteLine();
                        }



                    }
                }
            }

        }
    }
}
