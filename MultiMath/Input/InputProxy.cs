using System.Drawing;

namespace MultiLearn.Input
{
    public class InputProxy
    {
        public Color CurrentColor
        {
            get { return this._currentColor; }
            set { this._currentColor = value; }
        }
        private Color _currentColor;

        public InputProxy(Color color)
        {
            this._currentColor = color;
        }

        public event InputOccurredEventHandler InputOccurred;

        public virtual void OnInputOccurred(InputOccurredEventArgs e)
        {
            if (this.InputOccurred != null)
            {
                this.InputOccurred(this, e);
            }
        }
    }
}
