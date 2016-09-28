using System;
using System.Drawing;
using System.Windows.Forms;
using MultiLearn.Data;
using MultiLearn.Data.Log;
using MultiLearn.Input;

namespace MultiLearn.Login
{
    public partial class LoginPanel : UserControl
    {
        public event UserLoggedInEventHandler UserLoggedIn;

        InputProxy _proxy;

        public LoginPanel(InputProxy proxy)
        {
            InitializeComponent();
            
            this._proxy = proxy;
            this.BackColor = Color.FromArgb(255, Math.Min(255, (int)proxy.CurrentColor.R + 100), Math.Min(255, (int)proxy.CurrentColor.G + 100), Math.Min(255, (int)proxy.CurrentColor.B + 100));
            this._color_panel.BackColor = proxy.CurrentColor;
            
            this._proxy.InputOccurred += new InputOccurredEventHandler(_proxy_InputOccurred);
        }

        void _proxy_InputOccurred(object sender, InputOccurredEventArgs e)
        {
            if ((e.InputData.SpecialKey == SpecialKeys.Backspace) && (this._entry_textbox.Text.Length > 0))
            {
                this._entry_textbox.Text = this._entry_textbox.Text.Substring(0, this._entry_textbox.Text.Length - 1);
            }
            else if ((e.InputData.SpecialKey == SpecialKeys.Enter) && !string.IsNullOrEmpty(this._entry_textbox.Text))
            {
                LogUser logUser = Logger.FindUser(int.Parse(this._entry_textbox.Text));
                if (logUser == null)
                {
                    this._entry_textbox.Text = string.Empty;
                    this._flash.PerformFlash("try again", this.BackColor);
                }
                else
                {
                    // TODO: add confirm via user's name
                    this._entry_panel.Visible = false;
                    this.OnUserLoggedIn(new UserLoggedInEventArgs(new User(this._proxy, logUser)));
                    this._proxy.InputOccurred -= this._proxy_InputOccurred;
                }
            }
            else
            {
                this._entry_textbox.Text += e.InputData.Data;
            }
        }

        private void LoginPanel_Resize(object sender, EventArgs e)
        {
            this._entry_panel.Top = (this.Height / 2) - (this._entry_panel.Height / 2);
            this._entry_panel.Left = (this.Width / 2) - (this._entry_panel.Width / 2);
        }

        protected void OnUserLoggedIn(UserLoggedInEventArgs e)
        {
            if (this.UserLoggedIn != null)
            {
                this.UserLoggedIn(this, e);
            }
        }
    }

    public delegate void UserLoggedInEventHandler(object sender, UserLoggedInEventArgs e);

    public class UserLoggedInEventArgs : EventArgs
    {
        public User User
        {
            get { return this._user; }
        }
        private User _user;

        public UserLoggedInEventArgs(User user)
        {
            this._user = user;
        }
    }
}
