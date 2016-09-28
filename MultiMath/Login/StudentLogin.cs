using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MultiLearn.Data;
using MultiLearn.Input;
using MultiLearn.Login;

namespace MultiLearn.UI
{
    public partial class StudentLogin : Form
    {
        private LoginPanel[] _panels;
        private List<User> _users;

        public event LoginCompleteEventHandler LoginComplete;
        
        public StudentLogin(InputProxy[] proxies)
        {
            this._users = new List<User>();

            this._panels = new LoginPanel[proxies.Length];
            
            for (int i = 0; i < this._panels.Length; i++)
            {
                this._panels[i] = new LoginPanel(proxies[i]);
                this._panels[i].Location = new Point(i * (this.Width / this._panels.Length), 0);
                this._panels[i].Size = new Size(this.Width / this._panels.Length, this.Height);
                this._panels[i].UserLoggedIn += new UserLoggedInEventHandler(StudentLogin_UserLoggedIn);
                this.Controls.Add(this._panels[i]);
            }

            InitializeComponent();
        }

        protected void StudentLogin_UserLoggedIn(object sender, UserLoggedInEventArgs e)
        {
            this._users.Add(e.User);
            if (this._users.Count == this._panels.Length)
            {
                this.OnLoginComplete(new LoginCompleteEventArgs(this._users));
                this.Close();
            }
        }

        protected void OnLoginComplete(LoginCompleteEventArgs e)
        {
            if (this.LoginComplete != null)
            {
                this.LoginComplete(this, e);
            }
        }

        private void StudentLogin_Resize(object sender, EventArgs e)
        {
            for (int i = 0; i < this._panels.Length; i++)
            {
                this._panels[i].Location = new Point(i * (this.Width / this._panels.Length), 0);
                this._panels[i].Size = new Size(this.Width / this._panels.Length, this.Height);
            }
        }
    }

    public delegate void LoginCompleteEventHandler(object sender, LoginCompleteEventArgs e);

    public class LoginCompleteEventArgs : EventArgs
    {
        public List<User> Users
        {
            get { return this._users; }
        }
        private List<User> _users;

        public LoginCompleteEventArgs(List<User> users)
        {
            this._users = users;
        }
    }
}