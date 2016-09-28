using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MultiLearn.Dashboard.UI;
using MultiLearn.Utilities;
using MultiLearn.Data;

namespace MultiLearn.Dashboard.UI
{
    public partial class MultipleChoiceSetEditor : Form
    {
        private QuestionSet _set;
        private List<MultipleChoiceQuestion> _questions;
        private MultipleChoiceQuestion _currentQuestion;
        private BindingSource _binder;

        private bool _changes = false;

        public MultipleChoiceSetEditor(string name) : this(new QuestionSet(name, QuestionSetType.MultipleChoice, new List<Question>())) { }

        public MultipleChoiceSetEditor(QuestionSet set)
        {
            this._set = set;
            this._questions = new List<MultipleChoiceQuestion>();
            foreach (Question question in set.Questions)
                if (question is MultipleChoiceQuestion)
                    this._questions.Add((MultipleChoiceQuestion)question);

            InitializeComponent();
            this._answers = new TextBox[] { this._answer_A_textBox, this._answer_B_textbox, this._answer_C_textbox, this._answer_D_textbox, this._answer_E_textbox };

            this.Text = string.Format("{0} - MultiLearn Set Editor", set.Name);

            this._binder = new BindingSource();
            this._binder.DataSource = this._questions;

            this._questions_list.DataSource = this._binder;

            foreach (TextBox textBox in this._answers)
            {
                textBox.TextChanged += new EventHandler(_textbox_TextChanged);
                textBox.KeyDown += new KeyEventHandler(_textbox_KeyDown);
                textBox.Leave += new EventHandler(_textbox_Leave);
            }
        }

        private void newSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewSet newSet = new NewSet();
            newSet.MdiParent = this;
            newSet.Show();
        }

        private void openSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilteredSetSelect openSet = new FilteredSetSelect();
            openSet.MdiParent = this;
            openSet.Show();
        }

        private void saveSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveChangesToCurrentQuestion();

            QuestionSetLoader.SaveQuestionSet(this._set);
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
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

            MultipleChoiceQuestion question = new MultipleChoiceQuestion("New Question", null, new Bitmap(218, 218));
            this._questions.Add(question);
            this._binder.ResetBindings(false);
            this._questions_list.SelectedItem = question;

            if (this._questions.Count == 1)
                this.UpdateBindings();

            this._prompt_textbox.Focus();
            this._prompt_textbox.SelectAll();

            this._changes = true;
        }

        private void _questions_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SaveChangesToCurrentQuestion();

            if ((this._currentQuestion != null) && string.IsNullOrEmpty(this._prompt_textbox.Text))
            {
                this._questions_list.SelectedItem = this._currentQuestion;
                return;
            }

            this.UpdateBindings();
        }

        private void UpdateBindings()
        {
            this._currentQuestion = (MultipleChoiceQuestion)this._questions_list.SelectedItem;
            if (this._currentQuestion == null)
            {
                this._prompt_textbox.Text = string.Empty;
                this._picture_box.Image = null;
                this.SetAnswers(null);
            }
            else
            {
                this._prompt_textbox.Text = this._currentQuestion.Question;
                this._picture_box.Image = this._currentQuestion.Image;
                this.SetAnswers(this._currentQuestion.Answers);
            }
        }

        private void SetAnswers(string[] answers)
        {
            if (answers == null)
            {
                foreach (TextBox textBox in this._answers)
                    textBox.Text = string.Empty;
                return;
            }

            int i = 0;
            foreach (string answer in answers)
                this._answers[i++].Text = answer;
        }

        private string[] GetAnswers()
        {
            List<string> result = new List<string>();

            foreach (TextBox textBox in this._answers)
                if (!string.IsNullOrEmpty(textBox.Text))
                    result.Add(textBox.Text);

            return result.ToArray();
        }

        private void MultipleChoiceSetEditor_FormClosing(object sender, FormClosingEventArgs e)
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
                this._currentQuestion.Question = this._prompt_textbox.Text;
                this._currentQuestion.Image = this._picture_box.Image;
                this._currentQuestion.Answers = this.GetAnswers();

                this._binder.ResetBindings(false);
            }
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

        private void _textbox_TextChanged(object sender, EventArgs e)
        {
            this._changes = true;
        }

        private void _textbox_Leave(object sender, EventArgs e)
        {
            this.SaveChangesToCurrentQuestion();
        }

        private void _textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SaveChangesToCurrentQuestion();
        }
    }
}
