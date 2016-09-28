using System;
using System.Windows.Forms;
using MultiLearn.Input;

namespace MultiLearn.UI
{
    public partial class InputSelect : Form
    {
        public event InputTypeSelectedEventHandler InputTypeSelected;

        public InputSelect()
        {
            InitializeComponent();
        }

        /*private void _ok_button_Click(object sender, EventArgs e)
        {
            InputLayer inputLayer = null;
            switch (this._inputType_combo.Text)
            {
                case "Keypad":
                    inputLayer = new Keypad();
                    break;
                case "Default":
                    return;
            }
            this.OnInputTypeSelected(new InputTypeSelectedEventArgs(inputLayer));
            this.Close();
        }*/

        private void InputSelect_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // TODO: quit if user hits x
                //Application.Exit();
            }
        }

        protected void OnInputTypeSelected(InputTypeSelectedEventArgs e)
        {
            if (this.InputTypeSelected != null)
            {
                this.InputTypeSelected(this, e);
            }
        }

        private void _keypad_button_Click_1(object sender, EventArgs e)
        {
            InputLayer inputLayer = null;
            inputLayer = new Keypad();
            this.OnInputTypeSelected(new InputTypeSelectedEventArgs(inputLayer));
            this.Close();
        }

        private void _mouse_button_Click_1(object sender, EventArgs e)
        {

        }

        private void InputSelect_Load(object sender, EventArgs e)
        {

        }
    }

    public delegate void InputTypeSelectedEventHandler(object sender, InputTypeSelectedEventArgs e);

    public class InputTypeSelectedEventArgs : EventArgs
    {
        public InputLayer InputLayerObject
        {
            get { return this._inputLayerObject; }
        }
        private InputLayer _inputLayerObject;

        public InputTypeSelectedEventArgs(InputLayer inputLayerObject)
        {
            this._inputLayerObject = inputLayerObject;
        }
    }
}
