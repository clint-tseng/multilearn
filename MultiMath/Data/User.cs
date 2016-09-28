using System.Drawing;
using MultiLearn.Data.Log;
using MultiLearn.Input;

namespace MultiLearn.Data
{
    public class User
    {
        /// <summary>
        /// Level contextually refers to the user's level in the currently
        /// executing game.
        /// </summary>
        public double Level
        {
            get { return this._level; }
            set
            {
                this._level = value;
                this._currentSession.end_difficulty = value;
            }
        }
        private double _level;

        public Color CurrentColor
        {
            get { return this._inputProxy.CurrentColor; }
            set { this._inputProxy.CurrentColor = value; } // todo get rid of this
        }

        public InputProxy Proxy
        {
            get { return this._inputProxy; }
            set { this._inputProxy = value; }
        }
        private InputProxy _inputProxy;

        public LogUser Log
        {
            get { return this._logUser; }
            set { this._logUser = value; }
        }
        private LogUser _logUser;

        public UserSession CurrentSession
        {
            get { return this._currentSession; }
            set { this._currentSession = value; }
        }
        private UserSession _currentSession;

        public User(InputProxy proxy, LogUser log)
            : this(proxy)
        {
            this._logUser = log;
        }

        public User(InputProxy proxy) : base()
        {
            this._inputProxy = proxy;
        }
    }
}