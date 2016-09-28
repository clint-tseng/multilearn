using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using RawInput;

namespace MultiLearn.Input
{
    public partial class KeypadSync : Form
    {
        private int _numberOfPlayers;
        private KeypadSyncPanel[] _panels;

        public event KeypadsSyncedEventHandler KeypadsSynced;

        private Dictionary<IntPtr, InputProxy> _syncedEntities;

        public KeypadSync(int numberOfPlayers, InputDevice inputDevice)
        {
            this._numberOfPlayers = numberOfPlayers;
            this._panels = new KeypadSyncPanel[this._numberOfPlayers];
            this._syncedEntities = new Dictionary<IntPtr, InputProxy>();

            inputDevice.KeyPressed += new InputDevice.DeviceEventHandler(inputDevice_KeyPressed);

            for (int i = 0; i < this._numberOfPlayers; i++)
            {
                this._panels[i] = new KeypadSyncPanel(Constants.Keypad.DefaultColors[i], (i * 2) + 1);
                this._panels[i].Location = new Point(i * 150, 0);
                this.Controls.Add(this._panels[i]);
            }

            InitializeComponent();

            this.Width = this._numberOfPlayers * 150;
        }

        protected void inputDevice_KeyPressed(object sender, InputDevice.KeyControlEventArgs e)
        {
            int index = (e.Keyboard.key - 48) / 2; //[[VMWARE]]
            if ((index < 0) || (index >= this._numberOfPlayers))
                index = (e.Keyboard.key - 96) / 2; //[[WIH KEYPADS]]
            if ((index >= 0) && (index < this._numberOfPlayers) && !(this._syncedEntities.ContainsKey(e.Keyboard.deviceHandle)))
            {
                this._panels[index].MarkAsSynced();
                this._syncedEntities.Add(e.Keyboard.deviceHandle, new InputProxy(Constants.Keypad.DefaultColors[index]));
            }

            if (this._syncedEntities.Count == this._numberOfPlayers)
            {
                this.OnKeypadsSynced(new KeypadsSyncedEventArgs(this._syncedEntities));
                this.Close();
                this.Dispose();
                this._numberOfPlayers = -1;
            }
        }

        public void OnKeypadsSynced(KeypadsSyncedEventArgs e)
        {
            if (this.KeypadsSynced != null)
            {
                this.KeypadsSynced(this, e);
            }
        }
    }

    public delegate void KeypadsSyncedEventHandler(object sender, KeypadsSyncedEventArgs e);

    public class KeypadsSyncedEventArgs : EventArgs
    {
        public Dictionary<IntPtr, InputProxy> SyncedEntities
        {
            get { return this._syncedEntities; }
        }
        private Dictionary<IntPtr, InputProxy> _syncedEntities;

        public KeypadsSyncedEventArgs(Dictionary<IntPtr, InputProxy> syncedEntities)
        {
            this._syncedEntities = syncedEntities;
        }
    }
}