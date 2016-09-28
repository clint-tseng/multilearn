using System;
using System.Drawing;

namespace MultiLearn.Data
{
    [Serializable]
    public class SpellingQuestion : Question
    {
        public string Word
        {
            get { return this._word; }
            set { this._word = value; }
        }
        private string _word;

        public SpellingQuestion(string word, Image image) : base(image)
        {
            this._word = word;
        }

        public override string ToString()
        {
            return _word;
        }

        private SpellingQuestion()
        { 
            // for serialization purposes
        }
    }
}
