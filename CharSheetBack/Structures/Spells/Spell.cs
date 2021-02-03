using System;
using CharSheetBack.Enums;

namespace CharSheetBack.Structures.Spells
{
    public class Spell
    {
        public int index { get; set; }
        public int Level { get; set; }
        public string Text { get; set; }
        public string Area { get; set; }
        public string Range { get; set; }
        public string Target { get; set; }
        public string TimeCast { get; set; }
        public string MaterialComponents { get; set; }
        public Components[] Components { get; set; }
    }
}