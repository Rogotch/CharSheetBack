using System.Collections.Generic;
using CharSheetBack.Structures.Characteristics;

namespace CharSheetBack.Structures.Skills
{
    public class AllSkills
    {
        public List<Skill> Skills;

        public AllSkills(List<Skill> skills)
        {
            Skills = skills;
        }

        public AllSkills(AllCharacteristics characteristics)
        {
            Skills = new List<Skill>();
            Skills.Add(new Skill(characteristics.Dexterity, "Acrobatics"));
            Skills.Add(new Skill(characteristics.Wisdom, "Animal Handling"));
            Skills.Add(new Skill(characteristics.Intelligence, "Arcana"));
            Skills.Add(new Skill(characteristics.Strength, "Athletic"));
            Skills.Add(new Skill(characteristics.Charisma, "Deception"));
            Skills.Add(new Skill(characteristics.Intelligence, "History"));
            Skills.Add(new Skill(characteristics.Wisdom, "Insight"));
            Skills.Add(new Skill(characteristics.Charisma, "Intimidation"));
            Skills.Add(new Skill(characteristics.Intelligence, "Investigation"));
            Skills.Add(new Skill(characteristics.Wisdom, "Medicine"));
            Skills.Add(new Skill(characteristics.Intelligence, "Nature"));
            Skills.Add(new Skill(characteristics.Wisdom, "Perception"));
            Skills.Add(new Skill(characteristics.Charisma, "Performance"));
            Skills.Add(new Skill(characteristics.Charisma, "Persuasion"));
            Skills.Add(new Skill(characteristics.Intelligence, "Religion"));
            Skills.Add(new Skill(characteristics.Dexterity, "Sleight of Hand"));
            Skills.Add(new Skill(characteristics.Dexterity, "Stealth"));
            Skills.Add(new Skill(characteristics.Wisdom, "Survival"));
        }

        public void ReCalculate(AllCharacteristics characteristics, int profBonus)
        {
            foreach (var _skill in Skills)
            {
                Characteristic mainCharacteristic = characteristics.CharacteristicByType(_skill.Type);
                _skill.ReCalculating(mainCharacteristic, profBonus);
            }
        }
    }
}