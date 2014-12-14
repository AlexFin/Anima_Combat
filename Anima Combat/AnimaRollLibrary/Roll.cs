using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimaRollLibrary
{
    public class Roll
    {
        #region Static Functions
        //Rolls nDx
        public static int DiceRoll(int number, int size)
        {
            Random rand = new Random();
            int sum = 0;

            for (int c = 0; c < number; c++)
            {
                sum += (1 + rand.Next(size));
            }

            return sum;
        }

        //Rolls 1Dx
        public static int DiceRoll(int size)
        {
            return DiceRoll(1, size);
        }

        #region OpenRoll helper functions
        //Checks for 'normal' open rolls
        private static bool IsOpen(int number, int consecutiveCrits, int naturaModifier)
        {
            if (naturaModifier < 5)
            {
                if (consecutiveCrits == 0 && number >= 90)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            int critRange = 90 + consecutiveCrits;

            if (critRange > 100)
            {
                critRange = 100;
            }

            if (number >= critRange)
            {
                return true;
            }

            return false;
        }

        //Checks for the overpowered 'doubles' rule at naturaModifier 15+
        private static bool IsOP(int number, int naturaModifier)
        {
            if (naturaModifier < 15)
            {
                return false;
            }

            if (number / 10 == number % 10)
            {
                return true;
            }

            return false;
        }
        #endregion

        //Rolls 1d100 with open rolls
        //TODO: add roll logging argument
        public static int OpenRoll(int failRange, int naturaModifier = 0)
        {
            int result = 0;

            result = DiceRoll(100);
            //Critical fail
            if (result < failRange)
            {
                if (result == 1)
                {
                    return -DiceRoll(100) - 15;
                }
                else if (result == 2)
                {
                    return -DiceRoll(100);
                }
                else
                {
                    return 15 - DiceRoll(100);
                }
            }
            else
            {
                int total = 0;
                int openRolls = 0;
                bool done = false;
                while (!done)
                {
                    total += result;
                    if(IsOpen(result, openRolls, naturaModifier)) 
                    {
                        openRolls++;
                    } 
                    //If you didn't open roll and your not OverPowered (rolled doubles w/ high natura), you are done
                    else if(!IsOP(result, naturaModifier)) 
                    {
                        done = true;
                    }

                    result = DiceRoll(100);
                }
                return total;
            }
        }

        //Rolls 1d10 with crit success/fail
        static int StatRoll()
        {
            int result = DiceRoll(10);

            if (result == 1)
            {
                return -3;
            }

            if (result == 10)
            {
                return 13;
            }

            return result;
        }
        #endregion
    }
}
