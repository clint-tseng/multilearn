using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MultiLearn.Data;

namespace MultiLearn.Utilities
{
    public partial class ProgressBar : UserControl
    {
        private int _thisUser;
        private PictureBox[] _boxes;
        private double[] _current;
        private double[] _target;
        private User[] _users;

        public ProgressBar(int thisUser, List<User> users)
        {
            this._users = users.ToArray();
            this._thisUser = thisUser;
            this.BackColor = Color.FromArgb(255, Math.Min(255, (int)users[thisUser].CurrentColor.R + 120), Math.Min(255, (int)users[thisUser].CurrentColor.G + 120), Math.Min(255, (int)users[thisUser].CurrentColor.B + 120));

            this._boxes = new PictureBox[users.Count];
            this._current = new double[users.Count];
            this._target = new double[users.Count];

            for (int i = 0; i < users.Count; i++)
            {
                this._boxes[i] = new PictureBox();
                this._boxes[i].BackColor = users[i].CurrentColor;
                this._boxes[i].BorderStyle = BorderStyle.FixedSingle;
                this._boxes[i].Size = new Size(15, 15);
                this._boxes[i].Location = new Point(this._boxes[i].Width * i, this.Height - this._boxes[i].Height);
                this.Controls.Add(this._boxes[i]);
                this._current[i] = this._target[i] = 0;
            }

            InitializeComponent();
        }

        void _timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < this._boxes.Length; i++)
            {
                if (this._current[i] != this._target[i])
                {
                    this._current[i] = (this._current[i] - this._target[i]) / 2 + this._target[i];
                    this._boxes[i].Top = (int)(this.Height - (this._current[i] * this.Height));
                    this._boxes[i].Height = (this.Height - this._boxes[i].Top);
                    if (Math.Abs(this._current[i] - this._target[i]) < .02)
                    {
                        this._current[i] = this._target[i];
                        this._boxes[i].Top = (int)(this.Height - (this._current[i] * this.Height));
                        this._boxes[i].Height = (this.Height - this._boxes[i].Top);
                    }
                }
            }
        }

        public void MoveTo(int userIndex, double percent)
        {
            this._target[userIndex] = percent;
        }

        public void MoveTo(User user, double percent)
        {
            for (int i = 0; i < this._users.Length; i++)
            {
                if (this._users[i] == user)
                {
                    this._target[i] = percent;
                }
            }
        }

        private void ProgressBar_Resize(object sender, EventArgs e)
        {
            for (int i = 0; i < this._boxes.Length; i++)
            {
                this._boxes[i].Location = new Point(this._boxes[i].Width * i, (int)((this.Height - this._boxes[i].Height) - this._current[i] * (this.Height - this._boxes[i].Height)));
                //this._boxes[i].Height = (this.Height - this._boxes[i].Top);
            }
        }
    }
}
