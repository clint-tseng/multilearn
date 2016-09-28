namespace MultiLearn.Utilities
{
    partial class Flash
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
            this.components = new System.ComponentModel.Container();
            this._text_label = new System.Windows.Forms.Label();
            this._fade_timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // _text_label
            // 
            this._text_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._text_label.ForeColor = System.Drawing.Color.Black;
            this._text_label.Location = new System.Drawing.Point(0, 0);
            this._text_label.Name = "_text_label";
            this._text_label.Size = new System.Drawing.Size(68, 37);
            this._text_label.TabIndex = 0;
            this._text_label.Text = "yes";
            this._text_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _fade_timer
            // 
            this._fade_timer.Interval = 10;
            this._fade_timer.Tick += new System.EventHandler(this._fade_timer_Tick);
            // 
            // Flash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this._text_label);
            this.Name = "Flash";
            this.Size = new System.Drawing.Size(63, 45);
            this.Resize += new System.EventHandler(this.Flash_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _text_label;
        private System.Windows.Forms.Timer _fade_timer;
    }
}
