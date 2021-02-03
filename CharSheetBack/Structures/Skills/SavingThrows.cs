using CharSheetBack.Structures.Characteristics;

namespace CharSheetBack.Structures.Skills
{
    public class SavingThrows
    {
        public Skill SaveStrength;
        public Skill SaveDexterity;
        public Skill SaveConstitution;
        public Skill SaveIntelligence;
        public Skill SaveWisdom;
        public Skill SaveCharisma;

        public SavingThrows(AllCharacteristics characteristics)
        {
            SaveCharisma = new Skill(characteristics.Charisma, "CHA");
            SaveWisdom = new Skill(characteristics.Wisdom, "WIS");
            SaveIntelligence = new Skill(characteristics.Intelligence, "INT");
            SaveConstitution = new Skill(characteristics.Constitution, "CON");
            SaveDexterity = new Skill(characteristics.Dexterity, "DEX");
            SaveStrength = new Skill(characteristics.Strength, "STR");
        }
    }
}