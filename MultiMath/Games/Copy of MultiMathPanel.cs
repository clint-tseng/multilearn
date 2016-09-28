using System;
using System.Drawing;
using System.Windows.Forms;
using MultiLearn.Data;
using MultiLearn.Data.Log;
using MultiLearn.Input;

namespace MultiLearn.Games
{
    public partial class MultiMathPanel : UserControl
    {
        private User _user;
        private MathQuestion _question;
        private MultiMathQuestion _logCurrentQuestion;
        private Session _currentSession;
        private int _questionsAsked;

        public event QuestionAnsweredEventHandler QuestionAnswered;

        public MultiMathPanel(User user, Session session)
        {
            this._user = user;
            this._user.Proxy.InputOccurred += new InputOccurredEventHandler(_user_InputOccurred);
            this._currentSession = session;
            this._questionsAsked = 0;
            InitializeComponent();
            this._color_panel.BackColor = user.CurrentColor;
            this.BackColor = Color.FromArgb(255, Math.Min(255, (int)user.CurrentColor.R + 100), Math.Min(255, (int)user.CurrentColor.G + 100), Math.Min(255, (int)user.CurrentColor.B + 100));
        }

        public void PromptQuestion(MathQuestion question)
        {
            this._color_panel.Location = new Point(21, 122);
            this._question = question;
            this._a_label.Visible = false;
            this._b_label.Visible = false;
            this._singleLine_label.Visible = false;
            this._line_panel.Visible = false;
            switch (this._question.Operand)
            {
                case Operand.Add:
                    this._a_label.Visible = this._b_label.Visible = this._line_panel.Visible = true;
                    this._a_label.Text = string.Format("{0,3}", this._question.A.ToString());
                    this._b_label.Text = string.Format("{0,3}", this._question.B.ToString());
                    this._operand_label.Text = "+";
                    break;
                case Operand.Subtract:
                    this._a_label.Visible = this._b_label.Visible = this._line_panel.Visible = true;
                    this._a_label.Text = string.Format("{0,3}", this._question.A.ToString());
                    this._b_label.Text = string.Format("{0,3}", this._question.B.ToString());
                    this._operand_label.Text = "-";
                    break;
                case Operand.Multiply:
                    this._singleLine_label.Visible = true;
                    this._singleLine_label.Text = string.Format("{0}×{1}=", this._question.A.ToString(), this._question.B.ToString());
                    break;
                case Operand.Divide:
                    this._singleLine_label.Visible = true;
                    this._singleLine_label.Text = string.Format("{1}){0}(", this._question.A.ToString(), this._question.B.ToString());
                    break;
            }
            this._entry_textbox.Text = String.Empty;

            this._logCurrentQuestion = MultimathLogger.CreateQuestion(question, this._questionsAsked++, this._user, this._currentSession);
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

        protected void _user_InputOccurred(object sender, InputOccurredEventArgs e)
        {
            if ((e.InputData.SpecialKey == SpecialKeys.Backspace) && (this._entry_textbox.Text.Length > 0))
            {
                this._entry_textbox.Text = this._entry_textbox.Text.Substring(0, this._entry_textbox.Text.Length - 1);
            }
            else if ((e.InputData.SpecialKey == SpecialKeys.Enter) && !string.IsNullOrEmpty(this._entry_textbox.Text))
            {
                try
                {
                    this.OnQuestionAnswered(new QuestionAnsweredEventArgs(this._user, int.Parse(this._entry_textbox.Text) == this._question.Answer));
                }
                catch (Exception ex)
                {
                    this.OnQuestionAnswered(new QuestionAnsweredEventArgs(this._user, false));
                }
            }
            else
            {
                this._entry_textbox.Text += e.InputData.Data;
            }
        }

        protected void OnQuestionAnswered(QuestionAnsweredEventArgs e)
        {
            this._flash.PerformFlash((e.Correct ? "yes" : "no"), this.BackColor);
            MultimathLogger.UpdateQuestion(this._logCurrentQuestion, int.Parse(this._entry_textbox.Text), e.Correct);
            this._user.CurrentSession.total++;
            if (e.Correct)
                this._user.CurrentSession.correct++;
            
            if (this.QuestionAnswered != null)
            {
                this.QuestionAnswered(this, e);
            }
        }

        private void MultiMathPanel_Resize(object sender, EventArgs e)
        {
            this._container_panel.Location = new Point(this.Width / 2 - this._container_panel.Width / 2, this.Height / 2 - this._container_panel.Height / 2);
            this._flash.Location = new Point(this.Width / 2 - this._flash.Width / 2, this.Height / 2 + this._container_panel.Height / 2);
        }
    }

    public delegate void QuestionAnsweredEventHandler(object sender, QuestionAnsweredEventArgs e);

    public class QuestionAnsweredEventArgs : EventArgs
    {
        public bool Correct
        {
            get { return this._correct; }
        }
        private bool _correct;

        public User User
        {
            get { return this._user; }
        }
        private User _user;

        public QuestionAnsweredEventArgs(User user, bool correct)
        {
            this._user = user;
            this._correct = correct;
        }
    }
}
