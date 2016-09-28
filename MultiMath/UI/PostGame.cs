using System;
using System.Windows.Forms;

namespace MultiLearn.UI
{
    public partial class PostGame : Form
    {
        public event PostGameEventHandler PostGameSelected;

        public PostGame()
        {
            InitializeComponent();
        }

        protected void OnPostGameSelected(PostGameEventArgs e)
        {
            if (this.PostGameSelected != null)
            {
                this.PostGameSelected(this, e);
            }
        }

        private void _restartButton_Click(object sender, EventArgs e)
        {
            this.OnPostGameSelected(new PostGameEventArgs(false));
            this.Close();
        }

        private void _loginButton_Click(object sender, EventArgs e)
        {
            this.OnPostGameSelected(new PostGameEventArgs(true));
            this.Close();
        }
    }

    public delegate void PostGameEventHandler(object sender, PostGameEventArgs e);

    public class PostGameEventArgs : EventArgs
    {
        public bool startFromLogin
        {
            get { return this._startFromLogin; }
        }
        private bool _startFromLogin;

        public PostGameEventArgs(bool startFromLogin)
        {
            this._startFromLogin = startFromLogin;
        }
    }
}
