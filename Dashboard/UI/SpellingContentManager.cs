using System.Collections.Generic;
using System.Windows.Forms;
using MultiLearn.Data;
using MultiLearn.Utilities;

namespace Admin.UI
{
    public partial class SpellingContentManager : Form
    {
        private QuestionSet _set;
        private List<SpellingQuestion> _questions;
        private BindingSource _bind;

        public SpellingContentManager()
        {
            this._questions = new List<SpellingQuestion>();

            this._set = QuestionSetLoader.OpenQuestionSet("animals", QuestionSetType.Spelling);
            // HACK: yay language semantics
            foreach (Question question in this._set.Questions)
                if (question is SpellingQuestion)
                    this._questions.Add((SpellingQuestion)question);

            this._bind = new BindingSource();
            this._bind.DataSource = this._questions;

            InitializeComponent();

            this._grid.AutoGenerateColumns = false;
            this._grid.DataSource = this._bind;
        }
    }
}
