namespace atm
{
    partial class limitTanimlama
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.girisBtn = new System.Windows.Forms.PictureBox();
            this.cikisBtn = new System.Windows.Forms.PictureBox();
            this.limitLbl = new System.Windows.Forms.Label();
            this.maksLimitLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cikisBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // miktarLabel
            // 
            this.miktarLabel.AutoSize = true;
            this.miktarLabel.BackColor = System.Drawing.Color.Transparent;
            this.miktarLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.miktarLabel.Location = new System.Drawing.Point(45, 263);
            this.miktarLabel.Name = "miktarLabel";
            this.miktarLabel.Size = new System.Drawing.Size(172, 16);
            this.miktarLabel.TabIndex = 30;
            this.miktarLabel.Text = "Belirlemek istediğiniz limit";
            // 
            // miktarTxt
            // 
            this.miktarTxt.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.miktarTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.miktarTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.miktarTxt.Location = new System.Drawing.Point(57, 299);
            this.miktarTxt.MaxLength = 11;
            this.miktarTxt.Name = "miktarTxt";
            this.miktarTxt.Size = new System.Drawing.Size(171, 31);
            this.miktarTxt.TabIndex = 29;
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.Transparent;
            this.button.BackgroundImage = global::atm.Properties.Resources.button;
            this.button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button.Location = new System.Drawing.Point(42, 271);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(199, 91);
            this.button.TabIndex = 28;
            this.button.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::atm.Properties.Resources.button;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(42, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 91);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(45, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Belirlenebilecek Maks. Limit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(45, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Limitiniz";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::atm.Properties.Resources.button;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(42, 77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(199, 91);
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // girisBtn
            // 
            this.girisBtn.BackColor = System.Drawing.Color.Transparent;
            this.girisBtn.BackgroundImage = global::atm.Properties.Resources.giris;
            this.girisBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.girisBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.girisBtn.Location = new System.Drawing.Point(344, 286);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(200, 69);
            this.girisBtn.TabIndex = 36;
            this.girisBtn.TabStop = false;
            this.girisBtn.Click += new System.EventHandler(this.girisBtn_Click);
            // 
            // cikisBtn
            // 
            this.cikisBtn.BackColor = System.Drawing.Color.Transparent;
            this.cikisBtn.BackgroundImage = global::atm.Properties.Resources.cikis;
            this.cikisBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cikisBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikisBtn.Location = new System.Drawing.Point(344, 350);
            this.cikisBtn.Name = "cikisBtn";
            this.cikisBtn.Size = new System.Drawing.Size(200, 69);
            this.cikisBtn.TabIndex = 35;
            this.cikisBtn.TabStop = false;
            this.cikisBtn.Click += new System.EventHandler(this.cikisBtn_Click);
            // 
            // limitLbl
            // 
            this.limitLbl.BackColor = System.Drawing.Color.Transparent;
            this.limitLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.limitLbl.ForeColor = System.Drawing.Color.White;
            this.limitLbl.Image = global::atm.Properties.Resources.button;
            this.limitLbl.Location = new System.Drawing.Point(51, 96);
            this.limitLbl.Name = "limitLbl";
            this.limitLbl.Size = new System.Drawing.Size(183, 52);
            this.limitLbl.TabIndex = 40;
            this.limitLbl.Text = "0 TL";
            this.limitLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maksLimitLbl
            // 
            this.maksLimitLbl.BackColor = System.Drawing.Color.Transparent;
            this.maksLimitLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maksLimitLbl.ForeColor = System.Drawing.Color.White;
            this.maksLimitLbl.Image = global::atm.Properties.Resources.button;
            this.maksLimitLbl.Location = new System.Drawing.Point(51, 193);
            this.maksLimitLbl.Name = "maksLimitLbl";
            this.maksLimitLbl.Size = new System.Drawing.Size(183, 52);
            this.maksLimitLbl.TabIndex = 41;
            this.maksLimitLbl.Text = "0 TL";
            this.maksLimitLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // limitTanimlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::atm.Properties.Resources.atmBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maksLimitLbl);
            this.Controls.Add(this.limitLbl);
            this.Controls.Add(this.girisBtn);
            this.Controls.Add(this.cikisBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.miktarLabel);
            this.Controls.Add(this.miktarTxt);
            this.Controls.Add(this.button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "limitTanimlama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "limitTanimlama";
            ((System.ComponentModel.ISupportInitialize)(this.button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cikisBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label miktarLabel;
        private System.Windows.Forms.TextBox miktarTxt;
        private System.Windows.Forms.PictureBox button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox girisBtn;
        private System.Windows.Forms.PictureBox cikisBtn;
        private System.Windows.Forms.Label limitLbl;
        private System.Windows.Forms.Label maksLimitLbl;
    }
}