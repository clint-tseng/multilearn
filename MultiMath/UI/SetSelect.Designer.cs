namespace MultiLearn.UI
{
    partial class SetSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetSelect));
            this._instructions_label = new System.Windows.Forms.Label();
            this._sets_list = new System.Windows.Forms.ListBox();
            this._panel = new System.Windows.Forms.Panel();
            this._loadingIndicator = new System.Windows.Forms.PictureBox();
            this._panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._loadingIndicator)).BeginInit();
            this.SuspendLayout();
            // 
            // _instructions_label
            // 
            this._instructions_label.AutoSize = true;
            this._instructions_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._instructions_label.Location = new System.Drawing.Point(75, 10);
            this._instructions_label.Name = "_instructions_label";
            this._instructions_label.Size = new System.Drawing.Size(351, 39);
            this._instructions_label.TabIndex = 0;
            this._instructions_label.Text = "Which Problem Set?";
            // 
            // _sets_list
            // 
            this._sets_list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._sets_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._sets_list.FormattingEnabled = true;
            this._sets_list.ItemHeight = 33;
            this._sets_list.Location = new System.Drawing.Point(12, 61);
            this._sets_list.Name = "_sets_list";
            this._sets_list.Size = new System.Drawing.Size(477, 266);
            this._sets_list.TabIndex = 1;
            this._sets_list.DoubleClick += new System.EventHandler(this._sets_list_DoubleClick);
            // 
            // _panel
            // 
            this._panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._panel.Controls.Add(this._sets_list);
            this._panel.Controls.Add(this._instructions_label);
            this._panel.Location = new System.Drawing.Point(0, 0);
            this._panel.Name = "_panel";
            this._panel.Size = new System.Drawing.Size(500, 350);
            this._panel.TabIndex = 2;
            // 
            // _loadingIndicator
            // 
            this._loadingIndicator.BackColor = System.Drawing.Color.Transparent;
            this._loadingIndicator.Image = ((System.Drawing.Image)(resources.GetObject("_loadingIndicator.Image")));
            this._loadingIndicator.Location = new System.Drawing.Point(140, 166);
            this._loadingIndicator.Name = "_loadingIndicator";
            this._loadingIndicator.Size = new System.Drawing.Size(220, 19);
            this._loadingIndicator.TabIndex = 2;
            this._loadingIndicator.TabStop = false;
            this._loadingIndicator.Visible = false;
            // 
            // SetSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this._panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SetSelect";
            this.Text = "SetSelect";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this._panel.ResumeLayout(false);
            this._panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._loadingIndicator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _instructions_label;
        private System.Windows.Forms.ListBox _sets_list;
        private System.Windows.Forms.Panel _panel;
        private System.Windows.Forms.PictureBox _loadingIndicator;
    }
}