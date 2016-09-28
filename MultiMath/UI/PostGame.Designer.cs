namespace MultiLearn.UI
{
    partial class PostGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostGame));
            this._panel = new System.Windows.Forms.Panel();
            this._loginButton = new System.Windows.Forms.Button();
            this._restartButton = new System.Windows.Forms.Button();
            this._panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panel
            // 
            this._panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._panel.Controls.Add(this._loginButton);
            this._panel.Controls.Add(this._restartButton);
            this._panel.Location = new System.Drawing.Point(0, 0);
            this._panel.Name = "_panel";
            this._panel.Size = new System.Drawing.Size(500, 300);
            this._panel.TabIndex = 0;
            // 
            // _loginButton
            // 
            this._loginButton.BackColor = System.Drawing.Color.YellowGreen;
            this._loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._loginButton.Image = ((System.Drawing.Image)(resources.GetObject("_loginButton.Image")));
            this._loginButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._loginButton.Location = new System.Drawing.Point(268, 51);
            this._loginButton.Name = "_loginButton";
            this._loginButton.Size = new System.Drawing.Size(175, 198);
            this._loginButton.TabIndex = 1;
            this._loginButton.Text = "New Players";
            this._loginButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this._loginButton.UseVisualStyleBackColor = false;
            this._loginButton.Click += new System.EventHandler(this._loginButton_Click);
            // 
            // _restartButton
            // 
            this._restartButton.BackColor = System.Drawing.Color.YellowGreen;
            this._restartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._restartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._restartButton.Image = ((System.Drawing.Image)(resources.GetObject("_restartButton.Image")));
            this._restartButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._restartButton.Location = new System.Drawing.Point(58, 51);
            this._restartButton.Name = "_restartButton";
            this._restartButton.Size = new System.Drawing.Size(175, 198);
            this._restartButton.TabIndex = 0;
            this._restartButton.Text = "Restart Game";
            this._restartButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this._restartButton.UseVisualStyleBackColor = false;
            this._restartButton.Click += new System.EventHandler(this._restartButton_Click);
            // 
            // PostGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this._panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PostGame";
            this.Text = "PostGame";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this._panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _panel;
        private System.Windows.Forms.Button _restartButton;
        private System.Windows.Forms.Button _loginButton;
    }
}