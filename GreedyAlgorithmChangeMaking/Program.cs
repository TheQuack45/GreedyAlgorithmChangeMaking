using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedyAlgorithmChangeMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variable declarations
            decimal total;
            #endregion

            #region Initial variable assignments
            List<decimal> denominationsList = new List<decimal>()
            {
                0.25m,
                0.1m,
                0.05m,
                0.01m,
            };
            List<int> denominationsCountList = new List<int>()
            {
                0,
                0,
                0,
                0,
            };
            int denominationsListIndex = 0;
            #endregion

            // Get input from user
            Console.WriteLine("What amount of money to make change for?");
            total = decimal.Parse(Console.ReadLine());

            #region Algorithm logic
            do
            {
                if (total >= denominationsList[denominationsListIndex])
                {
                    total -= denominationsList[denominationsListIndex];
                    denominationsCountList[denominationsListIndex]++;
                }
                else
                {
                    denominationsListIndex++;
                }
            } while (total > 0);
            #endregion

            // Result output
            Console.WriteLine("Coins used: ");
            for (int i = 0; i < denominationsList.Count; i++)
            {
                Console.WriteLine(denominationsList[i] + " Coins: " + denominationsCountList[i]);
            }

            Console.ReadKey();
        }
    }
}
