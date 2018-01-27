using System;



class VaporStoreFinalEdition
{
    static void Main()
    {
        double balance = double.Parse(Console.ReadLine());
        string gameName = Console.ReadLine();

        double price = 0.0;

        double moneySpent = 0.0;
        string boughtGame = "";

        while (true)
        {

         if (gameName == "OutFall 4")
            {
                boughtGame = gameName;
                price = 39.99;

                if (balance < price)
                {
                    Console.WriteLine("Too Expensive");

                    gameName = Console.ReadLine();
                    continue;
			    }
                else
                {
                    Console.WriteLine("Bought " + boughtGame);
                }

            }
            else if (gameName == "CS: OG")
            {
                boughtGame = gameName;
                price = 15.99;
                if (balance < price)
                {
                    Console.WriteLine("Too Expensive");

                    gameName = Console.ReadLine();
                    continue;
                }
                else
                {
                    Console.WriteLine("Bought " + boughtGame);
                }

            }
            else if (gameName == "Zplinter Zell")
            {
                boughtGame = gameName;
                price = 19.99;
                if (balance < price)
                {
                    Console.WriteLine("Too Expensive");

                    gameName = Console.ReadLine();
                    continue;
                }
                else
                {
                    Console.WriteLine("Bought " + boughtGame);
                }
            }
            else if (gameName == "Honored 2")
            {
                boughtGame = gameName;
                price = 59.99;
                if (balance < price)
                {
                    Console.WriteLine("Too Expensive");

                    gameName = Console.ReadLine();
                    continue;

                }
                else
                {
                    Console.WriteLine("Bought " + boughtGame);
                }
            }
            else if (gameName == "RoverWatch")
            {
                boughtGame = gameName;
                price = 29.99;
                if (balance < price)
                {
                    Console.WriteLine("Too Expensive");

                    gameName = Console.ReadLine();
                    continue;

                }
                else
                {
                    Console.WriteLine("Bought " + boughtGame);
                }

            }
            else if (gameName == "RoverWatch Origins Edition")
            {
                boughtGame = gameName;
                price = 39.99;
                if (balance < price)
                {
                    Console.WriteLine("Too Expensive");

                    gameName = Console.ReadLine();
                    continue;

                }
                else
                {
                    Console.WriteLine("Bought " + boughtGame);
                }
            }

            else if (gameName == "Game Time")
            {

                if (balance > 0)
                {
                    Console.Write($"Total spent: ${moneySpent:F2}. ");
                    Console.WriteLine($"Remaining: ${balance:F2}");
                    break;
                }

                else
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
            }
            else
            {

                {
                    Console.WriteLine("Not Found");
                    gameName = Console.ReadLine();
                    continue;
                }
            }



            gameName = Console.ReadLine();

            balance -= price;
            moneySpent += price;


        }
    }
}
