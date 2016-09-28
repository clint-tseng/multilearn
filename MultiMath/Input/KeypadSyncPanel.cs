using System.Drawing;
using System.Windows.Forms;

namespace MultiLearn.Input
{
    public partial class KeypadSyncPanel : UserControl
    {
        public KeypadSyncPanel(Color color, int number)
        {
            InitializeComponent();
            this._number_label.Text = number.ToString();

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeypadSyncPanel));

            switch (number)
            {
                case 1:
                    this._color_picture.Image = ((System.Drawing.Image)(resources.GetObject("sync1")));
                    break;
                case 3:
                    this._color_picture.Image = ((System.Drawing.Image)(resources.GetObject("sync3")));
                    break;
                case 5:
                    this._color_picture.Image = ((System.Drawing.Image)(resources.GetObject("sync5")));
                    break;
                case 7:
                    this._color_picture.Image = ((System.Drawing.Image)(resources.GetObject("sync7")));
                    break;
            }
        }

        public void MarkAsSynced()
        {
            this.Visible = false;
        }

    }
}
