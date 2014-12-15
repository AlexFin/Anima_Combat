using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLibrary
{
    public class Character
    {
        public string Name { get; set; }
        public bool IsPlayer { get; set; }

        #region Core Stats
        public int BaseAGI { get; set; }
        public int AGIModifier { get; set; }
        public int ActualAGI
        {
            get { return BaseAGI + AGIModifier; }
            set { AGIModifier = value - BaseAGI; }
        }

        public int BaseCON { get; set; }
        public int CONModifier { get; set; }
        public int ActualCON
        {
            get { return BaseCON + CONModifier; }
            set { CONModifier = value - BaseCON; }
        }

        public int BaseDEX { get; set; }
        public int DEXMOdifier { get; set; }
        public int ActualDEX
        {
            get { return BaseDEX + DEXMOdifier; }
            set { DEXMOdifier = value - BaseDEX; }
        }
        public int BaseSTR { get; set; }
        public int STRModifer { get; set; }
        public int ActualSTR
        {
            get { return BaseSTR + STRModifer; }
            set { STRModifer = value - BaseSTR; }
        }

        public int BaseINT { get; set; }
        public int IntTemp { get; set; }
        public int ActualINT
        {
            get { return BaseINT + IntTemp; }
            set { IntTemp = value - BaseINT; }
        }

        public int BasePER { get; set; }
        public int PerTemp { get; set; }
        public int PerceptionActual
        {
            get { return BasePER + PerTemp; }
            set { PerTemp = value - BasePER; }
        }

        public int PowerBase { get; set; }
        public int PowerTemp { get; set; }
        public int PowerActual
        {
            get { return PowerBase + PowerTemp; }
            set { PowerTemp = value - PowerBase; }
        }

        public int WillpowerBase { get; set; }
        public int WillpowerTemp { get; set; }
        public int WillpowerActual
        {
            get { return WillpowerBase + WillpowerTemp; }
            set { WillpowerTemp = value - WillpowerBase; }
        }

        int GetBonus(int stat)
        {
            switch (stat)
            {
                case 1:
                    return -30;
                case 2:
                    return -20;
                case 3:
                    return -10;
                case 4:
                    return -5;
                case 5:
                    return 0;
                case 6:
                case 7:
                    return 5;
                case 8:
                case 9:
                    return 10;
                case 10:
                    return 15;
                case 11:
                case 12:
                    return 20;
                case 13:
                case 14:
                    return 25;
                case 15:
                    return 30;
                case 16:
                case 17:
                    return 35;
                case 18:
                case 19:
                    return 40;
                case 20:
                    return 45;
                default:
                    //TODO: Error handling
                    return 0;
            }
        }

        int AgilityBonus
        {
            get
            {
                return GetBonus(ActualAGI);
            }
        }
        int ConstitutionBonus
        {
            get
            {
                return GetBonus(ActualCON);
            }
        }
        int DexterityBonus
        {
            get
            {
                return GetBonus(ActualDEX);
            }
        }
        int StrengthBonus
        {
            get
            {
                return GetBonus(ActualSTR);
            }
        }
        int IntelligenceBonus
        {
            get
            {
                return GetBonus(ActualINT);
            }
        }
        int PerceptionBonus
        {
            get
            {
                return GetBonus(PerceptionActual);
            }
        }
        int PowerBonus
        {
            get
            {
                return GetBonus(PowerActual);
            }
        }
        int WillpowerBonus
        {
            get
            {
                return GetBonus(WillpowerActual);
            }
        }
        #endregion

        #region Resistances
        public int Presence {
            get 
            {
                if(Level < 1)
                {
                    return 20;
                }
                
                return 25 + Level*5;
            } 
        }

        public int PhysicalResistModifier { get; set; }
        public int PhysicalResist
        {
            get { return Presence + ConstitutionBonus + PhysicalResistModifier; }
            set { PhysicalResistModifier = value - (Presence + ConstitutionBonus);  }
        }
        public int DiseaseResistModifier { get; set; }
        public int DiseaseResist
        {
            get { return Presence + ConstitutionBonus + DiseaseResistModifier; }
            set { DiseaseResistModifier = value - (Presence + ConstitutionBonus); }
        }
        public int PoisonResistModifier { get; set; }
        public int PoisonResist
        {
            get { return Presence + ConstitutionBonus + PoisonResistModifier; }
            set { PoisonResistModifier = value - (Presence + ConstitutionBonus); }
        }
        public int MagicResistModifier { get; set; }
        public int MagicResist
        {
            get { return Presence + PowerBonus + MagicResistModifier; }
            set { MagicResistModifier = value - (Presence + PowerBonus); }
        }
        public int PsychicResistModifier { get; set; }
        public int PsychicResist
        {
            get { return Presence + WillpowerBonus + PsychicResistModifier; }
            set { PsychicResistModifier = value - (Presence + WillpowerBonus); }
        }
        #endregion

        public int Level { get; set; }
        public int HPMax { get; set; }
        public int HPCurrent { 
            get;
            set
            {
                HPCurrent = value;
                if (HPCurrent > HPMax)
                {
                    HPCurrent = HPMax;
                }
            }
        }
        public int ZeonMax { get; set; }
        public int ZeonCurrent { 
            get;
            set 
            { 
                ZeonCurrent = value;
                if (ZeonCurrent > ZeonMax)
                {
                    ZeonCurrent = ZeonMax;
                }
            } 
        }
        public int FatigueMax { get; set; }
        public int FatigueCurrent { 
            get;
            set
            {
                FatigueCurrent = value;
                if (FatigueCurrent > FatigueMax)
                {
                    FatigueCurrent = FatigueMax;
                }
            }
        }
        //TODO: Armor
        public int DamageBarrier { get; set; }
    }
}
