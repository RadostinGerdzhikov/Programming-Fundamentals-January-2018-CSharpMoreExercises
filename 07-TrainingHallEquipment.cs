using System;

class TrainingHallEquipment
{
    static void Main(string[] args)
    {
       
        double budget = double.Parse(Console.ReadLine());
        int numItems = int.Parse(Console.ReadLine());
        double spentMoney = 0.0;

        for (int i = 1; i <= numItems; i++)
        {
            string itemName = Console.ReadLine();
            double itemPrice = double.Parse(Console.ReadLine());
            int itemCount = int.Parse(Console.ReadLine());

            spentMoney += itemPrice * itemCount;

            if (itemCount < 2)
            {
                Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
            }

            else
            {
                Console.WriteLine($"Adding {itemCount} {itemName}s to cart.");
            }
        }


        if (spentMoney > budget)
        {
            Console.WriteLine($"Subtotal: ${spentMoney:F2}");
            Console.WriteLine($"Not enough. We need ${(spentMoney -budget):F2} more.");

        }
        else
        {
            Console.WriteLine($"Subtotal: ${spentMoney:F2}");
            Console.WriteLine($"Money left: ${(budget - spentMoney):F2}");

        }

    }
}