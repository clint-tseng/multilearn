using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MultiLearn.Data;
using MultiLearn.Utilities;

namespace MultiLearn.Dashboard.UI
{
    public partial class FilteredSetSelect : Form
    {
        public QuestionSetType CurrentFilterType
        {
            get { return this._currentFilterType; }
            set
            {
                this._currentFilterType = value;

                string[] sets = Directory.GetFiles(Constants.Directories.Sets);
                sets = (from s in sets
                        where s.Contains(Misc.ExtensionForQuestionSetType(this._currentFilterType))
                        select s).ToArray();

                for (int i = 0; i < sets.Count(); i++)
                {
                    sets[i] = sets[i].Replace(string.Format("{0}\\", Constants.Directories.Sets), string.Empty)
                                     .Replace(string.Format(".{0}", Misc.ExtensionForQuestionSetType(this._currentFilterType)), string.Empty);
                }
                this._sets_list.DataSource = sets;
            }
        }
        private QuestionSetType _currentFilterType;

        public FilteredSetSelect()
        {
            InitializeComponent();
            this._type_combo.Items.Add(QuestionSetType.Spelling);
            this._type_combo.Items.Add(QuestionSetType.MultipleChoice);

            this._type_combo.SelectedIndex = 0;
        }

        private void _cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _open_button_Click(object sender, EventArgs e)
        {
            switch (this._currentFilterType)
            {
                case QuestionSetType.Spelling:
                    SpellingSetEditor spellingSetEditor = new SpellingSetEditor(QuestionSetLoader.OpenQuestionSet(this._sets_list.Text, QuestionSetType.Spelling));
                    spellingSetEditor.MdiParent = this.MdiParent;
                    spellingSetEditor.Show();
                    break;
                case QuestionSetType.MultipleChoice:
                    MultipleChoiceSetEditor multipleChoiceSetEditor = new MultipleChoiceSetEditor(QuestionSetLoader.OpenQuestionSet(this._sets_list.Text, QuestionSetType.MultipleChoice));
                    multipleChoiceSetEditor.MdiParent = this.MdiParent;
                    multipleChoiceSetEditor.Show();
                    break;
            }
            this.Close();
        }

        private void _type_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CurrentFilterType = (QuestionSetType)this._type_combo.SelectedItem;
        }
    }
}
