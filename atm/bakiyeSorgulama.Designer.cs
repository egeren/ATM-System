namespace atm
{
    partial class bakiyeSorgulama
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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cikisBtn = new System.Windows.Forms.PictureBox();
            this.bakiyeLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cikisBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(196, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Bakiyeniz";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::atm.Properties.Resources.button;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(193, 144);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(199, 91);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // cikisBtn
            // 
            this.cikisBtn.BackColor = System.Drawing.Color.Transparent;
            this.cikisBtn.BackgroundImage = global::atm.Properties.Resources.cikis;
            this.cikisBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cikisBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikisBtn.Location = new System.Drawing.Point(341, 348);
            this.cikisBtn.Name = "cikisBtn";
            this.cikisBtn.Size = new System.Drawing.Size(200, 69);
            this.cikisBtn.TabIndex = 38;
            this.cikisBtn.TabStop = false;
            this.cikisBtn.Click += new System.EventHandler(this.cikisBtn_Click);
            // 
            // bakiyeLbl
            // 
            this.bakiyeLbl.BackColor = System.Drawing.Color.Transparent;
            this.bakiyeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bakiyeLbl.ForeColor = System.Drawing.Color.White;
            this.bakiyeLbl.Image = global::atm.Properties.Resources.button;
            this.bakiyeLbl.Location = new System.Drawing.Point(199, 163);
            this.bakiyeLbl.Name = "bakiyeLbl";
            this.bakiyeLbl.Size = new System.Drawing.Size(183, 52);
            this.bakiyeLbl.TabIndex = 39;
            this.bakiyeLbl.Text = "0 TL";
            this.bakiyeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bakiyeSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::atm.Properties.Resources.atmBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bakiyeLbl);
            this.Controls.Add(this.cikisBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bakiyeSorgulama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bakiyeSorgulama";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cikisBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox cikisBtn;
        private System.Windows.Forms.Label bakiyeLbl;
    }
}