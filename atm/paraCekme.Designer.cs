namespace atm
{
    partial class paraCekme
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
            this.cikisBtn = new System.Windows.Forms.PictureBox();
            this.tcLabel = new System.Windows.Forms.Label();
            this.miktarTxt = new System.Windows.Forms.TextBox();
            this.tcBackground = new System.Windows.Forms.PictureBox();
            this.girisBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cikisBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // cikisBtn
            // 
            this.cikisBtn.BackColor = System.Drawing.Color.Transparent;
            this.cikisBtn.BackgroundImage = global::atm.Properties.Resources.cikis;
            this.cikisBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cikisBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikisBtn.Location = new System.Drawing.Point(339, 336);
            this.cikisBtn.Name = "cikisBtn";
            this.cikisBtn.Size = new System.Drawing.Size(200, 69);
            this.cikisBtn.TabIndex = 21;
            this.cikisBtn.TabStop = false;
            this.cikisBtn.Click += new System.EventHandler(this.cikisBtn_Click);
            // 
            // tcLabel
            // 
            this.tcLabel.AutoSize = true;
            this.tcLabel.BackColor = System.Drawing.Color.Transparent;
            this.tcLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcLabel.ForeColor = System.Drawing.Color.White;
            this.tcLabel.Location = new System.Drawing.Point(194, 131);
            this.tcLabel.Name = "tcLabel";
            this.tcLabel.Size = new System.Drawing.Size(114, 16);
            this.tcLabel.TabIndex = 24;
            this.tcLabel.Text = "Çekilecek Miktar";
            // 
            // miktarTxt
            // 
            this.miktarTxt.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.miktarTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.miktarTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.miktarTxt.Location = new System.Drawing.Point(206, 167);
            this.miktarTxt.MaxLength = 11;
            this.miktarTxt.Name = "miktarTxt";
            this.miktarTxt.Size = new System.Drawing.Size(171, 31);
            this.miktarTxt.TabIndex = 23;
            // 
            // tcBackground
            // 
            this.tcBackground.BackColor = System.Drawing.Color.Transparent;
            this.tcBackground.BackgroundImage = global::atm.Properties.Resources.button;
            this.tcBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tcBackground.Location = new System.Drawing.Point(191, 139);
            this.tcBackground.Name = "tcBackground";
            this.tcBackground.Size = new System.Drawing.Size(199, 91);
            this.tcBackground.TabIndex = 22;
            this.tcBackground.TabStop = false;
            // 
            // girisBtn
            // 
            this.girisBtn.BackColor = System.Drawing.Color.Transparent;
            this.girisBtn.BackgroundImage = global::atm.Properties.Resources.giris;
            this.girisBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.girisBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.girisBtn.Location = new System.Drawing.Point(339, 272);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(200, 69);
            this.girisBtn.TabIndex = 25;
            this.girisBtn.TabStop = false;
            this.girisBtn.Click += new System.EventHandler(this.girisBtn_Click);
            // 
            // paraCekme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::atm.Properties.Resources.atmBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcLabel);
            this.Controls.Add(this.miktarTxt);
            this.Controls.Add(this.tcBackground);
            this.Controls.Add(this.girisBtn);
            this.Controls.Add(this.cikisBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "paraCekme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "paraCekme";
            ((System.ComponentModel.ISupportInitialize)(this.cikisBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cikisBtn;
        private System.Windows.Forms.Label tcLabel;
        private System.Windows.Forms.TextBox miktarTxt;
        private System.Windows.Forms.PictureBox tcBackground;
        private System.Windows.Forms.PictureBox girisBtn;
    }
}