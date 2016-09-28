using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MultiLearn.Data;
using MultiLearn.Data.Log;
using MultiLearn.Utilities;
using MultiLearn.Input;

namespace MultiLearn.Games
{
    public partial class MultiMathTeamCoercion : Form, Game
    {
        private MultiMathCoercionPanel[] _panels;
        private Utilities.ProgressBar _progressBar;
        private Dictionary<User, int> _users;
        private List<User> _fakeUsers;
        private Session _log;
        private List<User> _userList;

        public MultiMathTeamCoercion()
        {
            InitializeComponent();
        }

        public event EventHandler GameComplete;

        public void Run(List<User> users)
        {
            if (users.Count != 4)
            {
                this.GameComplete(this, new EventArgs());
            }

            users[0].CurrentColor = Constants.Keypad.DefaultColors[0];
            users[1].CurrentColor = Constants.Keypad.DefaultColors[0];
            users[2].CurrentColor = Constants.Keypad.DefaultColors[1];
            users[3].CurrentColor = Constants.Keypad.DefaultColors[1];

            this._log = MultimathLogger.CreateSession(users, "MultiMathTeamCoercion");

            this._users = new Dictionary<User, int>();
            this._panels = new MultiMathCoercionPanel[users.Count];

            this._fakeUsers = new List<User>();
            _fakeUsers.Add(new User(new InputProxy(Constants.Keypad.DefaultColors[0])));
            _fakeUsers.Add(new User(new InputProxy(Constants.Keypad.DefaultColors[1])));
            _fakeUsers.Add(new User(new InputProxy(Constants.Keypad.DefaultColors[2]))); // the hack to rule them all
            this._progressBar = new global::MultiLearn.Utilities.ProgressBar(2, _fakeUsers);
            this._progressBar.Location = new Point((this.Width - 30) / 2, 0);
            this._progressBar.Size = new Size(30, this.Height);
            this.Controls.Add(this._progressBar);

            for (int i = 0; i < users.Count; i++)
            {
                this._users.Add(users[i], 0);

                this._panels[i] = new MultiMathCoercionPanel(users[i], this._log);
                this._panels[i].PromptQuestion(MathGenerator.GenerateQuestion((int)users[i].Level));
                this._panels[i].QuestionAnswered += new QuestionAnsweredEventHandler(MultiMath_QuestionAnswered);
                this._panels[i].Location = new Point(i * ((this.Width - 30) / 4) + (i > 1 ? 30 : 0), 0);
                this._panels[i].Size = new Size((this.Width - 30) / 4, this.Height);
                this.Controls.Add(this._panels[i]);
            }

            _userList = users;

            this.Show();
        }

        void MultiMath_QuestionAnswered(object sender, QuestionAnsweredEventArgs e)
        {
            if (e.Correct)
            {
                e.User.Level += .3;
                this._users[e.User]++;

                int index = _userList.IndexOf(e.User);
                bool gameComplete = false;
                if (index == 0 || index == 1)
                {
                    if (this._panels[0].IsPlayerStalled() || this._panels[1].IsPlayerStalled())
                    {
                        _progressBar.MoveTo(0, (float)(this._users[_userList[0]] + this._users[_userList[1]]) / (Constants.MultiMath.Target * 2));
                        if (this._users[_userList[0]] + this._users[_userList[1]] == Constants.MultiMath.Target * 2)
                        {
                            gameComplete = true;
                        }
                        this._panels[0].PromptQuestion(MathGenerator.GenerateQuestion((int)e.User.Level));
                        this._panels[1].PromptQuestion(MathGenerator.GenerateQuestion((int)e.User.Level));
                    }
                    else
                    {
                        this._panels[index].StallPlayer(index % 2);
                    }
                }
                else
                {
                    if (this._panels[2].IsPlayerStalled() || this._panels[3].IsPlayerStalled())
                    {
                        _progressBar.MoveTo(1, (float)(this._users[_userList[2]] + this._users[_userList[3]]) / (Constants.MultiMath.Target * 2));
                        if (this._users[_userList[2]] + this._users[_userList[3]] == Constants.MultiMath.Target * 2)
                        {
                            gameComplete = true;
                        }
                        this._panels[2].PromptQuestion(MathGenerator.GenerateQuestion((int)e.User.Level));
                        this._panels[3].PromptQuestion(MathGenerator.GenerateQuestion((int)e.User.Level));
                    }
                    else
                    {
                        this._panels[index].StallPlayer(index % 2);
                    }
                }

                if (gameComplete)
                {
                    foreach (MultiMathCoercionPanel panel in this._panels)
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
                ((MultiMathCoercionPanel)sender).PromptQuestion(MathGenerator.GenerateQuestion((int)e.User.Level), false);
            }
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
                this._panels[i].Location = new Point(i * ((this.Width - 30) / 4) + (i > 1 ? 30 : 0), 0);
                this._panels[i].Size = new Size((this.Width - 30) / 4, this.Height);
                this._progressBar.Location = new Point((this.Width - 30) / 2, 0);
                this._progressBar.Size = new Size(30, this.Height);
            }
        }
    }
}
