using System;

class AddExxObhojdaneSCikyl
{
    static void Main()
    {
        // И двата варианта са верни

        //// обхождаме редовете с два вложени цикъла, ако инпута ни е три и колоните и редовете ще са три, t.e. e квадрат, при неквадрат вторияt цикъл, ще се върти до  row  


        //for (int row = 0; row < input; row++)
        //{
        //    for (int col = 0; col < input; col++)
        //    {


        //        if (col == row)
        //        {
        //            Console.Write("x");
        //        }
        //        else if(col == input - row - 1)// дължината на col става с едно по–малко, защото сме отпечтали първата и стойнос в ifa. Вървят по йерархия if, else if i else
        //        {
        //            Console.Write("x");
        //        }

        //        else
        //        {
        //            Console.Write(" ");
        //        }
        //    }

        //    Console.WriteLine();
        //}

        // инициализираме си броячи
        int num = int.Parse(Console.ReadLine());  
        int left = 0;
        int wright = num - 1;
        for (int row = 0; row < num; row++)
        {
            for (int col = 0; col < num; col++)
            {
                if ((col == left) || (col == wright)) 
                {
                    Console.Write('x');
                }
                else
                {
                    Console.Write(' ');
                }
       
            }

            Console.WriteLine();
            left++;
            wright--; // това са отделни броячи затова с в цикъла
        }
        
    }
}
