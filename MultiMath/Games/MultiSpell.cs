using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MultiLearn.Data;
using MultiLearn.Data.Log;
using MultiLearn.UI;

namespace MultiLearn.Games
{
    public partial class MultiSpell : Form, Game
    {
        private MultiSpellPanel[] _panels;
        private Utilities.ProgressBar[] _progressBars;
        private List<User> _userList;
        private Dictionary<User, int> _users;
        private List<Question> _questions;
        private Session _log;

        public MultiSpell()
        {
            InitializeComponent();
        }

        public event EventHandler GameComplete;

        public void Run(List<User> users)
        {
            this._log = MultispellLogger.CreateSession(users);

            this._userList = users;

            SetSelect setSelect = new SetSelect(QuestionSetType.Spelling);
            setSelect.SetSelected += new SetSelectedEventHandler(setSelect_SetSelected);
            setSelect.Show();
        }

        void setSelect_SetSelected(object sender, SetSelectedEventArgs e)
        {
            this._questions = e.set.Questions;
            this._users = new Dictionary<User, int>();
            this._panels = new MultiSpellPanel[this._userList.Count];
            this._progressBars = new Utilities.ProgressBar[this._userList.Count];
            for (int i = 0; i < this._userList.Count; i++)
            {
                this._users.Add(this._userList[i], 0);
                this._panels[i] = new MultiSpellPanel(this._userList[i], this._log);
                this._panels[i].QuestionAnswered += new QuestionAnsweredEventHandler(MultiSpell_QuestionAnswered);
                this._panels[i].Location = new Point(i * (this.Width / this._userList.Count) + this._userList.Count * 15, 0);
                this._panels[i].Size = new Size(this.Width / this._userList.Count - this._userList.Count * 15, this.Height);
                this.Controls.Add(this._panels[i]);
                this.PromptQuestion(this._panels[i]);

                this._progressBars[i] = new Utilities.ProgressBar(i, this._userList);
                this._progressBars[i].Location = new Point(i * (this.Width / this._userList.Count), 0);
                this._progressBars[i].Size = new Size(this._userList.Count * 15, this.Height);
                this.Controls.Add(this._progressBars[i]);
                this._progressBars[i] = this._progressBars[i];
            }

            this.Show();
        }

        void MultiSpell_QuestionAnswered(object sender, QuestionAnsweredEventArgs e)
        {
            if (e.Correct)
            {
                this._users[e.User]++;
                foreach (Utilities.ProgressBar bar in this._progressBars)
                {
                    bar.MoveTo(e.User, (float)this._users[e.User] / Constants.MultiSpell.Target);
                }
                if (this._users[e.User] == Constants.MultiSpell.Target)
                {
                    foreach (MultiSpellPanel panel in this._panels)
                    {
                        panel.GameFinished(e.User);
                    }
                    MultispellLogger.UpdateSession(this._log, e.User);
                    this.GameComplete(this, new EventArgs());
                }
                else
                {
                    this.PromptQuestion((MultiSpellPanel)sender);
                }
            }
        }

        private void PromptQuestion(MultiSpellPanel panel)
        {
            panel.PromptQuestion((SpellingQuestion) this._questions.Skip(Utilities.Misc.NextRand(this._questions.Count)).First());
        }

        protected void OnGameComplete(EventArgs e)
        {
            if (this.GameComplete != null)
            {
                this.GameComplete(this, e);
            }
        }

        private void MultiSpell_Resize(object sender, EventArgs e)
        {
            if (this._panels == null)
                return;
            
            for (int i = 0; i < this._panels.Count(); i++)
            {
                this._panels[i].Location = new Point(i * (this.Width / this._userList.Count) + this._userList.Count * 15, 0);
                this._panels[i].Size = new Size(this.Width / this._userList.Count - this._userList.Count * 15, this.Height);
                this._progressBars[i].Location = new Point(i * (this.Width / this._userList.Count), 0);
                this._progressBars[i].Size = new Size(this._userList.Count * 15, this.Height);
            }
        }
    }
}
