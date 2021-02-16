namespace atm
{
    partial class borcOdeme
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
            this.miktarLabel = new System.Windows.Forms.Label();
            this.miktarTxt = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.PictureBox();
            this.girisBtn = new System.Windows.Forms.PictureBox();
            this.cikisBtn = new System.Windows.Forms.PictureBox();
            this.bakiyeLbl = new System.Windows.Forms.Label();
            this.borcLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cikisBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // miktarLabel
            // 
            this.miktarLabel.AutoSize = true;
            this.miktarLabel.BackColor = System.Drawing.Color.Transparent;
            this.miktarLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.miktarLabel.Location = new System.Drawing.Point(197, 149);
            this.miktarLabel.Name = "miktarLabel";
            this.miktarLabel.Size = new System.Drawing.Size(118, 16);
            this.miktarLabel.TabIndex = 27;
            this.miktarLabel.Text = "Ödenecek Miktar";
            // 
            // miktarTxt
            // 
            this.miktarTxt.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.miktarTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.miktarTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.miktarTxt.Location = new System.Drawing.Point(209, 185);
            this.miktarTxt.MaxLength = 11;
            this.miktarTxt.Name = "miktarTxt";
            this.miktarTxt.Size = new System.Drawing.Size(171, 31);
            this.miktarTxt.TabIndex = 26;
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.Transparent;
            this.button.BackgroundImage = global::atm.Properties.Resources.button;
            this.button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button.Location = new System.Drawing.Point(194, 157);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(199, 91);
            this.button.TabIndex = 25;
            this.button.TabStop = false;
            // 
            // girisBtn
            // 
            this.girisBtn.BackColor = System.Drawing.Color.Transparent;
            this.girisBtn.BackgroundImage = global::atm.Properties.Resources.giris;
            this.girisBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.girisBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.girisBtn.Location = new System.Drawing.Point(342, 281);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(200, 69);
            this.girisBtn.TabIndex = 29;
            this.girisBtn.TabStop = false;
            this.girisBtn.Click += new System.EventHandler(this.girisBtn_Click);
            // 
            // cikisBtn
            // 
            this.cikisBtn.BackColor = System.Drawing.Color.Transparent;
            this.cikisBtn.BackgroundImage = global::atm.Properties.Resources.cikis;
            this.cikisBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cikisBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikisBtn.Location = new System.Drawing.Point(342, 345);
            this.cikisBtn.Name = "cikisBtn";
            this.cikisBtn.Size = new System.Drawing.Size(200, 69);
            this.cikisBtn.TabIndex = 28;
            this.cikisBtn.TabStop = false;
            this.cikisBtn.Click += new System.EventHandler(this.cikisBtn_Click);
            // 
            // bakiyeLbl
            // 
            this.bakiyeLbl.BackColor = System.Drawing.Color.Transparent;
            this.bakiyeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bakiyeLbl.ForeColor = System.Drawing.Color.White;
            this.bakiyeLbl.Location = new System.Drawing.Point(29, 37);
            this.bakiyeLbl.Name = "bakiyeLbl";
            this.bakiyeLbl.Size = new System.Drawing.Size(513, 37);
            this.bakiyeLbl.TabIndex = 30;
            this.bakiyeLbl.Text = "Bakiyeniz: 0 TL";
            // 
            // borcLbl
            // 
            this.borcLbl.BackColor = System.Drawing.Color.Transparent;
            this.borcLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.borcLbl.ForeColor = System.Drawing.Color.White;
            this.borcLbl.Location = new System.Drawing.Point(29, 65);
            this.borcLbl.Name = "borcLbl";
            this.borcLbl.Size = new System.Drawing.Size(513, 37);
            this.borcLbl.TabIndex = 31;
            this.borcLbl.Text = "Borcunuz: 0 TL";
            // 
            // borcOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::atm.Properties.Resources.atmBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.miktarLabel);
            this.Controls.Add(this.miktarTxt);
            this.Controls.Add(this.button);
            this.Controls.Add(this.borcLbl);
            this.Controls.Add(this.bakiyeLbl);
            this.Controls.Add(this.girisBtn);
            this.Controls.Add(this.cikisBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "borcOdeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "borcOdeme";
            ((System.ComponentModel.ISupportInitialize)(this.button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cikisBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label miktarLabel;
        private System.Windows.Forms.TextBox miktarTxt;
        private System.Windows.Forms.PictureBox button;
        private System.Windows.Forms.PictureBox girisBtn;
        private System.Windows.Forms.PictureBox cikisBtn;
        private System.Windows.Forms.Label bakiyeLbl;
        private System.Windows.Forms.Label borcLbl;
    }
}