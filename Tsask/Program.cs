using System;
using System.Collections.Generic;
using System.IO;

namespace Tsask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mIterations = new List<string> { "cost of the first item", "cost of the second item", "cost of the third item" };
            List<float> mListOfFloats = new List<float> { };
            float mBalance = 0f;

            {
                List<string> mTempList = new List<string> { "balance" };
                mBalance = getAllValues(mTempList)[0];
            }

            while (YesOrNo("Would you like to play, 'get broke or get some expansion packets?'")) // This cannot be real. I am shaking and crying right now!
            {
                mListOfFloats = getAllValues(mIterations);
                float mFinalCost = 0f;
                foreach (float cost in mListOfFloats)
                {
                    mFinalCost = AddCost(mFinalCost, cost);
                }
                Console.WriteLine("Your total is £" + mFinalCost);

                switch (lessThanBalance(mBalance, mFinalCost))
                {
                    case false: // Not enough :( Broke ass straggot (Cannot afford the expansion packets!)
                        Console.WriteLine("Your balance is insuffiencient, transaction canceled");
                        if (YesOrNo("Would you like to add to your balance?"))
                        {
                            Console.WriteLine("Please enter a valid number.");
                            float amountToAdd = float.Parse(Console.ReadLine());
                            mBalance = AddBal(mBalance, amountToAdd);
                            Console.WriteLine(mBalance);
                        }
                        break;
                    case true: // Enough money (Could afford the expasion packets)
                        Console.WriteLine("Transaction Completed. Please collect you items and get the fuck out, You are gay now btw"); // Bit rude, ngl!
                        mBalance = mBalance - mFinalCost; // Whats all this coding jargon then???
                        Console.WriteLine("Your new balance is  £" + mBalance); // Console.GetSomeBitches();
                        break; // break into the cum method 
                               // Jarvis, open the cum method!
                }
            }
        }

        /// <summary>
        /// cum.txt
        /// </summary>
        /// <param name="pBalance">cum.txt</param>
        /// <param name="pTotalCost">cum.txt</param>
        /// <returns>cum.txt</returns>
        static bool lessThanBalance(float pBalance, float pTotalCost)
        {
            if (pBalance >= pTotalCost) // I have no idea how this got here
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static List<float> getAllValues(List<string> pIterations)
        {
            List<float> mTempList = new List<float> { };
            foreach (string iterations in pIterations)
            {
                mTempList.Add(getUserInput(iterations));
            }
            return mTempList;
        }


        static float getUserInput(string pNumberIteration)
        {
            Console.WriteLine("Please enter the " + pNumberIteration);
            string mTemp = Console.ReadLine();

            try
            {
                return float.Parse(mTemp);
            }
            catch
            {
                Console.WriteLine("The number you have entered is invalid!");
                Console.WriteLine("Please try again!");
                return getUserInput(pNumberIteration);
            }
        }

        /// <summary>
        /// Adds the user inputs to create a total cost
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static float AddCost(float mCurrentCost, float mNewValue)
        {
            return (mCurrentCost + mNewValue);
        }



        /// <summary>
        /// Adds money to the balance.
        /// </summary>
        /// <param name="a">Balance</param>
        /// <param name="b">Money to add</param>
        /// <returns>Float</returns>
        static float AddBal(float a, float b)
        {
            return a += b;
        }

        /// <summary>
        ///  Returns a Bool based on Char input
        /// </summary>
        /// <param name="pUserInput"></param>
        /// <returns>Bool</returns>/
        static bool YesOrNo(string pQuestion)
        {
            if (GetYesOrNo(pQuestion) == 'y')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Returns a Char
        /// </summary>
        /// <param name="pQuestion">Question to be asked</param>
        /// <returns>Char</returns>
        static char GetYesOrNo(string pQuestion)
        {
            bool ValidInput = false;
            char UserInput = 'A';
            do
            {
                try
                {
                    Console.WriteLine(pQuestion + " Y / N");
                    UserInput = char.Parse(Console.ReadLine().ToLower());

                    if (UserInput == 'y' || UserInput == 'n')
                    {
                        ValidInput = true;
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter a valid char");
                }

            } while (!ValidInput);
            return UserInput;
        }



    }
}





























































































































