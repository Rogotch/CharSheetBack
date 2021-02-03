using CharSheetBack.Enums;

namespace CharSheetBack.Structures.Frequency
{
    /// <summary>
    /// Структура, определяющая частоту использования способности
    /// </summary>
    public class FreqOfUse
    {

        public int Counter
        {
            get;
            private set;

        }
        public RestType Rest
        {
            get;
            private set;

        }
    }
}