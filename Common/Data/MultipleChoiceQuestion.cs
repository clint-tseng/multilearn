using System;
using System.Drawing;

namespace MultiLearn.Data
{
    [Serializable]
    public class MultipleChoiceQuestion : Question
    {
        public string Question
        {
            get { return this._question; }
            set { this._question = value; }
        }
        private string _question;

        public string[] Answers
        {
            get { return this._answers; }
            set { this._answers = value; }
        }
        private string[] _answers;

        public MultipleChoiceQuestion(string question, string[] answers, Image image)
            : base(image)
        {
            this._question = question;
            this._answers = answers;
        }

        public MultipleChoiceQuestion(string question, string[] answers)
        {
            this._question = question;
            this._answers = answers;
        }

        private MultipleChoiceQuestion()
        { 
            // for serialization purposes
        }

        public override string ToString()
        {
            return this._question;
        }
    }
}
