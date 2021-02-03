using System;
using CharSheetBack.Enums;

namespace CharSheetBack.Structures.Characteristics
{
    public class Characteristic
    {
        public CharacteristicType Type;
        public int BaseScore;
        public double Mod;
        public int RacialBonus;
        public int OtherModifier;
        public bool SavingThrow;

        public Characteristic(CharacteristicType type, int score, int rBonus, int oModifier, bool saving)
        {
            Type = type;
            BaseScore = score;
            RacialBonus = rBonus;
            OtherModifier = oModifier;
            SavingThrow = saving;
            Mod = 0;
            Mod = CalculateMood(BaseScore, RacialBonus, OtherModifier);

        }
        public Characteristic(CharacteristicType type, int score): 
            this(type, score, 0, 0, false)
        { }

        public void Up()
        {
            this.BaseScore = BaseScore + 1;
            Mod = CalculateMood(BaseScore, RacialBonus, OtherModifier);

        }
        public void Down()
        {
            this.BaseScore = BaseScore - 1;
            Mod = CalculateMood(BaseScore, RacialBonus, OtherModifier);

        }

        private double CalculateMood(int baseScore, int racialBonus, int otherModifier)
        {
            double mod;
            if (BaseScore + RacialBonus + OtherModifier > 10)
                mod = Math.Floor((double) (baseScore + racialBonus + otherModifier - 10) / (double) 2);

            else
                mod = Math.Round((double) (baseScore + racialBonus + otherModifier - 10) / (double) 2,
                    MidpointRounding.AwayFromZero);
            return mod;
        }

        public int GetTotalScore()
        {
            return BaseScore + RacialBonus + OtherModifier;
        }
    }
}