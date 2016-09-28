using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MultiLearn.Data;
using MultiLearn.Utilities;

namespace MultiLearn.Dashboard.UI
{
    public partial class SpellingSetEditor : Form
    {
        private QuestionSet _set;
        private List<SpellingQuestion> _questions;
        private SpellingQuestion _currentQuestion;
        private BindingSource _binder;

        private bool _changes = false;

        public SpellingSetEditor(string name) : this(new QuestionSet(name, QuestionSetType.Spelling, new List<Question>())) { }

        public SpellingSetEditor(QuestionSet set)
        {
            this._set = set;
            this._questions = new List<SpellingQuestion>();
            foreach (Question question in set.Questions)
                if (question is SpellingQuestion)
                    this._questions.Add((SpellingQuestion)question);
            
            InitializeComponent();

            this.Text = string.Format("{0} - MultiLearn Set Editor", set.Name);

            this._binder = new BindingSource();
            this._binder.DataSource = this._questions;

            this._questions_list.DataSource = this._binder;
        }

        private void _changepicture_button_Click(object sender, EventArgs e)
        {
            this._open_dialog.ShowDialog();
            this._picture_box.Image = Image.FromStream(this._open_dialog.OpenFile());

            this._changes = true;
        }

        private void _newquestion_button_Click(object sender, EventArgs e)
        {
            this.SaveChangesToCurrentQuestion();

            SpellingQuestion question = new SpellingQuestion("New Word", new Bitmap(218, 218));
            this._questions.Add(question);
            this._binder.ResetBindings(false);
            this._questions_list.SelectedItem = question;

            if (this._questions.Count == 1)
                this.UpdateBindings();

            this._word_textbox.Focus();
            this._word_textbox.SelectAll();

            this._changes = true;
        }

        private void _questions_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SaveChangesToCurrentQuestion();

            if ((this._currentQuestion != null) && string.IsNullOrEmpty(this._word_textbox.Text))
            {
                this._questions_list.SelectedItem = this._currentQuestion;
                return;
            }

            this.UpdateBindings();
        }

        private void UpdateBindings()
        {
            this._currentQuestion = (SpellingQuestion)this._questions_list.SelectedItem;
            if (this._currentQuestion == null)
            {
                this._word_textbox.Text = string.Empty;
                this._picture_box.Image = null;
            }
            else
            {
                this._word_textbox.Text = this._currentQuestion.Word;
                this._picture_box.Image = this._currentQuestion.Image;
            }
        }

        private void SpellingGameEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this._changes)
            {
                switch (MessageBox.Show(string.Format("Do you want to save changes to {0}?", this._set.Name), "Unsaved Changes", MessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.Yes:
                        this.SaveChangesToCurrentQuestion();

                        List<Question> questions = new List<Question>();
                        foreach (Question question in this._questions)
                            questions.Add(question);

                        this._set.Questions = questions;

                        QuestionSetLoader.SaveQuestionSet(this._set);
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void SaveChangesToCurrentQuestion()
        {
            if (this._currentQuestion != null)
            {
                this._currentQuestion.Word = this._word_textbox.Text;
                this._currentQuestion.Image = this._picture_box.Image;
                this._binder.ResetBindings(false);
            }
        }

        private void _word_textbox_TextChanged(object sender, EventArgs e)
        {
            this._changes = true;
        }

        private void _word_textbox_Leave(object sender, EventArgs e)
        {
            this._word_textbox.Text = this._word_textbox.Text.ToLower();

            this.SaveChangesToCurrentQuestion();
        }

        private void _removequestion_button_Click(object sender, EventArgs e)
        {
            if (this._currentQuestion != null)
            {
                this._questions.Remove(this._currentQuestion);
                this._binder.ResetBindings(false);

                this._changes = true;
            }
        }

        private void _word_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SaveChangesToCurrentQuestion();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
