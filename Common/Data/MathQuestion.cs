using System;

namespace MultiLearn.Data
{
    public enum Operand
    {
        Add = 0, Subtract = 1, Multiply = 2, Divide = 3
    }

    [Serializable]
    public class MathQuestion : Question
    {
        public int A
        {
            get { return this._a; }
        }
        private int _a;

        public int B
        {
            get { return this._b; }
        }
        private int _b;

        public Operand Operand
        {
            get { return this._operand; }
        }
        private Operand _operand;

        public int Answer
        {
            get
            {
                switch (this._operand)
                {
                    case Operand.Add:
                        return this._a + this._b;
                    case Operand.Subtract:
                        return this._a - this._b;
                    case Operand.Multiply:
                        return this._a * this._b;
                    case Operand.Divide:
                        return this._a / this._b;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public MathQuestion(int a, Operand operand, int b)
        {
            this._a = a;
            this._operand = operand;
            this._b = b;
        }

        private MathQuestion()
        { 
            // for serialization purposes
        }
    }
}
