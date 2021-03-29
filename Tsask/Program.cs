using System;

namespace Tsask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your balance");
            float bal = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter a number");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter a second number");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter a third number");
            float c = float.Parse(Console.ReadLine());

            float d = AddCost(a, b, c);
            Console.WriteLine("Your total is £" + d );

            if (bal < d) 
            {
                Console.WriteLine("Your balance is insuffiencient, transaction canceled");
                Console.WriteLine("Would you like to add to your balance");

                if (YesOrNo(Console.ReadLine()))
                {
                    float amountToAdd = float.Parse(Console.ReadLine());
                    Console.WriteLine(AddBal(bal, amountToAdd));
                }              
                else
                {
                      return;
                }
            }
            else if (bal > d) 
            {
                Console.WriteLine("Transaction Completed. Please collect you items and get the fuck out");
                float newBal = (bal - d);
                Console.WriteLine("Your new balance is  £" + newBal);
            }
        }

        /// <summary>
        /// Adds the user inputs to create a total cost
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static float AddCost(float a, float b , float c)
        {
            return a + b + c;
        
        }

        static float AddBal(float a, float b)
        {
            return a += b; 
        }

        static bool YesOrNo(string pUserInput)
        {
            switch (pUserInput.ToLower())
            {
                case "yes":
                    return true;
                case "no":
                    return false;
                default:
                    return false;                  
            }
        }
    }
}