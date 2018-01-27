using System;

class SmsTypingByMeFinalDestination
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        string finalRezult = string.Empty;

        for (int timesLoop = 0; timesLoop < num; timesLoop++)
        {

            string digits = Console.ReadLine();

            int mainDigit = int.Parse(digits[0].ToString());
            int offset = (mainDigit - 2) * 3;

            if ((mainDigit == 8) || (mainDigit == 9)) 
            {

                offset++;
            }

            int leeterIndex = offset + digits.Length - 1;


            if (mainDigit == 0)
            {
                finalRezult += " ";
            }
            else
            {

                finalRezult += (char)(97 + leeterIndex);
            } 

        }
        Console.WriteLine(finalRezult);

    }
}

