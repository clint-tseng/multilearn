using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using MultiLearn.Data;
using MultiLearn.Games;
using MultiLearn.Input;
using MultiLearn.UI;

namespace MultiLearn
{
    /// <summary>
    /// Main application loop.  Mostly implemented as a series of callbacks to minimize asynch headaches.
    /// </summary>
    class Context : ApplicationContext
    {
        /// <summary>
        /// Currently active input layer.
        /// </summary>
        private InputLayer _inputLayer;

        /// <summary>
        /// Currently active game.
        /// </summary>
        private Game _game;

        /// <summary>
        /// Currently playing users.
        /// </summary>
        private List<User> _users;

        /// <summary>
        /// Main initialization for the application.  Initializes static classes and kicks off input select dialog.
        /// </summary>
        public Context()
        {
            Thread th = new Thread(new ThreadStart(DoSplash));
            th.Start();
            Thread.Sleep(1500);
            th.Abort();
            Thread.Sleep(500);

            Application.ApplicationExit += new EventHandler(Application_ApplicationExit);

            Logger.Initialize();
            Utilities.Misc.Initialize();

            this.Run();
        }

        private void DoSplash()
        {
            Splash sp = new Splash();
            sp.ShowDialog();
        }

        private void Run()
        {
            this._inputLayer = new Keypad();
            this._inputLayer.InputReady += new InputReadyEventHandler(_inputLayer_InputReady);
            this._inputLayer.Initialize();
        }

        void _inputLayer_InputReady(object sender, InputReadyEventArgs e)
        {
            this._inputLayer.InputOccurred += new InputOccurredEventHandler(_inputLayer_InputOccurred);
            InputProxy[] proxies = e.Proxies.ToArray();
            
            StudentLogin studentLogin = new StudentLogin(proxies);
            studentLogin.LoginComplete += new LoginCompleteEventHandler(studentLogin_LoginComplete);
            studentLogin.Show();
        }

        void studentLogin_LoginComplete(object sender, LoginCompleteEventArgs e)
        {
            this._users = e.Users;

            GameSelect gameSelect = new GameSelect();
            gameSelect.GameSelected += new GameSelectedEventHandler(gameSelect_GameSelected);
            gameSelect.Show();
        }
        
        void gameSelect_GameSelected(object sender, GameSelectedEventArgs e)
        { 
            this._game = e.GameObject;
            this._game.GameComplete += new EventHandler(_game_GameComplete);
            this._game.Run(this._users);
        }

        void _game_GameComplete(object sender, EventArgs e)
        {
            foreach (User u in this._users)
            {
                u.Level = 0;
            }
            Logger.Flush();
        }

        void postGame_PostGameSelected(object sender, PostGameEventArgs e)
        {
            if (e.startFromLogin)
            {
                this._inputLayer = null;
                this._users = null;
                this.Run();
            }
            else
            {
                GameSelect gameSelect = new GameSelect();
                gameSelect.GameSelected += new GameSelectedEventHandler(gameSelect_GameSelected);
                gameSelect.Show();
            }
        }

        void _inputLayer_InputOccurred(object sender, InputOccurredEventArgs e)
        {
            if (e.InputData.SpecialKey == SpecialKeys.Escape)
            {
                if (this._game != null)
                    this._game.Close();
                else
                    Application.Exit();
                
                this._game = null;
                PostGame postGame = new PostGame();
                postGame.PostGameSelected += new PostGameEventHandler(postGame_PostGameSelected);
                postGame.Show();
            }
        }

        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            Logger.Flush();
        }
    }
}
