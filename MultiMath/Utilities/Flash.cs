using System;
using System.Drawing;
using System.Windows.Forms;

namespace MultiLearn.Utilities
{
    public partial class Flash : UserControl
    {
        private int _counter;
        private Color _from;
        private Color _to;
        private int _scale;

        public Flash()
        {
            InitializeComponent();
            this._text_label.Visible = false;
        }

        public void PerformFlash(string text, Color to)
        {
            this.PerformFlash(text, to, 1);
        }

        public void PerformFlash(string text, Color to, int seconds)
        {
            this._text_label.Visible = true;
            this._text_label.Text = text;
            this._scale = this._counter = 100 * seconds;
            this._text_label.ForeColor = this._from = Color.FromArgb(0, 0, 0, 0);
            this._to = to;
            this._fade_timer.Start();
        }

        private void _fade_timer_Tick(object sender, EventArgs e)
        {
            this._text_label.ForeColor = Color.FromArgb(0, 
                                                (this._from.R - this._to.R) / this._scale * this._counter + this._to.R, 
                                                (this._from.G - this._to.G) / this._scale * this._counter + this._to.G,
                                                (this._from.B - this._to.B) / this._scale * this._counter + this._to.B);
            if (this._counter-- == 0)
            {
                this._fade_timer.Stop();
                this._text_label.Visible = false;
            }
        }

        private void Flash_Resize(object sender, EventArgs e)
        {
            this._text_label.Size = this.Size;
        }
    }
}
