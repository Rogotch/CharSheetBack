using CharSheetBack.Enums;

namespace CharSheetBack.Structures.Defenses
{
    public class Defense
    {
        public DefensesType Type;
        public DamageType Damage;

        public Defense(DefensesType type, DamageType damage)
        {
            Type = type;
            Damage = damage;
        }
    }
}