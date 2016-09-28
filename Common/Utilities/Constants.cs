using System.Drawing;

namespace MultiLearn
{
    public static class Constants
    {
        public sealed class Directories
        {
            public static string Temp = "tmp";
            public static string Sets = "sets";
        }

        public sealed class Statistics
        {
            public static string ChartSeriesName = "data";
        }

        public sealed class Files
        {
            public static string MetaDataXML = "metadata.xml";
        }

        public sealed class Keypad
        {
            public static Color[] DefaultColors = new Color[] { Color.FromArgb(255, 0, 63, 224), Color.FromArgb(255, 47, 224, 0), Color.FromArgb(255, 224, 0, 224), Color.FromArgb(255, 255, 216, 0) };
        }

        public sealed class MultiMath
        {
            public static int[] AScale = { 5, 15, 25, 25, 25, 30, 30 };
            public static int[] OperandScale = { 2, 2, 3, 3, 3, 3, 3 };
            public static int[] BScale = { 5, 15, 20, 25, 25, 25, 30 };
            public static int[] MinValue = { 1, 3, 6, 6, 9, 12, 15 };
            public static int DivisionScaling = 5;

            public static int Target = 12;

            public static string TypeIdentifier = "MultiMath";
            public static string Extension = "mlmx";
        }

        public sealed class MultiSpell
        {
            public static char[] LetterBag =
            { 'a', 'a', 'a', 'b', 'c', 'd', 'd', 'e', 'e', 'e', 'e',
              'f', 'g', 'h', 'h', 'i', 'i', 'i', 'j', 'k', 'l', 'm',
              'n', 'n', 'n', 'o', 'o', 'o', 'p', 'q', 'r', 'r', 's',
              's', 't', 't', 't', 'u', 'u', 'v', 'w', 'x', 'y', 'z' };

            public static int Target = 12;

            public static string TypeIdentifier = "MultiSpell";
            public static string Extension = "mlsx";
        }

        public sealed class MultiChoice
        {
            public static string TypeIdentified = "MultiChoice";
            public static string Extension = "mlcx";
        }
    }
}
