using System;
using System.Drawing;
using System.Windows.Forms;

namespace MultiLearn.Input
{
    public partial class NumberOfPlayers : Form
    {
        public event NumberOfPlayersSelectedEventHandler NumberOfPlayersSelected;

        public NumberOfPlayers(int defaultValue)
        {
            InitializeComponent();
            //this._numberOfPlayers_numeric.Value = Math.Min(this._numberOfPlayers_numeric.Maximum, Math.Max(this._numberOfPlayers_numeric.Minimum, defaultValue));
        }

        public NumberOfPlayers()
        {
            InitializeComponent();
        }

        private void _ok_button_Click(object sender, EventArgs e)
        {
            //this.OnNumberOfPlayersSelected(new NumberOfPlayersSelectedEventArgs((int)this._numberOfPlayers_numeric.Value));
            this.Close();
        }

        private void NumberOfPlayers_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // TODO: quit if user hits x
                //Application.Exit();
            }
        }

        protected void OnNumberOfPlayersSelected(NumberOfPlayersSelectedEventArgs e)
        {
            if (this.NumberOfPlayersSelected != null)
            {
                this.NumberOfPlayersSelected(this, e);
            }
        }

        private void _one_player_button_Click(object sender, EventArgs e)
        {
            this.OnNumberOfPlayersSelected(new NumberOfPlayersSelectedEventArgs(1));
            this.Close();
        }

        private void _two_player_button_Click_1(object sender, EventArgs e)
        {
            this.OnNumberOfPlayersSelected(new NumberOfPlayersSelectedEventArgs(2));
            this.Close();
        }

        private void _three_player_button_Click(object sender, EventArgs e)
        {
            this.OnNumberOfPlayersSelected(new NumberOfPlayersSelectedEventArgs(3));
            this.Close();
        }


        private void _four_player_button_Click(object sender, EventArgs e)
        {
            this.OnNumberOfPlayersSelected(new NumberOfPlayersSelectedEventArgs(4));
            this.Close();
        }

        private void NumberOfPlayers_Resize(object sender, EventArgs e)
        {
            this._buttonPanel.Location = new Point(this.Width / 2 - this._buttonPanel.Width / 2, this.Height / 2 - this._buttonPanel.Height / 2 );
        }
    }

    public delegate void NumberOfPlayersSelectedEventHandler(object sender, NumberOfPlayersSelectedEventArgs e);

    public class NumberOfPlayersSelectedEventArgs : EventArgs
    {
        public int NumberOfPlayers
        {
            get { return this._numberOfPlayers; }
        }
        private int _numberOfPlayers;

        public NumberOfPlayersSelectedEventArgs(int numberOfPlayers)
        {
            this._numberOfPlayers = numberOfPlayers;
        }
    }
}
