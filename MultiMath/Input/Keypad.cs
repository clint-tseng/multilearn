using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RawInput;

namespace MultiLearn.Input
{
    public class Keypad : InputLayer
    {
        public event InputReadyEventHandler InputReady;
        public event InputOccurredEventHandler InputOccurred;

        private Dictionary<IntPtr, InputProxy> _proxies;

        private InputDevice _inputDevice;
        private KeypadForm _form;

        public void Initialize()
        {
            this._form = new KeypadForm();
            this._inputDevice = new InputDevice(this._form.Handle);
            this._form.SetInputDevice(this._inputDevice);
            int numberOfKeyboards = this._inputDevice.EnumerateDevices();

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += delegate(object sender, EventArgs e)
            {
                if (this._inputDevice.EnumerateDevices() < numberOfKeyboards)
                    MessageBox.Show("We seem to have lost a keypad.");
            };
            timer.Start();

            this._inputDevice.KeyPressed += new InputDevice.DeviceEventHandler(_inputDevice_KeyPressed);

            NumberOfPlayers numberOfPlayers = new NumberOfPlayers(numberOfKeyboards - 1);
            numberOfPlayers.NumberOfPlayersSelected += new NumberOfPlayersSelectedEventHandler(numberOfPlayers_NumberOfPlayersSelected);
            numberOfPlayers.Show();
        }

        void numberOfPlayers_NumberOfPlayersSelected(object sender, NumberOfPlayersSelectedEventArgs e)
        {
            KeypadSync keypadSync = new KeypadSync(e.NumberOfPlayers, this._inputDevice);
            keypadSync.KeypadsSynced += new KeypadsSyncedEventHandler(keypadSync_KeypadsSynced);
            keypadSync.Show();
        }

        void keypadSync_KeypadsSynced(object sender, KeypadsSyncedEventArgs e)
        {
            this._proxies = e.SyncedEntities;
            this.OnInputReady(new InputReadyEventArgs(this._proxies.Values.ToList<InputProxy>()));
        }

        void _inputDevice_KeyPressed(object sender, InputDevice.KeyControlEventArgs e)
        {
            InputOccurredEventArgs eventArgs = new InputOccurredEventArgs(new InputData(e.Keyboard.key));
            this.OnInputOccurred(eventArgs);
            if ((this._proxies != null) && (this._proxies.ContainsKey(e.Keyboard.deviceHandle)))
            {
                this._proxies[e.Keyboard.deviceHandle].OnInputOccurred(eventArgs);
            }
        }

        protected void OnInputReady(InputReadyEventArgs e)
        {
            if (this.InputReady != null)
            {
                this.InputReady(this, e);
            }
        }

        protected void OnInputOccurred(InputOccurredEventArgs e)
        {
            if (this.InputOccurred != null)
            {
                this.InputOccurred(this, e);
            }
        }
    }
}
