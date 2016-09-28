namespace MultiLearn.Dashboard.UI
{
    partial class NewSet
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
            this._name_textbox = new System.Windows.Forms.TextBox();
            this._name_label = new System.Windows.Forms.Label();
            this._cancel_button = new System.Windows.Forms.Button();
            this._ok_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _type_label
            // 
            this._type_label.AutoSize = true;
            this._type_label.Location = new System.Drawing.Point(12, 9);
            this._type_label.Name = "_type_label";
            this._type_label.Size = new System.Drawing.Size(76, 13);
            this._type_label.TabIndex = 0;
            this._type_label.Text = "Question Type";
            // 
            // _type_combo
            // 
            this._type_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._type_combo.FormattingEnabled = true;
            this._type_combo.Location = new System.Drawing.Point(94, 6);
            this._type_combo.Name = "_type_combo";
            this._type_combo.Size = new System.Drawing.Size(275, 21);
            this._type_combo.TabIndex = 1;
            // 
            // _name_textbox
            // 
            this._name_textbox.Location = new System.Drawing.Point(94, 33);
            this._name_textbox.Name = "_name_textbox";
            this._name_textbox.Size = new System.Drawing.Size(275, 20);
            this._name_textbox.TabIndex = 2;
            // 
            // _name_label
            // 
            this._name_label.AutoSize = true;
            this._name_label.Location = new System.Drawing.Point(12, 36);
            this._name_label.Name = "_name_label";
            this._name_label.Size = new System.Drawing.Size(54, 13);
            this._name_label.TabIndex = 3;
            this._name_label.Text = "Set Name";
            // 
            // _cancel_button
            // 
            this._cancel_button.Location = new System.Drawing.Point(294, 59);
            this._cancel_button.Name = "_cancel_button";
            this._cancel_button.Size = new System.Drawing.Size(75, 23);
            this._cancel_button.TabIndex = 4;
            this._cancel_button.Text = "Cancel";
            this._cancel_button.UseVisualStyleBackColor = true;
            this._cancel_button.Click += new System.EventHandler(this._cancel_button_Click);
            // 
            // _ok_button
            // 
            this._ok_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ok_button.Location = new System.Drawing.Point(213, 59);
            this._ok_button.Name = "_ok_button";
            this._ok_button.Size = new System.Drawing.Size(75, 23);
            this._ok_button.TabIndex = 5;
            this._ok_button.Text = "OK";
            this._ok_button.UseVisualStyleBackColor = true;
            this._ok_button.Click += new System.EventHandler(this._ok_button_Click);
            // 
            // NewSet
            // 
            this.AcceptButton = this._ok_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._cancel_button;
            this.ClientSize = new System.Drawing.Size(381, 91);
            this.Controls.Add(this._ok_button);
            this.Controls.Add(this._cancel_button);
            this.Controls.Add(this._name_label);
            this.Controls.Add(this._name_textbox);
            this.Controls.Add(this._type_combo);
            this.Controls.Add(this._type_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewSet";
            this.Text = "New Set";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _type_label;
        private System.Windows.Forms.ComboBox _type_combo;
        private System.Windows.Forms.TextBox _name_textbox;
        private System.Windows.Forms.Label _name_label;
        private System.Windows.Forms.Button _cancel_button;
        private System.Windows.Forms.Button _ok_button;
    }
}