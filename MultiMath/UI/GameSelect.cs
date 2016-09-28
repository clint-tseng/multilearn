using System;
using System.Drawing;
using System.Windows.Forms;
using MultiLearn.Games;

namespace MultiLearn.UI
{
    public partial class GameSelect : Form
    {
        public event GameSelectedEventHandler GameSelected;

        public GameSelect()
        {
            InitializeComponent();
        }

       /* private void _ok_button_Click(object sender, EventArgs e)
        {
            Game game = null;
            switch (this._gameType_combo.Text)
            {
                case "MultiMath":
                    game = new MultiLearn.Games.MultiMath();
                    break;
                case "MultiSpell":
                    game = new MultiSpell();
                    break;
                default:
                    return;
            }
            this.OnGameSelected(new GameSelectedEventArgs(game));
            this.Close();
        }*/

        private void GameSelect_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // TODO: quit if user hits x
                //Application.Exit();
            }
        }

        protected void OnGameSelected(GameSelectedEventArgs e)
        {
            if (this.GameSelected != null)
            {
                this.GameSelected(this, e);
            }
        }

        private void GameSelect_Load(object sender, EventArgs e)
        {
            // HACK: prevent <enter> from previous screen triggering button
            Timer timer = new Timer();
            timer.Interval = 1;
            timer.Tick += delegate(object sender2, EventArgs e2)
            {
                this._math_button.Enabled = true;
                this._spelling_button.Enabled = true;
                this._mathTeam_button.Enabled = true;
                this.button1.Enabled = true;
                this.button2.Enabled = true;
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }

        private void _math_button_Click(object sender, EventArgs e)
        {
            Game game = new MultiMath();
            this.OnGameSelected(new GameSelectedEventArgs(game));
            this.Close();
        }

        private void _spelling_button_Click(object sender, EventArgs e)
        {
            Game game = new MultiSpell();
            this.OnGameSelected(new GameSelectedEventArgs(game));
            this.Close();
        }

        private void _choice_button_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void GameSelect_Resize(object sender, EventArgs e)
        {
            this._buttonPanel.Location = new Point(this.Width / 2 - this._buttonPanel.Width / 2, this.Height / 2 - this._buttonPanel.Height / 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game game = new MultiMathTeamScoring();
            this.OnGameSelected(new GameSelectedEventArgs(game));
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Game game = new MultiMathTeamCoercion();
            this.OnGameSelected(new GameSelectedEventArgs(game));
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Game game = new MultiMultiMath();
            this.OnGameSelected(new GameSelectedEventArgs(game));
            this.Close();
        }
    }

    public delegate void GameSelectedEventHandler(object sender, GameSelectedEventArgs e);

    public class GameSelectedEventArgs : EventArgs
    {
        public Game GameObject
        {
            get { return this._gameObject; }
        }
        private Game _gameObject;

        public GameSelectedEventArgs(Game gameObject)
        {
            this._gameObject = gameObject;
        }
    }
}
