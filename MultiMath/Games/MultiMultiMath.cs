using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MultiLearn.Data;
using MultiLearn.Data.Log;
using MultiLearn.Utilities;

namespace MultiLearn.Games
{
    public partial class MultiMultiMath : Form, Game
    {
        private MultiMathPanel[] _panels;
        private Utilities.ProgressBar[] _progressBars;
        private Dictionary<User, int> _users;
        private Session _log;

        public MultiMultiMath()
        {
            InitializeComponent();
        }

        public event EventHandler GameComplete;

        public void Run(List<User> users)
        {
            this._log = MultimathLogger.CreateSession(users);

            List<User> fakeUsers = new List<User> { users[0], users[2] };
            fakeUsers[1].CurrentColor = Constants.Keypad.DefaultColors[1];
            this._users = new Dictionary<User, int>();
            this._panels = new MultiMathPanel[(users.Count / 2)];
            this._progressBars = new global::MultiLearn.Utilities.ProgressBar[(users.Count / 2)];
            for (int i = 0; i < users.Count / 2; i++)
            {
                this._users.Add(users[i * 2], 0);
                this._users.Add(users[i * 2 + 1], 0);

                this._panels[i] = new MultiMathPanel(new List<User>{ users[i * 2], users[i * 2 + 1] }, this._log);
                this._panels[i].PromptQuestion(MathGenerator.GenerateQuestion((int)users[i].Level));
                this._panels[i].QuestionAnswered += new QuestionAnsweredEventHandler(MultiMath_QuestionAnswered);
                this._panels[i].Location = new Point(i * (this.Width / (users.Count / 2)) + (users.Count / 2) * 15, 0);
                this._panels[i].Size = new Size(this.Width / (users.Count / 2) - (users.Count / 2) * 15, this.Height);
                this.Controls.Add(this._panels[i]);

                this._progressBars[i] = new Utilities.ProgressBar(i, fakeUsers);
                this._progressBars[i].Location = new Point(i * (this.Width / (users.Count / 2)), 0);
                this._progressBars[i].Size = new Size((users.Count / 2) * 15, this.Height);
                this.Controls.Add(this._progressBars[i]);
                this._progressBars[i] = this._progressBars[i];
            }

            this.Show();
        }

        void MultiMath_QuestionAnswered(object sender, QuestionAnsweredEventArgs e)
        {
            if (e.Correct)
            {
                e.User.Level += .3;
                this._users[e.User]++;
                foreach (Utilities.ProgressBar bar in this._progressBars)
                {
                    bar.MoveTo(e.User, (float)this._users[e.User] / Constants.MultiMath.Target);
                }
                if (this._users[e.User] == Constants.MultiMath.Target)
                {
                    foreach (MultiMathPanel panel in this._panels)
                    {
                        panel.GameFinished(e.User);
                    }
                    MultimathLogger.UpdateSession(this._log, e.User);
                    this.GameComplete(this, new EventArgs());
                }
            }
            else
            {
                e.User.Level -= .1;
            }
            ((MultiMathPanel)sender).PromptQuestion(MathGenerator.GenerateQuestion((int)e.User.Level));
        }

        protected void OnGameComplete(EventArgs e)
        {
            if (this.GameComplete != null)
            {
                this.GameComplete(this, e);
            }
        }

        private void MultiMath_Resize(object sender, EventArgs e)
        {
            if (this._panels == null)
                return;

            for (int i = 0; i < this._panels.Count(); i++)
            {
                this._panels[i].Location = new Point(i * (this.Width / this._panels.Count()) + this._panels.Count() * 15, 0);
                this._panels[i].Size = new Size(this.Width / this._panels.Count() - this._panels.Count() * 15, this.Height);
                this._progressBars[i].Location = new Point(i * (this.Width / this._panels.Count()), 0);
                this._progressBars[i].Size = new Size(this._panels.Count() * 15, this.Height);
            }
        }
    }
}
