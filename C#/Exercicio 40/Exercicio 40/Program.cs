/*

Given the menu of a snack bar:

Code    Product	        Price
100	    Hot Dog	        1.20
101	    Plain Bauru	    1.30
102	    Bauru with Egg	1.50
103	    Hamburger	    1.20
104	    Cheeseburger	1.30
105	    Soda	        1.00

Create an algorithm that reads the product code and the quantity the customer wants to purchase.
The customer can buy more than one product; ask if they wish to continue shopping.
Calculate the total amount to be paid for each product and the total value of the purchase.



*/

using System;

namespace Exercicio40
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal priceTotal;
            int code, loopNum;
            char exit = 'Y';
            priceTotal = loopNum = 0;

            Console.WriteLine(@"Code    Product	    Price
100	Hot Dog	        1.20
101	Plain Bauru	    1.30
102	Bauru with Egg  1.50
103	Hamburger	    1.20
104	Cheeseburger    1.30
105	Soda	        1.00");


            while (exit != 'N')
            {
                do
                {
                    Console.WriteLine("What would you like to order [CODE product]");
                    code = Convert.ToInt32(Console.ReadLine());
                }
                while (code < 100 || code > 105);
                
                if (loopNum == 0)
                {
                    switch (code)
                    {
                        case 100:
                            priceTotal += Convert.ToDecimal(1.20);
                            break;
                        case 101:
                            priceTotal += Convert.ToDecimal(1.30);
                            break;
                        case 102:
                            priceTotal += Convert.ToDecimal(1.50);
                            break;
                        case 103:
                            priceTotal += Convert.ToDecimal(1.20);
                            break;
                        case 104:
                            priceTotal += Convert.ToDecimal(1.30);
                            break;
                        case 105:
                            priceTotal += Convert.ToDecimal(1);
                            break;

                    }
                    Console.WriteLine("Would you like to order more ? [Y / N]");
                    exit = Convert.ToChar(Console.ReadLine());
                    exit = Char.ToUpper(exit);
                }
                else
                {
                   

                    switch (code)
                    {
                        case 100:
                            priceTotal += Convert.ToDecimal(1.20);
                            break;
                        case 101:
                            priceTotal += Convert.ToDecimal(1.30);
                            break;
                        case 102:
                            priceTotal += Convert.ToDecimal(1.50);
                            break;
                        case 103:
                            priceTotal += Convert.ToDecimal(1.20);
                            break;
                        case 104:
                            priceTotal += Convert.ToDecimal(1.30);
                            break;
                        case 105:
                            priceTotal += Convert.ToDecimal(1);
                            break;

                    }
                    Console.WriteLine("Would you like to order more ? [Y / N]");
                    exit = Convert.ToChar(Console.ReadLine());
                    exit = Char.ToUpper(exit);
                }



            }

            Console.WriteLine($"The total price is {priceTotal}");

           
            
        }
    }
}