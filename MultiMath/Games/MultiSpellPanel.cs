using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MultiLearn.Data;
using MultiLearn.Data.Log;
using MultiLearn.Input;

namespace MultiLearn.Games
{
    public partial class MultiSpellPanel : UserControl
    {
        private User _user;
        private string _answer;
        private MultiSpellQuestion _logCurrentQuestion;
        private Session _currentSession;
        private int _answerIndex;
        private int _questionsAsked;
        private Label[] _labels;

        private bool _locked;

        public event QuestionAnsweredEventHandler QuestionAnswered;

        public MultiSpellPanel(User user, Session session)
        {
            this._user = user;
            this._user.Proxy.InputOccurred += new global::MultiLearn.Input.InputOccurredEventHandler(_user_InputOccurred);
            this._questionsAsked = 0;
            this._currentSession = session;

            this._locked = false;

            InitializeComponent();

            // Create grid of labels
            int gap = this._2_label.Left - this._1_label.Left;
            Point start = this._1_label.Location;

            this._labels = new Label[9];
            for (int i = 0; i < 9; i++)
            {
                this._labels[i] = new Label();
                this._container_panel.Controls.Add(this._labels[i]);
                this._labels[i].Location = new Point(start.X + gap * (i % 3) + 20, start.Y - gap * (i / 3) + 15);
                this._labels[i].AutoSize = false;
                this._labels[i].BackColor = this._1_label.BackColor;
                this._labels[i].Size = new Size(this._1_label.Size.Width - 40, this._1_label.Size.Height - 30);
                this._labels[i].TextAlign = ContentAlignment.MiddleCenter;
                this._labels[i].Font = new Font("Consolas", 30);
                this._labels[i].Text = i.ToString();
                this._labels[i].BringToFront();
            }

            this.BackColor = Color.FromArgb(255, Math.Min(255, (int)user.CurrentColor.R + 100), Math.Min(255, (int)user.CurrentColor.G + 100), Math.Min(255, (int)user.CurrentColor.B + 100));
        }

        public void PromptQuestion(SpellingQuestion question)
        {
            this._image.Image = question.Image;
            this._answer = question.Word;
            this._answerIndex = 0;
            this._answer_label.Text = new string('-', question.Word.Length);
            this.PromptLetter(question.Word[0]);

            this._logCurrentQuestion = MultispellLogger.CreateQuestion(question, this._questionsAsked++, this._user, this._currentSession);
        }

        protected void _user_InputOccurred(object sender, InputOccurredEventArgs e)
        {
            if (this._locked)
            {
                return;
            }

            if (e.InputData.IsNumeric() && (e.InputData.NumericData > 0))
            {
                if (this._labels[e.InputData.NumericData - 1].Text == this._answer[this._answerIndex].ToString())
                {
                    this._answer_label.Text = string.Format("{0}{1}", this._answer.Substring(0, ++this._answerIndex), new string('-', this._answer.Length - this._answerIndex));
                    if (this._answerIndex == this._answer.Length)
                        this.OnQuestionAnswered(new QuestionAnsweredEventArgs(this._user, true));
                    else
                        this.PromptLetter(this._answer[this._answerIndex]);
                }
                else
                {
                    this._locked = true;
                    Timer timer = new Timer();
                    timer.Interval = 1000;
                    timer.Tick += new EventHandler(timer_Tick);
                    timer.Start();
                    for (int i = 0; i < this._labels.Length; i++)
                        this._labels[i].ForeColor = (this._labels[i].ForeColor == Color.Red) ? Color.FromArgb(193, 192, 192) : Color.FromArgb(192, 192, 192);
                    this._labels[e.InputData.NumericData - 1].ForeColor = Color.Red;

                    MultispellLogger.AddMistakeToQuestion(this._logCurrentQuestion, this._answerIndex, this._labels[e.InputData.NumericData - 1].Text.ToCharArray()[0]);
                }
            }
            else
            {
                if (e.InputData.Data.ToString().ToUpper() == this._answer[this._answerIndex].ToString().ToUpper())
                {
                    this._answer_label.Text = string.Format("{0}{1}", this._answer.Substring(0, ++this._answerIndex), new string('-', this._answer.Length - this._answerIndex));
                    if (this._answerIndex == this._answer.Length)
                        this.OnQuestionAnswered(new QuestionAnsweredEventArgs(this._user, true));
                    else
                        this.PromptLetter(this._answer[this._answerIndex]);
                }
                else
                {
                    this._locked = true;
                    Timer timer = new Timer();
                    timer.Interval = 1000;
                    timer.Tick += new EventHandler(timer_Tick);
                    timer.Start();
                    for (int i = 0; i < this._labels.Length; i++)
                        this._labels[i].ForeColor = (this._labels[i].ForeColor == Color.Red) ? Color.FromArgb(193, 192, 192) : Color.FromArgb(192, 192, 192);

                    MultispellLogger.AddMistakeToQuestion(this._logCurrentQuestion, this._answerIndex, e.InputData.Data);
                }
            }
        }
            void timer_Tick(object sender, EventArgs e)
            {
                for (int i = 0; i < this._labels.Length; i++)
                    this._labels[i].ForeColor = (this._labels[i].ForeColor == Color.FromArgb(192, 192, 192)) ? Color.Black : Color.Red;
                this._locked = false;
                ((Timer)sender).Stop();
            }

        private void PromptLetter(char letter)
        {
            List<char> options = new List<char>();
            options.Add(letter);

            while (options.Count < 9)
            {
                char pick = Constants.MultiSpell.LetterBag[Utilities.Misc.NextRand(Constants.MultiSpell.LetterBag.Length)];
                if (!options.Contains(pick))
                {
                    options.Add(pick);
                }
            }
            options.Sort();
            char[] optionsMapped = MultiSpellPanel.MapToKeypad(options);

            for (int i = 0; i < 9; i++)
            {
                this._labels[i].ForeColor = Color.Black;
                this._labels[i].Text = optionsMapped[i].ToString();
            }
        }

        public void GameFinished(User winner)
        {
            this._container_panel.Visible = false;
            this._user.Proxy.InputOccurred -= this._user_InputOccurred;
            if (winner == this._user)
            {
                this._flash.PerformFlash("winner!", this._user.CurrentColor, 60);
                this._winnerTrophyPictureBox.Location = new Point(this.Width / 2 - this._winnerTrophyPictureBox.Width / 2, this.Height / 2 + this._container_panel.Height / 2 - this._winnerTrophyPictureBox.Height);
                this._winnerTrophyPictureBox.Visible = true;
            }
        }

        // Messy, but there's no elegant solution
        private static char[] MapToKeypad(List<char> orderedList)
        {
            char[] result = new char[9];
            for (int i = 0; i < 9; i++)
            {
                result[i] = orderedList[(2 - (i / 3)) * 3 + (i % 3)];
            }
            return result;
        }

        private void MultiSpellPanel_Resize(object sender, EventArgs e)
        {
            this._container_panel.Location = new Point(this.Width / 2 - this._container_panel.Width / 2, this.Height / 2 - this._container_panel.Height / 2);
            this._flash.Location = new Point(this.Width / 2 - this._flash.Width / 2, this.Height / 2 + this._container_panel.Height / 2);
        }

        protected void OnQuestionAnswered(QuestionAnsweredEventArgs e)
        {
            this._flash.PerformFlash((e.Correct ? "yes" : "no"), this.BackColor);
            MultispellLogger.UpdateQuestion(this._logCurrentQuestion, true);
            if (this.QuestionAnswered != null)
            {
                this.QuestionAnswered(this, e);
            }
        }
    }
}
