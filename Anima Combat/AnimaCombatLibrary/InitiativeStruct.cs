using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimaCombatLibrary
{
    public class InitiativeStruct : IEquatable<InitiativeStruct>, IComparable<InitiativeStruct>
    {
        public string charName;
        public int baseInitiative;
        public int naturaModifier;
        public int rolledInitiative;

        #region Comparison Overloading stuffs
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            InitiativeStruct objAsInitStruct = obj as InitiativeStruct;
            if (objAsInitStruct == null) return false;
            else return Equals(objAsInitStruct);
        }

        // Default comparer for InitiativeStruct type. 
        public int CompareTo(InitiativeStruct compareInit)
        {
            // A null value means that this object is greater. 
            if (compareInit == null)
                return 1;

            else
            {
                int result = -this.rolledInitiative.CompareTo(compareInit.rolledInitiative);
                //Tiebreak using base initiative
                if (result == 0)
                {
                    result = -this.baseInitiative.CompareTo(compareInit.baseInitiative);
                }
                //Then natura
                if (result == 0)
                {
                    result = -this.naturaModifier.CompareTo(compareInit.naturaModifier);
                }
                //Then name
                if (result == 0)
                {
                    result = -this.charName.CompareTo(compareInit.charName);
                }
                return result;
            }
        }
        public override int GetHashCode()
        {
            return charName.GetHashCode();
        }
        public bool Equals(InitiativeStruct other)
        {
            if (other == null) return false;
            return (this.charName.Equals(other.charName) 
                && this.baseInitiative.Equals(other.baseInitiative)
                && this.naturaModifier.Equals(other.naturaModifier)
                && this.rolledInitiative.Equals(other.rolledInitiative));
        }

        public static bool operator ==(InitiativeStruct a, InitiativeStruct b)
        {
            if ((object)a == null || (object)b == null) return false;
            return a.Equals(b);
        }
        public static bool operator !=(InitiativeStruct a, InitiativeStruct b)
        {
            return !(a == b);
        }

        #endregion

        public InitiativeStruct(string name, int baseInit, int naturaMod, int rolledInit = 0)
        {
            charName = name;
            baseInitiative = baseInit;
            naturaModifier = naturaMod;
            rolledInitiative = rolledInit;
        }
    }
}
