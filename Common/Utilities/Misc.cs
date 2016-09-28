using System;
using MultiLearn.Data;

namespace MultiLearn.Utilities
{
    public static class Misc
    {
        private static Random _random;

        public static void Initialize()
        {
            Misc._random = new Random();
        }

        public static int NextRand(int max)
        {
            return Misc._random.Next(max);
        }

        public static string ExtensionForQuestionSetType(QuestionSetType type)
        {
            switch (type)
            {
                case QuestionSetType.Spelling:
                    return Constants.MultiSpell.Extension;
                case QuestionSetType.Math:
                    return Constants.MultiMath.Extension;
                case QuestionSetType.MultipleChoice:
                    return Constants.MultiChoice.Extension;
            }
            return string.Empty;
        }
    }
}
