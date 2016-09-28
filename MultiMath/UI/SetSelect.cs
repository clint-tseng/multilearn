using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MultiLearn.Data;
using MultiLearn.Utilities;

namespace MultiLearn.UI
{
    public partial class SetSelect : Form
    {
        private QuestionSetType _filterType;

        public event SetSelectedEventHandler SetSelected;

        public SetSelect(QuestionSetType filterType)
        {
            this._filterType = filterType;

            InitializeComponent();

            string[] sets = Directory.GetFiles(Constants.Directories.Sets);
            sets = (from s in sets
                   where s.Contains(Misc.ExtensionForQuestionSetType(filterType))
                   select s).ToArray();

            for (int i = 0; i < sets.Count(); i++)
            {
                sets[i] = sets[i].Replace(string.Format("{0}\\", Constants.Directories.Sets), string.Empty)
                                 .Replace(string.Format(".{0}", Misc.ExtensionForQuestionSetType(filterType)), string.Empty);
            }
            this._sets_list.DataSource = sets;
        }

        private void _sets_list_DoubleClick(object sender, EventArgs e)
        {
            this._panel.Visible = false;
            this._loadingIndicator.Visible = true;
            this.OnSetSelected(new SetSelectedEventArgs(QuestionSetLoader.OpenQuestionSet(this._sets_list.Text, this._filterType)));
            this.Close();
        }

        protected void OnSetSelected(SetSelectedEventArgs e)
        {
            if (this.SetSelected != null)
            {
                this.SetSelected(this, e);
            }
        }
    }

    public delegate void SetSelectedEventHandler(object sender, SetSelectedEventArgs e);

    public class SetSelectedEventArgs : EventArgs
    {
        public QuestionSet set
        {
            get { return this._set; }
        }
        private QuestionSet _set;

        public SetSelectedEventArgs(QuestionSet set)
        {
            this._set = set;
        }
    }
}
