namespace MultiLearn.UI
{
    partial class InputSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputSelect));
            this._typeSelect_label = new System.Windows.Forms.Label();
            this._mouse_button = new System.Windows.Forms.Button();
            this._keypad_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _typeSelect_label
            // 
            this._typeSelect_label.AutoSize = true;
            this._typeSelect_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._typeSelect_label.Location = new System.Drawing.Point(44, 44);
            this._typeSelect_label.Name = "_typeSelect_label";
            this._typeSelect_label.Size = new System.Drawing.Size(543, 37);
            this._typeSelect_label.TabIndex = 0;
            this._typeSelect_label.Text = "Select the type of input to be used:";
            // 
            // _mouse_button
            // 
            this._mouse_button.BackColor = System.Drawing.Color.YellowGreen;
            this._mouse_button.Image = ((System.Drawing.Image)(resources.GetObject("_mouse_button.Image")));
            this._mouse_button.Location = new System.Drawing.Point(350, 153);
            this._mouse_button.Name = "_mouse_button";
            this._mouse_button.Size = new System.Drawing.Size(170, 172);
            this._mouse_button.TabIndex = 4;
            this._mouse_button.UseVisualStyleBackColor = false;
            this._mouse_button.Click += new System.EventHandler(this._mouse_button_Click_1);
            // 
            // _keypad_button
            // 
            this._keypad_button.BackColor = System.Drawing.Color.YellowGreen;
            this._keypad_button.Image = ((System.Drawing.Image)(resources.GetObject("_keypad_button.Image")));
            this._keypad_button.Location = new System.Drawing.Point(51, 153);
            this._keypad_button.Name = "_keypad_button";
            this._keypad_button.Size = new System.Drawing.Size(170, 172);
            this._keypad_button.TabIndex = 5;
            this._keypad_button.UseVisualStyleBackColor = false;
            this._keypad_button.Click += new System.EventHandler(this._keypad_button_Click_1);
            // 
            // InputSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(762, 446);
            this.Controls.Add(this._mouse_button);
            this.Controls.Add(this._keypad_button);
            this.Controls.Add(this._typeSelect_label);
            this.MaximizeBox = false;
            this.Name = "InputSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input Select";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InputSelect_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InputSelect_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _typeSelect_label;
        private System.Windows.Forms.Button _mouse_button;
        private System.Windows.Forms.Button _keypad_button;
    }
}