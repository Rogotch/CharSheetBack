namespace CharSheetBack.Structures.ProfBonus
{
    public class ProficiencyBonus
    {
        private int LevelChar;

        public ProficiencyBonus()
        {
        }

        public int Bonus(int level)
        {
            LevelChar = level;
            if (LevelChar > 16)
            {
                return 6;
            }
            else if (LevelChar > 12)
            {
                return 5;
            }
            else if (LevelChar > 8)
            {
                return 4;
            }
            else if (LevelChar > 4)
            {
                return 3;
            }
            else
            {
                return 2;
            }

        }

    }
}