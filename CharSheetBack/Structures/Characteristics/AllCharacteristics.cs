using System.Collections;
using System.Collections.Generic;
using CharSheetBack.Enums;

namespace CharSheetBack.Structures.Characteristics
{
    public class AllCharacteristics
    {
        public Characteristic Strength;
        public Characteristic Dexterity;
        public Characteristic Constitution;
        public Characteristic Intelligence;
        public Characteristic Wisdom;
        public Characteristic Charisma;

        //public Characteristic[] _allCharacteristics;

        //public Characteristic this[CharacteristicType type]
        //{
        //    get { return _allCharacteristics[(int)type]; }
        //    set { _allCharacteristics[(int)type] = value; }
        //}
        //public Characteristic this[int index]
        //{
        //    get { return _allCharacteristics[index]; }
        //    set { _allCharacteristics[index] = value; }
        //}

        public AllCharacteristics(int STR, int DEX, int CON, int INT, int WIS, int CHA)
        {
            Strength     = new Characteristic(CharacteristicType.Strength,     STR);
            Dexterity    = new Characteristic(CharacteristicType.Dexterity,    DEX);
            Constitution = new Characteristic(CharacteristicType.Constitution, CON);
            Intelligence = new Characteristic(CharacteristicType.Intelligence, INT);
            Wisdom       = new Characteristic(CharacteristicType.Wisdom,       WIS);
            Charisma     = new Characteristic(CharacteristicType.Charisma,     CHA);

        }

        public AllCharacteristics() :
            this(10, 10, 10, 10, 10, 10)
        { }

        public Characteristic CharacteristicByType(CharacteristicType type)
        {
            if (type == CharacteristicType.Wisdom)
            {
                return Wisdom;
            }
            else if (type == CharacteristicType.Charisma)
            {
                return Charisma;
            }
            else if (type == CharacteristicType.Intelligence)
            {
                return Intelligence;
            }
            else if (type == CharacteristicType.Dexterity)
            {
                return Dexterity;
            }
            else if (type == CharacteristicType.Strength)
            {
                return Strength;
            }
            else
            {
                return Constitution;
            }
        }
        //public int Length()
        //{
        //    return _allCharacteristics.Length;
        //}

    }
}