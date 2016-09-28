namespace MultiLearn.Input
{
    partial class KeypadSyncPanel
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
            this._color_picture = new System.Windows.Forms.PictureBox();
            this._press_label = new System.Windows.Forms.Label();
            this._number_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._color_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // _color_picture
            // 
            this._color_picture.BackColor = System.Drawing.Color.Transparent;
            this._color_picture.Location = new System.Drawing.Point(86, 36);
            this._color_picture.Name = "_color_picture";
            this._color_picture.Size = new System.Drawing.Size(180, 228);
            this._color_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._color_picture.TabIndex = 0;
            this._color_picture.TabStop = false;
            // 
            // _press_label
            // 
            this._press_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._press_label.AutoSize = true;
            this._press_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._press_label.Location = new System.Drawing.Point(156, 267);
            this._press_label.Name = "_press_label";
            this._press_label.Size = new System.Drawing.Size(56, 24);
            this._press_label.TabIndex = 1;
            this._press_label.Text = "press";
            this._press_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _number_label
            // 
            this._number_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._number_label.AutoSize = true;
            this._number_label.BackColor = System.Drawing.Color.Transparent;
            this._number_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._number_label.Location = new System.Drawing.Point(166, 304);
            this._number_label.Name = "_number_label";
            this._number_label.Size = new System.Drawing.Size(33, 37);
            this._number_label.TabIndex = 2;
            this._number_label.Text = "1";
            this._number_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KeypadSyncPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this._number_label);
            this.Controls.Add(this._press_label);
            this.Controls.Add(this._color_picture);
            this.Name = "KeypadSyncPanel";
            this.Size = new System.Drawing.Size(775, 572);
            ((System.ComponentModel.ISupportInitialize)(this._color_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox _color_picture;
        private System.Windows.Forms.Label _press_label;
        private System.Windows.Forms.Label _number_label;
    }
}
