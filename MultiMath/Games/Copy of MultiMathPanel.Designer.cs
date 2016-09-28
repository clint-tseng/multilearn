using MultiLearn.Utilities;
namespace MultiLearn.Games
{
    partial class MultiMathPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiMathPanel));
            this._a_label = new System.Windows.Forms.Label();
            this._b_label = new System.Windows.Forms.Label();
            this._operand_label = new System.Windows.Forms.Label();
            this._line_panel = new System.Windows.Forms.Panel();
            this._entry_textbox = new System.Windows.Forms.Label();
            this._container_panel = new System.Windows.Forms.Panel();
            this._singleLine_label = new System.Windows.Forms.Label();
            this._color_panel = new System.Windows.Forms.Panel();
            this._winnerTrophyPictureBox = new System.Windows.Forms.PictureBox();
            this._flash = new MultiLearn.Utilities.Flash();
            this._container_panel.SuspendLayout();
            this._color_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._winnerTrophyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _a_label
            // 
            this._a_label.AutoSize = true;
            this._a_label.Font = new System.Drawing.Font("Consolas", 42F);
            this._a_label.Location = new System.Drawing.Point(61, 1);
            this._a_label.Name = "_a_label";
            this._a_label.Size = new System.Drawing.Size(121, 66);
            this._a_label.TabIndex = 0;
            this._a_label.Text = "123";
            this._a_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _b_label
            // 
            this._b_label.AutoSize = true;
            this._b_label.Font = new System.Drawing.Font("Consolas", 42F);
            this._b_label.Location = new System.Drawing.Point(61, 55);
            this._b_label.Name = "_b_label";
            this._b_label.Size = new System.Drawing.Size(121, 66);
            this._b_label.TabIndex = 1;
            this._b_label.Text = "123";
            this._b_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _operand_label
            // 
            this._operand_label.AutoSize = true;
            this._operand_label.Font = new System.Drawing.Font("Consolas", 54F);
            this._operand_label.Location = new System.Drawing.Point(10, 43);
            this._operand_label.Name = "_operand_label";
            this._operand_label.Size = new System.Drawing.Size(75, 84);
            this._operand_label.TabIndex = 2;
            this._operand_label.Text = "+";
            // 
            // _line_panel
            // 
            this._line_panel.BackColor = System.Drawing.Color.Black;
            this._line_panel.Location = new System.Drawing.Point(6, 113);
            this._line_panel.Name = "_line_panel";
            this._line_panel.Size = new System.Drawing.Size(200, 3);
            this._line_panel.TabIndex = 3;
            // 
            // _entry_textbox
            // 
            this._entry_textbox.BackColor = System.Drawing.Color.White;
            this._entry_textbox.Font = new System.Drawing.Font("Consolas", 42F);
            this._entry_textbox.Location = new System.Drawing.Point(3, 3);
            this._entry_textbox.Name = "_entry_textbox";
            this._entry_textbox.Size = new System.Drawing.Size(158, 65);
            this._entry_textbox.TabIndex = 4;
            this._entry_textbox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _container_panel
            // 
            this._container_panel.Controls.Add(this._singleLine_label);
            this._container_panel.Controls.Add(this._color_panel);
            this._container_panel.Controls.Add(this._line_panel);
            this._container_panel.Controls.Add(this._b_label);
            this._container_panel.Controls.Add(this._a_label);
            this._container_panel.Controls.Add(this._operand_label);
            this._container_panel.Location = new System.Drawing.Point(44, 138);
            this._container_panel.Name = "_container_panel";
            this._container_panel.Size = new System.Drawing.Size(214, 203);
            this._container_panel.TabIndex = 5;
            // 
            // _singleLine_label
            // 
            this._singleLine_label.AutoSize = true;
            this._singleLine_label.Font = new System.Drawing.Font("Consolas", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._singleLine_label.Location = new System.Drawing.Point(0, 50);
            this._singleLine_label.Name = "_singleLine_label";
            this._singleLine_label.Size = new System.Drawing.Size(214, 66);
            this._singleLine_label.TabIndex = 7;
            this._singleLine_label.Text = "12x12=";
            // 
            // _color_panel
            // 
            this._color_panel.Controls.Add(this._entry_textbox);
            this._color_panel.Location = new System.Drawing.Point(21, 122);
            this._color_panel.Name = "_color_panel";
            this._color_panel.Size = new System.Drawing.Size(164, 71);
            this._color_panel.TabIndex = 5;
            // 
            // _winnerTrophyPictureBox
            // 
            this._winnerTrophyPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("_winnerTrophyPictureBox.Image")));
            this._winnerTrophyPictureBox.Location = new System.Drawing.Point(75, 3);
            this._winnerTrophyPictureBox.Name = "_winnerTrophyPictureBox";
            this._winnerTrophyPictureBox.Size = new System.Drawing.Size(161, 227);
            this._winnerTrophyPictureBox.TabIndex = 7;
            this._winnerTrophyPictureBox.TabStop = false;
            this._winnerTrophyPictureBox.Visible = false;
            // 
            // _flash
            // 
            this._flash.AutoSize = true;
            this._flash.BackColor = System.Drawing.Color.Transparent;
            this._flash.Location = new System.Drawing.Point(44, 411);
            this._flash.Name = "_flash";
            this._flash.Size = new System.Drawing.Size(214, 37);
            this._flash.TabIndex = 6;
            // 
            // MultiMathPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._winnerTrophyPictureBox);
            this.Controls.Add(this._flash);
            this.Controls.Add(this._container_panel);
            this.Name = "MultiMathPanel";
            this.Size = new System.Drawing.Size(309, 451);
            this.Resize += new System.EventHandler(this.MultiMathPanel_Resize);
            this._container_panel.ResumeLayout(false);
            this._container_panel.PerformLayout();
            this._color_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._winnerTrophyPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _a_label;
        private System.Windows.Forms.Label _b_label;
        private System.Windows.Forms.Label _operand_label;
        private System.Windows.Forms.Panel _line_panel;
        private System.Windows.Forms.Label _entry_textbox;
        private System.Windows.Forms.Panel _container_panel;
        private System.Windows.Forms.Panel _color_panel;
        private Flash _flash;
        private System.Windows.Forms.Label _singleLine_label;
        private System.Windows.Forms.PictureBox _winnerTrophyPictureBox;
    }
}
