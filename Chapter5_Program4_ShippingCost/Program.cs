using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5_Program4_ShippingCost
{
    class Program
    {
        static void Main(string[] args)
        {
            double shippingCosts = GetDouble("Shipping Costs");
            double charge = CalculateCharges(shippingCosts);
            Console.WriteLine("\nThe cost of the purchases is {0:C}\nThe cost of the shipping is {1:C}\nThe combined cost is {2:C}", shippingCosts, charge, shippingCosts + charge);
            Console.ReadLine();

        }
        public static double GetDouble(string inputmessage)
        {
            Console.Write("Please enter your {0}: ", inputmessage);
            string input = Console.ReadLine();
            double convertedInput = Convert.ToDouble(input);
            return convertedInput;
        }

        public static double CalculateCharges(double costs)
        {
            double charge = 0;
            if (costs >= 0 && costs <= 250)
            {
                charge = 5.00;
            }
            else if (CheckCostRanges(costs, 250.01, 500))
            {
                charge = 8.00;
            }
            else if (CheckCostRanges(costs, 500.01, 1000))
            {
                charge = 10.00;
            }
            else if (CheckCostRanges(costs, 1000.01, 5000))
            {
                charge = 15.00;
            }
            else if (costs > 5000.01)
            {
                charge = 20.00;
            }

            return charge;
        }

        public static bool CheckCostRanges(double costs, double starting, double ending)
        {
            return costs > starting && costs <= ending;
        }
    }
}
