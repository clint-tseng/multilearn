namespace MultiLearn.Dashboard.UI
{
    partial class FilteredSetSelect
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
            this._type_label = new System.Windows.Forms.Label();
            this._type_combo = new System.Windows.Forms.ComboBox();
            this._sets_list = new System.Windows.Forms.ListBox();
            this._cancel_button = new System.Windows.Forms.Button();
            this._open_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _type_label
            // 
            this._type_label.AutoSize = true;
            this._type_label.Location = new System.Drawing.Point(12, 9);
            this._type_label.Name = "_type_label";
            this._type_label.Size = new System.Drawing.Size(68, 13);
            this._type_label.TabIndex = 0;
            this._type_label.Text = "Problem type";
            // 
            // _type_combo
            // 
            this._type_combo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._type_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._type_combo.FormattingEnabled = true;
            this._type_combo.Location = new System.Drawing.Point(86, 6);
            this._type_combo.Name = "_type_combo";
            this._type_combo.Size = new System.Drawing.Size(269, 21);
            this._type_combo.TabIndex = 1;
            this._type_combo.SelectedIndexChanged += new System.EventHandler(this._type_combo_SelectedIndexChanged);
            // 
            // _sets_list
            // 
            this._sets_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._sets_list.FormattingEnabled = true;
            this._sets_list.Location = new System.Drawing.Point(12, 33);
            this._sets_list.Name = "_sets_list";
            this._sets_list.Size = new System.Drawing.Size(343, 238);
            this._sets_list.TabIndex = 2;
            // 
            // _cancel_button
            // 
            this._cancel_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancel_button.Location = new System.Drawing.Point(280, 277);
            this._cancel_button.Name = "_cancel_button";
            this._cancel_button.Size = new System.Drawing.Size(75, 23);
            this._cancel_button.TabIndex = 3;
            this._cancel_button.Text = "Cancel";
            this._cancel_button.UseVisualStyleBackColor = true;
            this._cancel_button.Click += new System.EventHandler(this._cancel_button_Click);
            // 
            // _open_button
            // 
            this._open_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._open_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._open_button.Location = new System.Drawing.Point(199, 277);
            this._open_button.Name = "_open_button";
            this._open_button.Size = new System.Drawing.Size(75, 23);
            this._open_button.TabIndex = 4;
            this._open_button.Text = "Open";
            this._open_button.UseVisualStyleBackColor = true;
            this._open_button.Click += new System.EventHandler(this._open_button_Click);
            // 
            // FilteredSetSelect
            // 
            this.AcceptButton = this._open_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._cancel_button;
            this.ClientSize = new System.Drawing.Size(367, 309);
            this.Controls.Add(this._open_button);
            this.Controls.Add(this._cancel_button);
            this.Controls.Add(this._sets_list);
            this.Controls.Add(this._type_combo);
            this.Controls.Add(this._type_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FilteredSetSelect";
            this.Text = "Open Set";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _type_label;
        private System.Windows.Forms.ComboBox _type_combo;
        private System.Windows.Forms.ListBox _sets_list;
        private System.Windows.Forms.Button _cancel_button;
        private System.Windows.Forms.Button _open_button;
    }
}