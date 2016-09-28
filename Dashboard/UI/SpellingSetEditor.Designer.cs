namespace MultiLearn.Dashboard.UI
{
    partial class SpellingSetEditor
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
            this._questions_list = new System.Windows.Forms.ListBox();
            this._word_label = new System.Windows.Forms.Label();
            this._word_textbox = new System.Windows.Forms.TextBox();
            this._newquestion_button = new System.Windows.Forms.Button();
            this._removequestion_button = new System.Windows.Forms.Button();
            this._words_group = new System.Windows.Forms.GroupBox();
            this._picture_label = new System.Windows.Forms.Label();
            this._picture_box = new System.Windows.Forms.PictureBox();
            this._changepicture_button = new System.Windows.Forms.Button();
            this._word_group = new System.Windows.Forms.GroupBox();
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
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statisticsForThisSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._open_dialog = new System.Windows.Forms.OpenFileDialog();
            this._words_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picture_box)).BeginInit();
            this._word_group.SuspendLayout();
            this._menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // _questions_list
            // 
            this._questions_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._questions_list.FormattingEnabled = true;
            this._questions_list.Location = new System.Drawing.Point(17, 19);
            this._questions_list.Name = "_questions_list";
            this._questions_list.Size = new System.Drawing.Size(328, 277);
            this._questions_list.TabIndex = 0;
            this._questions_list.SelectedIndexChanged += new System.EventHandler(this._questions_list_SelectedIndexChanged);
            // 
            // _word_label
            // 
            this._word_label.AutoSize = true;
            this._word_label.Location = new System.Drawing.Point(20, 34);
            this._word_label.Name = "_word_label";
            this._word_label.Size = new System.Drawing.Size(33, 13);
            this._word_label.TabIndex = 1;
            this._word_label.Text = "Word";
            // 
            // _word_textbox
            // 
            this._word_textbox.Location = new System.Drawing.Point(75, 31);
            this._word_textbox.Name = "_word_textbox";
            this._word_textbox.Size = new System.Drawing.Size(218, 20);
            this._word_textbox.TabIndex = 2;
            this._word_textbox.TextChanged += new System.EventHandler(this._word_textbox_TextChanged);
            this._word_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this._word_textbox_KeyDown);
            this._word_textbox.Leave += new System.EventHandler(this._word_textbox_Leave);
            // 
            // _newquestion_button
            // 
            this._newquestion_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._newquestion_button.Location = new System.Drawing.Point(189, 302);
            this._newquestion_button.Name = "_newquestion_button";
            this._newquestion_button.Size = new System.Drawing.Size(75, 23);
            this._newquestion_button.TabIndex = 3;
            this._newquestion_button.Text = "new";
            this._newquestion_button.UseVisualStyleBackColor = true;
            this._newquestion_button.Click += new System.EventHandler(this._newquestion_button_Click);
            // 
            // _removequestion_button
            // 
            this._removequestion_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._removequestion_button.Location = new System.Drawing.Point(270, 302);
            this._removequestion_button.Name = "_removequestion_button";
            this._removequestion_button.Size = new System.Drawing.Size(75, 23);
            this._removequestion_button.TabIndex = 4;
            this._removequestion_button.Text = "remove";
            this._removequestion_button.UseVisualStyleBackColor = true;
            this._removequestion_button.Click += new System.EventHandler(this._removequestion_button_Click);
            // 
            // _words_group
            // 
            this._words_group.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._words_group.Controls.Add(this._questions_list);
            this._words_group.Controls.Add(this._newquestion_button);
            this._words_group.Controls.Add(this._removequestion_button);
            this._words_group.Location = new System.Drawing.Point(12, 27);
            this._words_group.Name = "_words_group";
            this._words_group.Size = new System.Drawing.Size(362, 332);
            this._words_group.TabIndex = 5;
            this._words_group.TabStop = false;
            this._words_group.Text = "Words";
            // 
            // _picture_label
            // 
            this._picture_label.AutoSize = true;
            this._picture_label.Location = new System.Drawing.Point(20, 78);
            this._picture_label.Name = "_picture_label";
            this._picture_label.Size = new System.Drawing.Size(40, 13);
            this._picture_label.TabIndex = 6;
            this._picture_label.Text = "Picture";
            // 
            // _picture_box
            // 
            this._picture_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._picture_box.Location = new System.Drawing.Point(75, 78);
            this._picture_box.Name = "_picture_box";
            this._picture_box.Size = new System.Drawing.Size(218, 218);
            this._picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._picture_box.TabIndex = 7;
            this._picture_box.TabStop = false;
            // 
            // _changepicture_button
            // 
            this._changepicture_button.Location = new System.Drawing.Point(218, 302);
            this._changepicture_button.Name = "_changepicture_button";
            this._changepicture_button.Size = new System.Drawing.Size(75, 23);
            this._changepicture_button.TabIndex = 8;
            this._changepicture_button.Text = "change";
            this._changepicture_button.UseVisualStyleBackColor = true;
            this._changepicture_button.Click += new System.EventHandler(this._changepicture_button_Click);
            // 
            // _word_group
            // 
            this._word_group.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._word_group.Controls.Add(this._picture_box);
            this._word_group.Controls.Add(this._changepicture_button);
            this._word_group.Controls.Add(this._word_label);
            this._word_group.Controls.Add(this._word_textbox);
            this._word_group.Controls.Add(this._picture_label);
            this._word_group.Location = new System.Drawing.Point(380, 27);
            this._word_group.Name = "_word_group";
            this._word_group.Size = new System.Drawing.Size(310, 332);
            this._word_group.TabIndex = 9;
            this._word_group.TabStop = false;
            this._word_group.Text = "Edit Word Entry";
            // 
            // _menu
            // 
            this._menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fiToolStripMenuItem,
            this.viewToolStripMenuItem});
            this._menu.Location = new System.Drawing.Point(0, 0);
            this._menu.Name = "_menu";
            this._menu.Size = new System.Drawing.Size(702, 24);
            this._menu.TabIndex = 10;
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
            this.neToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.openSetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openSetToolStripMenuItem.Text = "Open Set";
            // 
            // saveSetToolStripMenuItem
            // 
            this.saveSetToolStripMenuItem.Name = "saveSetToolStripMenuItem";
            this.saveSetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveSetToolStripMenuItem.Text = "Save Set";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Main Menu";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.listViewToolStripMenuItem,
            this.toolStripSeparator2,
            this.statisticsForThisSetToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(183, 22);
            this.toolStripComboBox1.Text = "Grid View";
            // 
            // listViewToolStripMenuItem
            // 
            this.listViewToolStripMenuItem.Checked = true;
            this.listViewToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.listViewToolStripMenuItem.Name = "listViewToolStripMenuItem";
            this.listViewToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.listViewToolStripMenuItem.Text = "List View";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(180, 6);
            // 
            // statisticsForThisSetToolStripMenuItem
            // 
            this.statisticsForThisSetToolStripMenuItem.Name = "statisticsForThisSetToolStripMenuItem";
            this.statisticsForThisSetToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.statisticsForThisSetToolStripMenuItem.Text = "Statistics for this set";
            // 
            // _open_dialog
            // 
            this._open_dialog.Filter = "Image files|*.png;*.jpg;*.bmp;*.gif";
            this._open_dialog.RestoreDirectory = true;
            // 
            // SpellingSetEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 377);
            this.Controls.Add(this._word_group);
            this.Controls.Add(this._words_group);
            this.Controls.Add(this._menu);
            this.MainMenuStrip = this._menu;
            this.Name = "SpellingSetEditor";
            this.Text = "SETME";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SpellingGameEditor_FormClosing);
            this._words_group.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._picture_box)).EndInit();
            this._word_group.ResumeLayout(false);
            this._word_group.PerformLayout();
            this._menu.ResumeLayout(false);
            this._menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox _questions_list;
        private System.Windows.Forms.Label _word_label;
        private System.Windows.Forms.TextBox _word_textbox;
        private System.Windows.Forms.Button _newquestion_button;
        private System.Windows.Forms.Button _removequestion_button;
        private System.Windows.Forms.GroupBox _words_group;
        private System.Windows.Forms.Label _picture_label;
        private System.Windows.Forms.PictureBox _picture_box;
        private System.Windows.Forms.Button _changepicture_button;
        private System.Windows.Forms.GroupBox _word_group;
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
        private System.Windows.Forms.OpenFileDialog _open_dialog;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem listViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem statisticsForThisSetToolStripMenuItem;
    }
}