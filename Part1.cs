using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Project Name: A2PMKKSF2P1 
 *File Name: Part1.cs
 *Description: Calculating the Grocery Bill 
 *
 *Revision History:
 *  Meet Patel, Kiana Karamouz, Fenil Kiritbhai Sukhadiya, 2021.02.24, Section 2: Created  
 *  
*/
namespace A2PMKKSF2P1
{
    class Part1
    {
        static void Main(string[] args)
        {
            // Step 1:
            Console.Write("Enter the Registered Month: ");
            string registeredMonth = Console.ReadLine();
            Console.Write("Enter the Customer Membership Number: ");
            int membershipNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of item Purchased: ");
            int itemPurchased = int.Parse(Console.ReadLine());
            Console.Write("Enter Total cost before Taxes: ");
            double totalCost = double.Parse(Console.ReadLine());

            // Step 2:
            double itemDiscount = 0, priceDiscount = 0, finalCost = totalCost;
            if (itemPurchased > 7 && itemPurchased < 10)
            {
                itemDiscount = -30;
            }
            else if (itemPurchased >= 10)
            {
                itemDiscount = -(totalCost * 0.5);
            }
            finalCost += itemDiscount;

            if (totalCost > 200)
            {
                priceDiscount = -(finalCost * 0.1);
            }
            else if (totalCost < 50)
            {
                priceDiscount = -3;
            }
            else
            {
                Console.WriteLine("No discount");
            }
            finalCost+=priceDiscount;

            //step 3: 
            double monthDiscount = 0;
            switch (registeredMonth)
            {
                //month between January and April, subtract $12 from the total cost
                case "january":
                case "february":
                case "march":
                case "april":
                    monthDiscount = - 12;
                    break;

                //the month is May, add $5 to final cost
                case "may":
                    monthDiscount = + 5;
                    break;

                //all other months (i.e., June to December), subtract $1.00 from the total cost
                default:
                     monthDiscount = - 1;
                    Console.WriteLine("Invalid Month");
                    break;
            }
            finalCost+=monthDiscount;

            //Step 4:
            double finalAmount = finalCost + (finalCost * 0.15);

            //Step 5:
            if (finalAmount < 20)
            {
                finalAmount = 0;
            }
            Console.Clear();
            // Final Bill: 
            Console.WriteLine($"Membership number: {membershipNumber}");
            Console.WriteLine($"Total Items: {itemPurchased}");
            Console.WriteLine($"Total Cost before adjustment: {totalCost}$");
            Console.WriteLine($"Total Discount of adjustment: {itemDiscount}$");
            Console.WriteLine($"Total Discount of specific months:{monthDiscount}$");
            Console.WriteLine($"Final Cost: {finalAmount}$");
            Console.ReadLine();
        }
    }
}
