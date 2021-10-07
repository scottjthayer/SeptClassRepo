using System;
using System.Collections.Generic;
using System.Text;

namespace Casino_Dice_Roller
{
    class DiceRollerApp
    {
        public static void DisplayCombinations(int num1, int num2)
        {
            //dice combos
            if (num1 == 1 && num2 == 1)
            {
                Console.WriteLine(combinations.Snake_Eyes);
            }
            else if (num1 == 1 && num2 == 2)
            {
                Console.WriteLine(combinations.Ace_Deuce);
            }
            else if (num1 == 2 && num2 == 1)
            {
                Console.WriteLine(combinations.Ace_Deuce);
            }
            else if (num1 == 6 && num2 == 6)
            {
                Console.WriteLine(combinations.Box_Cars);
            }

            //dice totals
            int total = num1 + num2;
            if (total == 7 || total == 11)
            {
                Console.WriteLine(combinations.Win);
            }
            else if (total == 2 || total == 3 || total == 12)
            {
                Console.WriteLine(combinations.Craps);
            }

        }
    }
}
