namespace MultiLearn.Dashboard.UI
{
    partial class MultipleChoiceSetEditor
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
            this._questions_group = new System.Windows.Forms.GroupBox();
            this._newquestion_button = new System.Windows.Forms.Button();
            this._removequestion_button = new System.Windows.Forms.Button();
            this._questions_list = new System.Windows.Forms.ListBox();
            this._menu = new System.Windows.Forms.MenuStrip();
            this.fiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statisticsForThisSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._question_group = new System.Windows.Forms.GroupBox();
            this._answer_E_textbox = new System.Windows.Forms.TextBox();
            this._answer_D_textbox = new System.Windows.Forms.TextBox();
            this._answer_C_textbox = new System.Windows.Forms.TextBox();
            this._answer_B_textbox = new System.Windows.Forms.TextBox();
            this._answer_A_textBox = new System.Windows.Forms.TextBox();
            this._answer_E = new System.Windows.Forms.Label();
            this._answer_D = new System.Windows.Forms.Label();
            this._answer_C = new System.Windows.Forms.Label();
            this._answer_B = new System.Windows.Forms.Label();
            this._answer_A = new System.Windows.Forms.Label();
            this._changepicture_button = new System.Windows.Forms.Button();
            this._picture_box = new System.Windows.Forms.PictureBox();
            this._picture_label = new System.Windows.Forms.Label();
            this._prompt_textbox = new System.Windows.Forms.TextBox();
            this._prompt_label = new System.Windows.Forms.Label();
            this._open_dialog = new System.Windows.Forms.OpenFileDialog();
            this._questions_group.SuspendLayout();
            this._menu.SuspendLayout();
            this._question_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picture_box)).BeginInit();
            this.SuspendLayout();
            // 
            // _questions_group
            // 
            this._questions_group.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._questions_group.Controls.Add(this._newquestion_button);
            this._questions_group.Controls.Add(this._removequestion_button);
            this._questions_group.Controls.Add(this._questions_list);
            this._questions_group.Location = new System.Drawing.Point(12, 27);
            this._questions_group.Name = "_questions_group";
            this._questions_group.Size = new System.Drawing.Size(325, 434);
            this._questions_group.TabIndex = 0;
            this._questions_group.TabStop = false;
            this._questions_group.Text = "Questions";
            // 
            // _newquestion_button
            // 
            this._newquestion_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._newquestion_button.Location = new System.Drawing.Point(151, 400);
            this._newquestion_button.Name = "_newquestion_button";
            this._newquestion_button.Size = new System.Drawing.Size(75, 23);
            this._newquestion_button.TabIndex = 5;
            this._newquestion_button.Text = "new";
            this._newquestion_button.UseVisualStyleBackColor = true;
            this._newquestion_button.Click += new System.EventHandler(this._newquestion_button_Click);
            // 
            // _removequestion_button
            // 
            this._removequestion_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._removequestion_button.Location = new System.Drawing.Point(232, 400);
            this._removequestion_button.Name = "_removequestion_button";
            this._removequestion_button.Size = new System.Drawing.Size(75, 23);
            this._removequestion_button.TabIndex = 6;
            this._removequestion_button.Text = "remove";
            this._removequestion_button.UseVisualStyleBackColor = true;
            this._removequestion_button.Click += new System.EventHandler(this._removequestion_button_Click);
            // 
            // _questions_list
            // 
            this._questions_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._questions_list.FormattingEnabled = true;
            this._questions_list.Location = new System.Drawing.Point(16, 22);
            this._questions_list.Name = "_questions_list";
            this._questions_list.Size = new System.Drawing.Size(291, 368);
            this._questions_list.TabIndex = 1;
            this._questions_list.SelectedIndexChanged += new System.EventHandler(this._questions_list_SelectedIndexChanged);
            // 
            // _menu
            // 
            this._menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fiToolStripMenuItem,
            this.viewToolStripMenuItem});
            this._menu.Location = new System.Drawing.Point(0, 0);
            this._menu.Name = "_menu";
            this._menu.Size = new System.Drawing.Size(762, 24);
            this._menu.TabIndex = 11;
            this._menu.Text = "menu";
            // 
            // fiToolStripMenuItem
            // 
            this.fiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSetToolStripMenuItem,
            this.openSetToolStripMenuItem,
            this.saveSetToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem1});
            this.fiToolStripMenuItem.Name = "fiToolStripMenuItem";
            this.fiToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fiToolStripMenuItem.Text = "File";
            // 
            // newSetToolStripMenuItem
            // 
            this.newSetToolStripMenuItem.Name = "newSetToolStripMenuItem";
            this.newSetToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.newSetToolStripMenuItem.Text = "New Set";
            this.newSetToolStripMenuItem.Click += new System.EventHandler(this.newSetToolStripMenuItem_Click);
            // 
            // openSetToolStripMenuItem
            // 
            this.openSetToolStripMenuItem.Name = "openSetToolStripMenuItem";
            this.openSetToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.openSetToolStripMenuItem.Text = "Open Set";
            this.openSetToolStripMenuItem.Click += new System.EventHandler(this.openSetToolStripMenuItem_Click);
            // 
            // saveSetToolStripMenuItem
            // 
            this.saveSetToolStripMenuItem.Name = "saveSetToolStripMenuItem";
            this.saveSetToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.saveSetToolStripMenuItem.Text = "Save Set";
            this.saveSetToolStripMenuItem.Click += new System.EventHandler(this.saveSetToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(127, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.exitToolStripMenuItem1.Text = "Close";
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
            // _question_group
            // 
            this._question_group.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._question_group.Controls.Add(this._answer_E_textbox);
            this._question_group.Controls.Add(this._answer_D_textbox);
            this._question_group.Controls.Add(this._answer_C_textbox);
            this._question_group.Controls.Add(this._answer_B_textbox);
            this._question_group.Controls.Add(this._answer_A_textBox);
            this._question_group.Controls.Add(this._answer_E);
            this._question_group.Controls.Add(this._answer_D);
            this._question_group.Controls.Add(this._answer_C);
            this._question_group.Controls.Add(this._answer_B);
            this._question_group.Controls.Add(this._answer_A);
            this._question_group.Controls.Add(this._changepicture_button);
            this._question_group.Controls.Add(this._picture_box);
            this._question_group.Controls.Add(this._picture_label);
            this._question_group.Controls.Add(this._prompt_textbox);
            this._question_group.Controls.Add(this._prompt_label);
            this._question_group.Location = new System.Drawing.Point(343, 27);
            this._question_group.Name = "_question_group";
            this._question_group.Size = new System.Drawing.Size(407, 434);
            this._question_group.TabIndex = 12;
            this._question_group.TabStop = false;
            this._question_group.Text = "Question";
            // 
            // _answer_E_textbox
            // 
            this._answer_E_textbox.Location = new System.Drawing.Point(39, 394);
            this._answer_E_textbox.Name = "_answer_E_textbox";
            this._answer_E_textbox.Size = new System.Drawing.Size(353, 20);
            this._answer_E_textbox.TabIndex = 27;
            // 
            // _answer_D_textbox
            // 
            this._answer_D_textbox.Location = new System.Drawing.Point(39, 368);
            this._answer_D_textbox.Name = "_answer_D_textbox";
            this._answer_D_textbox.Size = new System.Drawing.Size(353, 20);
            this._answer_D_textbox.TabIndex = 26;
            // 
            // _answer_C_textbox
            // 
            this._answer_C_textbox.Location = new System.Drawing.Point(39, 342);
            this._answer_C_textbox.Name = "_answer_C_textbox";
            this._answer_C_textbox.Size = new System.Drawing.Size(353, 20);
            this._answer_C_textbox.TabIndex = 25;
            // 
            // _answer_B_textbox
            // 
            this._answer_B_textbox.Location = new System.Drawing.Point(39, 316);
            this._answer_B_textbox.Name = "_answer_B_textbox";
            this._answer_B_textbox.Size = new System.Drawing.Size(353, 20);
            this._answer_B_textbox.TabIndex = 24;
            // 
            // _answer_A_textBox
            // 
            this._answer_A_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._answer_A_textBox.Location = new System.Drawing.Point(39, 291);
            this._answer_A_textBox.Name = "_answer_A_textBox";
            this._answer_A_textBox.Size = new System.Drawing.Size(353, 20);
            this._answer_A_textBox.TabIndex = 13;
            // 
            // _answer_E
            // 
            this._answer_E.AutoSize = true;
            this._answer_E.Location = new System.Drawing.Point(19, 397);
            this._answer_E.Name = "_answer_E";
            this._answer_E.Size = new System.Drawing.Size(14, 13);
            this._answer_E.TabIndex = 23;
            this._answer_E.Text = "E";
            // 
            // _answer_D
            // 
            this._answer_D.AutoSize = true;
            this._answer_D.Location = new System.Drawing.Point(19, 371);
            this._answer_D.Name = "_answer_D";
            this._answer_D.Size = new System.Drawing.Size(15, 13);
            this._answer_D.TabIndex = 21;
            this._answer_D.Text = "D";
            // 
            // _answer_C
            // 
            this._answer_C.AutoSize = true;
            this._answer_C.Location = new System.Drawing.Point(19, 345);
            this._answer_C.Name = "_answer_C";
            this._answer_C.Size = new System.Drawing.Size(14, 13);
            this._answer_C.TabIndex = 20;
            this._answer_C.Text = "C";
            // 
            // _answer_B
            // 
            this._answer_B.AutoSize = true;
            this._answer_B.Location = new System.Drawing.Point(19, 319);
            this._answer_B.Name = "_answer_B";
            this._answer_B.Size = new System.Drawing.Size(14, 13);
            this._answer_B.TabIndex = 17;
            this._answer_B.Text = "B";
            // 
            // _answer_A
            // 
            this._answer_A.AutoSize = true;
            this._answer_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._answer_A.Location = new System.Drawing.Point(19, 294);
            this._answer_A.Name = "_answer_A";
            this._answer_A.Size = new System.Drawing.Size(15, 13);
            this._answer_A.TabIndex = 16;
            this._answer_A.Text = "A";
            // 
            // _changepicture_button
            // 
            this._changepicture_button.Location = new System.Drawing.Point(271, 255);
            this._changepicture_button.Name = "_changepicture_button";
            this._changepicture_button.Size = new System.Drawing.Size(75, 23);
            this._changepicture_button.TabIndex = 12;
            this._changepicture_button.Text = "change";
            this._changepicture_button.UseVisualStyleBackColor = true;
            this._changepicture_button.Click += new System.EventHandler(this._changepicture_button_Click);
            // 
            // _picture_box
            // 
            this._picture_box.Location = new System.Drawing.Point(65, 78);
            this._picture_box.Name = "_picture_box";
            this._picture_box.Size = new System.Drawing.Size(200, 200);
            this._picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._picture_box.TabIndex = 14;
            this._picture_box.TabStop = false;
            // 
            // _picture_label
            // 
            this._picture_label.AutoSize = true;
            this._picture_label.Location = new System.Drawing.Point(19, 78);
            this._picture_label.Name = "_picture_label";
            this._picture_label.Size = new System.Drawing.Size(40, 13);
            this._picture_label.TabIndex = 13;
            this._picture_label.Text = "Picture";
            // 
            // _prompt_textbox
            // 
            this._prompt_textbox.Location = new System.Drawing.Point(65, 19);
            this._prompt_textbox.Multiline = true;
            this._prompt_textbox.Name = "_prompt_textbox";
            this._prompt_textbox.Size = new System.Drawing.Size(327, 45);
            this._prompt_textbox.TabIndex = 11;
            this._prompt_textbox.TextChanged += new System.EventHandler(this._textbox_TextChanged);
            this._prompt_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this._textbox_KeyDown);
            this._prompt_textbox.Leave += new System.EventHandler(this._textbox_Leave);
            // 
            // _prompt_label
            // 
            this._prompt_label.AutoSize = true;
            this._prompt_label.Location = new System.Drawing.Point(19, 22);
            this._prompt_label.Name = "_prompt_label";
            this._prompt_label.Size = new System.Drawing.Size(40, 13);
            this._prompt_label.TabIndex = 0;
            this._prompt_label.Text = "Prompt";
            // 
            // _open_dialog
            // 
            this._open_dialog.Filter = "Image files|*.png;*.jpg;*.bmp;*.gif";
            this._open_dialog.RestoreDirectory = true;
            // 
            // MultipleChoiceSetEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 473);
            this.Controls.Add(this._question_group);
            this.Controls.Add(this._menu);
            this.Controls.Add(this._questions_group);
            this.Name = "MultipleChoiceSetEditor";
            this.Text = "SETME";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MultipleChoiceSetEditor_FormClosing);
            this._questions_group.ResumeLayout(false);
            this._menu.ResumeLayout(false);
            this._menu.PerformLayout();
            this._question_group.ResumeLayout(false);
            this._question_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picture_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox _questions_group;
        private System.Windows.Forms.MenuStrip _menu;
        private System.Windows.Forms.ToolStripMenuItem fiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem listViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem statisticsForThisSetToolStripMenuItem;
        private System.Windows.Forms.Button _newquestion_button;
        private System.Windows.Forms.Button _removequestion_button;
        private System.Windows.Forms.ListBox _questions_list;
        private System.Windows.Forms.GroupBox _question_group;
        private System.Windows.Forms.PictureBox _picture_box;
        private System.Windows.Forms.Label _picture_label;
        private System.Windows.Forms.TextBox _prompt_textbox;
        private System.Windows.Forms.Label _prompt_label;
        private System.Windows.Forms.Button _changepicture_button;
        private System.Windows.Forms.Label _answer_A;
        private System.Windows.Forms.Label _answer_B;
        private System.Windows.Forms.Label _answer_C;
        private System.Windows.Forms.Label _answer_D;
        private System.Windows.Forms.Label _answer_E;
        private System.Windows.Forms.OpenFileDialog _open_dialog;
        private System.Windows.Forms.TextBox _answer_E_textbox;
        private System.Windows.Forms.TextBox _answer_D_textbox;
        private System.Windows.Forms.TextBox _answer_C_textbox;
        private System.Windows.Forms.TextBox _answer_B_textbox;
        private System.Windows.Forms.TextBox _answer_A_textBox;
        private System.Windows.Forms.TextBox[] _answers;
    }
}