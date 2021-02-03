using System;
using CharSheetBack.Enums;
using CharSheetBack.Structures.Characteristics;

namespace CharSheetBack.Structures.Skills
{
    public class Skill
    {
        public Characteristic MainCharacteristic;
        public CharacteristicType Type;
        public Proficiency Prof;
        public string SkillName;
        public int ProfBonus;
        public double Bonus;

        public Skill(Characteristic mainCharacteristic, string skillName, int profBonus, Proficiency prof)
        {
            MainCharacteristic = mainCharacteristic;
            Type = mainCharacteristic.Type;
            Prof = prof;
            ProfBonus = profBonus;
            SkillName = skillName;
            Bonus = 0;
            Bonus = CalculateBonus(prof);
        }

        public Skill(Characteristic mainCharacteristic, string skillName, int profBonus) :
            this(mainCharacteristic, skillName, profBonus, Proficiency.NotProficient)
        { }
        public Skill(Characteristic mainCharacteristic, string skillName, Proficiency prof) :
            this(mainCharacteristic, skillName, 0, prof)
        { }
        public Skill(Characteristic mainCharacteristic, string skillName) :
            this(mainCharacteristic, skillName, 0, Proficiency.NotProficient)
        { }

        private double CalculateBonus(Proficiency prof)
        {
            double modifier = 0;
            switch (prof)
            {
                case Proficiency.NotProficient:
                    modifier = 0;
                    break;
                case Proficiency.HalfProficient:
                    modifier = 0.5;
                    break;
                case Proficiency.Proficient:
                    modifier = 1;
                    break;
                case Proficiency.Expertise:
                    modifier = 2;
                    break;
            }

            return Math.Floor(MainCharacteristic.Mod + (modifier * ProfBonus));
        }

        public void ChangeProf(Proficiency prof)
        {
            Bonus = CalculateBonus(prof);
        }

        public void ReCalculating(Characteristic ch, int profBonus)
        {
            MainCharacteristic = ch;
            ProfBonus = profBonus;
            Bonus = CalculateBonus(Prof);
        }
    }
}