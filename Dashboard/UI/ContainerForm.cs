using System;
using System.Windows.Forms;
using System.Threading;
using MultiLearn.UI;

namespace MultiLearn.Dashboard.UI
{
    public partial class ContainerForm : Form
    {
        public ContainerForm()
        {
            InitializeComponent();

            Thread th = new Thread(new ThreadStart(DoSplash));
            th.Start();
            Thread.Sleep(1500);
            th.Abort();
        }

        private void DoSplash()
        {
            Splash sp = new Splash();
            sp.ShowDialog();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseChildren();
        }

        private void CloseChildren()
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewSet newSet = new NewSet();
            newSet.MdiParent = this;
            newSet.Show();
        }

        private void openSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilteredSetSelect filteredSetSelect = new FilteredSetSelect();
            filteredSetSelect.MdiParent = this;
            filteredSetSelect.Show();
        }

        private void viewStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticsViewer statisticsViewer = new StatisticsViewer();
            statisticsViewer.MdiParent = this;
            statisticsViewer.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseChildren();
            this.Close();
        }
    }
}
