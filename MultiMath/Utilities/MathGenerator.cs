using System;
using MultiLearn.Data;

namespace MultiLearn.Utilities
{
    public static class MathGenerator
    {

        public static MathQuestion GenerateQuestion(int level)
        {
            level = Math.Max(level, 0);
            int operand = Misc.NextRand(Constants.MultiMath.OperandScale[Math.Min(level, Constants.MultiMath.OperandScale.Length - 1)]);
            switch (operand)
            {
                case 0:
                    return new MathQuestion(Misc.NextRand(Constants.MultiMath.AScale[Math.Min(level, Constants.MultiMath.AScale.Length)]) + Constants.MultiMath.MinValue[Math.Min(level, Constants.MultiMath.MinValue.Length)],
                                            Operand.Add,
                                            Misc.NextRand(Constants.MultiMath.BScale[Math.Min(level, Constants.MultiMath.BScale.Length)]) + Constants.MultiMath.MinValue[Math.Min(level, Constants.MultiMath.MinValue.Length)]);
                case 1:
                    int a = 0, b = 0;
                    while (a <= b)
                    {
                        a = Misc.NextRand(Constants.MultiMath.AScale[Math.Min(level, Constants.MultiMath.AScale.Length)]) + Constants.MultiMath.MinValue[Math.Min(level, Constants.MultiMath.MinValue.Length)];
                        b = Misc.NextRand(Constants.MultiMath.BScale[Math.Min(level, Constants.MultiMath.BScale.Length)]) + Constants.MultiMath.MinValue[Math.Min(level, Constants.MultiMath.MinValue.Length)];
                    }
                    return new MathQuestion(a, Operand.Subtract, b);
                case 2:
                    return new MathQuestion(Misc.NextRand(Constants.MultiMath.AScale[Math.Min(level, Constants.MultiMath.AScale.Length)] / 3 - 2) + Constants.MultiMath.MinValue[Math.Min(level, Constants.MultiMath.MinValue.Length)],
                                            Operand.Multiply,
                                            Misc.NextRand(Constants.MultiMath.BScale[Math.Min(level, Constants.MultiMath.BScale.Length)] / 3 - 2) + Constants.MultiMath.MinValue[Math.Min(level, Constants.MultiMath.MinValue.Length)]);
                case 3:
                    a = Misc.NextRand(Constants.MultiMath.AScale[Math.Min(level, Constants.MultiMath.AScale.Length)] / Constants.MultiMath.DivisionScaling) + 1;
                    b = Misc.NextRand(Constants.MultiMath.BScale[Math.Min(level, Constants.MultiMath.BScale.Length)] / Constants.MultiMath.DivisionScaling) + 2;
                    return new MathQuestion(a * b, Operand.Divide, b);
                default:
                    throw new InvalidOperationException();
            }
        }
    }
}
