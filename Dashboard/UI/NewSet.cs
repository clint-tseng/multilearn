using System;
using System.IO;
using System.Windows.Forms;
using MultiLearn.Data;
using MultiLearn.Utilities;

namespace MultiLearn.Dashboard.UI
{
    public partial class NewSet : Form
    {
        public NewSet()
        {
            InitializeComponent();

            this._type_combo.Items.Add(QuestionSetType.Spelling);
            this._type_combo.Items.Add(QuestionSetType.MultipleChoice);
        }

        private void _cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _ok_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this._name_textbox.Text))
            {
                MessageBox.Show("Please enter a set name.");
                return;
            }

            if (string.IsNullOrEmpty(this._type_combo.Text))
            {
                MessageBox.Show("Please choose a set type.");
                return;
            }

            if (File.Exists(string.Format("{0}\\{1}.{2}", Constants.Directories.Sets, this._name_textbox.Text, 
                Misc.ExtensionForQuestionSetType((QuestionSetType)this._type_combo.SelectedItem))))
            {
                MessageBox.Show("A set already exists with that name. Please choose another.");
                return;
            }

            switch ((QuestionSetType)this._type_combo.SelectedItem)
            {
                case QuestionSetType.Spelling:
                    SpellingSetEditor spellingSetEditor = new SpellingSetEditor(this._name_textbox.Text);
                    spellingSetEditor.MdiParent = this.MdiParent;
                    spellingSetEditor.Show();
                    break;
                case QuestionSetType.MultipleChoice:
                    MultipleChoiceSetEditor multipleChoiceSetEditor = new MultipleChoiceSetEditor(this._name_textbox.Text);
                    multipleChoiceSetEditor.MdiParent = this.MdiParent;
                    multipleChoiceSetEditor.Show();
                    break;
            }
            this.Close();
        }
    }
}
