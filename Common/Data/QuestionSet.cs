using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MultiLearn.Data
{
    public enum QuestionSetType
    {
        Spelling = 0, MultipleChoice = 1, Math = 2
    }

    [Serializable]
    public class QuestionSet
    {
        [XmlAttribute("name")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _name;

        [XmlAttribute("type")]
        public QuestionSetType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        private QuestionSetType _type;

        [XmlArrayItem(ElementName = "SpellingQuestion", Type = typeof(SpellingQuestion), IsNullable = false)]
        [XmlArrayItem(ElementName = "MultipleChoiceQuestion", Type = typeof(MultipleChoiceQuestion), IsNullable = false)]
        [XmlArrayItem(ElementName = "MathQuestion", Type = typeof(MathQuestion), IsNullable = false)]
        public List<Question> Questions
        {
            get { return this._questions; }
            set 
            {
                if (!this.ValidateQuestionList(value))
                {
                    throw new ArgumentException();
                }

                this._questions = value;
            }
        }
        private List<Question> _questions;

        public bool AddQuestion(Question question)
        { 
            bool success = ValidateQuestion(question);

            if (success)
            {
                if (Questions == null)
                {
                    Questions = new List<Question>();
                }

                Questions.Add(question);
            }

            return success;
        }

        private bool ValidateQuestionList(List<Question> questions)
        {
            foreach (Question question in questions)
            {
                if (!this.ValidateQuestion(question))
                {
                    return false;
                }
            }
            return true;
        }

        private bool ValidateQuestion(Question question) 
        {
            return ((this.Type == QuestionSetType.Spelling && question is SpellingQuestion) ||
                (this.Type == QuestionSetType.MultipleChoice && question is MultipleChoiceQuestion) ||
                (this.Type == QuestionSetType.Math && question is MathQuestion));
        }

        public QuestionSet(string name, QuestionSetType type, List<Question> questions)
        {            
            this._name = name;
            this._type = type;

            if (!this.ValidateQuestionList(questions)) 
            {
                throw new ArgumentException();
            }

            this._questions = questions;
        }

        private QuestionSet()
        { 
            // for serialization purposes
            this._questions = new List<Question>();
        }
    }
}
