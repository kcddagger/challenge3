using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge3
{
    class Challenge_3
    {
        static void Main(string[] args)
        {
            string n;
            string strLN;
            int lN;

            Console.WriteLine("Enter a number 1-9");
            n = Console.ReadLine();
            strLN = largestNumber(n);

            if (int.TryParse(strLN, out lN))
            {
                Console.WriteLine(lN);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(strLN);
                Console.ReadLine();
            }
        }

        private static string largestNumber(string n)
        {
            int num;
            string strLNum = "";

            if ((int.TryParse(n, out num)) && (num > 0 && num <= 9))
            {
                for (int i = 0; i < num; i++)
                {
                    strLNum += "9";
                }
                return strLNum;
            }
            else
            {
                return "Invalid input.  Please restart the program and enter in a number 1-9";
            }
        }
    }
}
