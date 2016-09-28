using System;
using System.Drawing;
using System.Windows.Forms;
using MultiLearn.Data;
using MultiLearn.Data.Log;
using MultiLearn.Input;
using System.Collections.Generic;

namespace MultiLearn.Games
{
    public partial class MultiMathCoercionPanel : UserControl
    {
        private User _user;
        private MathQuestion _question;
        private MultiMathQuestion _logCurrentQuestion;
        private Session _currentSession;
        private int _questionsAsked;

        public event QuestionAnsweredEventHandler QuestionAnswered;

        public MultiMathCoercionPanel(User user, Session session)
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
            this.PromptQuestion(question, true);
        }
        public void PromptQuestion(MathQuestion question, bool unstall)
        {
            if (unstall)
            {
                this._user.Proxy.InputOccurred -= this._user_InputOccurred;
                this._user.Proxy.InputOccurred += new InputOccurredEventHandler(_user_InputOccurred);
                this._container_panel.Visible = true;
                this._arrowL.Visible = false;
                this._arrowR.Visible = false;
            }
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

            this._logCurrentQuestion = MultimathLogger.CreateQuestion(question, this._questionsAsked++, new List<User>{ this._user }, this._currentSession);
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

        public void StallPlayer(int direction)
        {
            this._container_panel.Visible = false;
            this._user.Proxy.InputOccurred -= this._user_InputOccurred;
            if (direction == 0)
            {
                this._flash.PerformFlash("help!", this._user.CurrentColor, 2);
                this._arrowR.Location = new Point(this.Width / 2 - this._arrowR.Width / 2, this.Height / 2 + this._container_panel.Height / 2 - this._arrowR.Height);
                this._arrowR.Visible = true;
            }
            else
            {
                this._flash.PerformFlash("help!", this._user.CurrentColor, 2);
                this._arrowL.Location = new Point(this.Width / 2 - this._arrowL.Width / 2, this.Height / 2 + this._container_panel.Height / 2 - this._arrowL.Height);
                this._arrowL.Visible = true;
            }
        }

        public bool IsPlayerStalled()
        {
            return (this._arrowR.Visible || this._arrowL.Visible);
        }

        protected void _user_InputOccurred(object sender, InputOccurredEventArgs e)
        {
            if ((e.InputData.SpecialKey == SpecialKeys.Backspace) && (this._entry_textbox.Text.Length > 0))
            {
                this._entry_textbox.Text = this._entry_textbox.Text.Substring(0, this._entry_textbox.Text.Length - 1);
            }
            else if ((e.InputData.SpecialKey == SpecialKeys.Enter) && !string.IsNullOrEmpty(this._entry_textbox.Text))
            {
                this.OnQuestionAnswered(new QuestionAnsweredEventArgs(this._user, int.Parse(this._entry_textbox.Text) == this._question.Answer));
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
}
