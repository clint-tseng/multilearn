namespace MultiLearn.Login
{
    partial class LoginPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._entry_panel = new System.Windows.Forms.Panel();
            this._instructions2_label = new System.Windows.Forms.Label();
            this._instructions_label = new System.Windows.Forms.Label();
            this._color_panel = new System.Windows.Forms.Panel();
            this._entry_textbox = new System.Windows.Forms.Label();
            this._flash = new MultiLearn.Utilities.Flash();
            this._entry_panel.SuspendLayout();
            this._color_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _entry_panel
            // 
            this._entry_panel.Controls.Add(this._flash);
            this._entry_panel.Controls.Add(this._instructions2_label);
            this._entry_panel.Controls.Add(this._instructions_label);
            this._entry_panel.Controls.Add(this._color_panel);
            this._entry_panel.Location = new System.Drawing.Point(63, 91);
            this._entry_panel.Name = "_entry_panel";
            this._entry_panel.Size = new System.Drawing.Size(258, 250);
            this._entry_panel.TabIndex = 0;
            // 
            // _instructions2_label
            // 
            this._instructions2_label.AutoSize = true;
            this._instructions2_label.BackColor = System.Drawing.Color.Transparent;
            this._instructions2_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._instructions2_label.Location = new System.Drawing.Point(59, 49);
            this._instructions2_label.Name = "_instructions2_label";
            this._instructions2_label.Size = new System.Drawing.Size(150, 37);
            this._instructions2_label.TabIndex = 8;
            this._instructions2_label.Text = "number?";
            // 
            // _instructions_label
            // 
            this._instructions_label.AutoSize = true;
            this._instructions_label.BackColor = System.Drawing.Color.Transparent;
            this._instructions_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._instructions_label.Location = new System.Drawing.Point(30, 12);
            this._instructions_label.Name = "_instructions_label";
            this._instructions_label.Size = new System.Drawing.Size(200, 37);
            this._instructions_label.TabIndex = 7;
            this._instructions_label.Text = "what is your";
            // 
            // _color_panel
            // 
            this._color_panel.Controls.Add(this._entry_textbox);
            this._color_panel.Location = new System.Drawing.Point(46, 105);
            this._color_panel.Name = "_color_panel";
            this._color_panel.Size = new System.Drawing.Size(164, 73);
            this._color_panel.TabIndex = 6;
            // 
            // _entry_textbox
            // 
            this._entry_textbox.BackColor = System.Drawing.Color.White;
            this._entry_textbox.Font = new System.Drawing.Font("Consolas", 42F);
            this._entry_textbox.Location = new System.Drawing.Point(3, 3);
            this._entry_textbox.Name = "_entry_textbox";
            this._entry_textbox.Size = new System.Drawing.Size(158, 67);
            this._entry_textbox.TabIndex = 4;
            this._entry_textbox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _flash
            // 
            this._flash.BackColor = System.Drawing.Color.Transparent;
            this._flash.Location = new System.Drawing.Point(46, 184);
            this._flash.Name = "_flash";
            this._flash.Size = new System.Drawing.Size(164, 45);
            this._flash.TabIndex = 9;
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this._entry_panel);
            this.Name = "LoginPanel";
            this.Size = new System.Drawing.Size(400, 900);
            this.Resize += new System.EventHandler(this.LoginPanel_Resize);
            this._entry_panel.ResumeLayout(false);
            this._entry_panel.PerformLayout();
            this._color_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _entry_panel;
        private System.Windows.Forms.Label _instructions_label;
        private System.Windows.Forms.Panel _color_panel;
        private System.Windows.Forms.Label _entry_textbox;
        private System.Windows.Forms.Label _instructions2_label;
        private MultiLearn.Utilities.Flash _flash;

    }
}
