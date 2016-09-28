namespace Admin.UI
{
    partial class SpellingContentManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpellingContentManager));
            this._grid = new System.Windows.Forms.DataGridView();
            this.Word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Picture = new System.Windows.Forms.DataGridViewImageColumn();
            this._menu = new System.Windows.Forms.MenuStrip();
            this.fiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spellingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multipleChoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._toolbar = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this._grid)).BeginInit();
            this._menu.SuspendLayout();
            this._toolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // _grid
            // 
            this._grid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this._grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Word,
            this.Picture});
            this._grid.Location = new System.Drawing.Point(0, 52);
            this._grid.MultiSelect = false;
            this._grid.Name = "_grid";
            this._grid.RowHeadersVisible = false;
            this._grid.RowTemplate.Height = 100;
            this._grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._grid.Size = new System.Drawing.Size(416, 346);
            this._grid.TabIndex = 0;
            // 
            // Word
            // 
            this.Word.DataPropertyName = "Word";
            this.Word.HeaderText = "Word";
            this.Word.MaxInputLength = 32;
            this.Word.Name = "Word";
            this.Word.ToolTipText = "The word students need to spell";
            this.Word.Width = 200;
            // 
            // Picture
            // 
            this.Picture.DataPropertyName = "Image";
            this.Picture.HeaderText = "Picture";
            this.Picture.Name = "Picture";
            this.Picture.Width = 200;
            // 
            // _menu
            // 
            this._menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fiToolStripMenuItem,
            this.editToolStripMenuItem});
            this._menu.Location = new System.Drawing.Point(0, 0);
            this._menu.Name = "_menu";
            this._menu.Size = new System.Drawing.Size(416, 24);
            this._menu.TabIndex = 11;
            this._menu.Text = "menu";
            // 
            // fiToolStripMenuItem
            // 
            this.fiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neToolStripMenuItem,
            this.openSetToolStripMenuItem,
            this.saveSetToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fiToolStripMenuItem.Name = "fiToolStripMenuItem";
            this.fiToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fiToolStripMenuItem.Text = "File";
            // 
            // neToolStripMenuItem
            // 
            this.neToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spellingToolStripMenuItem,
            this.multipleChoiceToolStripMenuItem});
            this.neToolStripMenuItem.Name = "neToolStripMenuItem";
            this.neToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.neToolStripMenuItem.Text = "New Set";
            // 
            // spellingToolStripMenuItem
            // 
            this.spellingToolStripMenuItem.Name = "spellingToolStripMenuItem";
            this.spellingToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.spellingToolStripMenuItem.Text = "Spelling";
            // 
            // multipleChoiceToolStripMenuItem
            // 
            this.multipleChoiceToolStripMenuItem.Name = "multipleChoiceToolStripMenuItem";
            this.multipleChoiceToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.multipleChoiceToolStripMenuItem.Text = "Multiple Choice";
            // 
            // openSetToolStripMenuItem
            // 
            this.openSetToolStripMenuItem.Name = "openSetToolStripMenuItem";
            this.openSetToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.openSetToolStripMenuItem.Text = "Open Set";
            // 
            // saveSetToolStripMenuItem
            // 
            this.saveSetToolStripMenuItem.Name = "saveSetToolStripMenuItem";
            this.saveSetToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.saveSetToolStripMenuItem.Text = "Save Set";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.exitToolStripMenuItem.Text = "Main Menu";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // _toolbar
            // 
            this._toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this._toolbar.Location = new System.Drawing.Point(0, 24);
            this._toolbar.Name = "_toolbar";
            this._toolbar.Size = new System.Drawing.Size(416, 25);
            this._toolbar.TabIndex = 12;
            this._toolbar.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // SpellingContentManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 446);
            this.Controls.Add(this._toolbar);
            this.Controls.Add(this._menu);
            this.Controls.Add(this._grid);
            this.Name = "SpellingContentManager";
            this.Text = "SpellingContentManager";
            ((System.ComponentModel.ISupportInitialize)(this._grid)).EndInit();
            this._menu.ResumeLayout(false);
            this._menu.PerformLayout();
            this._toolbar.ResumeLayout(false);
            this._toolbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView _grid;
        private System.Windows.Forms.MenuStrip _menu;
        private System.Windows.Forms.ToolStripMenuItem fiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spellingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multipleChoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Word;
        private System.Windows.Forms.DataGridViewImageColumn Picture;
        private System.Windows.Forms.ToolStrip _toolbar;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}