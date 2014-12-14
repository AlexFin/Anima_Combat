using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AnimaRollLibrary;

namespace AnimaCombatLibrary
{
    public class Initiative
    {
        //Rolls all initiatives for a new round
        //TODO: Roll logging
        public static void InitiativeRoll(ref List<InitiativeStruct> initiatives)
        {
            //Roll initiatives
            for (int c = 0; c < initiatives.Count; c++)
            {
                initiatives[c] = new InitiativeStruct(initiatives[c].charName, initiatives[c].baseInitiative, initiatives[c].naturaModifier,
                    //TODO: make the fumble range change if the character has unlucky disad instead of just hardcoded 3
                    initiatives[c].baseInitiative + Roll.OpenRoll(3, initiatives[c].naturaModifier));
            }

            //Sort
            initiatives.Sort();
        }
    }
}
