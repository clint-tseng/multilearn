using System.Windows.Forms;
using RawInput;

namespace MultiLearn.Input
{
    public partial class KeypadForm : Form
    {
        private InputDevice _inputDevice;

        public KeypadForm()
        {
            InitializeComponent();
        }

        public void SetInputDevice(InputDevice inputDevice)
        {
            this._inputDevice = inputDevice;
        }

        protected override void WndProc(ref Message m)
        {
            if (this._inputDevice != null)
            {
                this._inputDevice.ProcessMessage(m);
            }
            base.WndProc(ref m);
        }
    }
}
