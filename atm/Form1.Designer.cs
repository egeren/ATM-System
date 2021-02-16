
namespace atm
{
    partial class girisForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(girisForm));
            this.kartLabel = new System.Windows.Forms.Label();
            this.tcBackground = new System.Windows.Forms.PictureBox();
            this.sifreBackground = new System.Windows.Forms.PictureBox();
            this.tcTxt = new System.Windows.Forms.TextBox();
            this.sifreTxt = new System.Windows.Forms.TextBox();
            this.girisBtn = new System.Windows.Forms.PictureBox();
            this.cikisBtn = new System.Windows.Forms.PictureBox();
            this.tcLabel = new System.Windows.Forms.Label();
            this.sifreLabel = new System.Windows.Forms.Label();
            this.kartBtn = new System.Windows.Forms.PictureBox();
            this.kayitBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tcBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sifreBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cikisBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // kartLabel
            // 
            this.kartLabel.AutoSize = true;
            this.kartLabel.BackColor = System.Drawing.Color.Transparent;
            this.kartLabel.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kartLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.kartLabel.Location = new System.Drawing.Point(89, 62);
            this.kartLabel.Name = "kartLabel";
            this.kartLabel.Size = new System.Drawing.Size(425, 39);
            this.kartLabel.TabIndex = 0;
            this.kartLabel.Text = "Lütfen kartınızı yerleştiriniz...";
            // 
            // tcBackground
            // 
            this.tcBackground.BackColor = System.Drawing.Color.Transparent;
            this.tcBackground.BackgroundImage = global::atm.Properties.Resources.button;
            this.tcBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tcBackground.Location = new System.Drawing.Point(200, 85);
            this.tcBackground.Name = "tcBackground";
            this.tcBackground.Size = new System.Drawing.Size(199, 91);
            this.tcBackground.TabIndex = 2;
            this.tcBackground.TabStop = false;
            this.tcBackground.Visible = false;
            // 
            // sifreBackground
            // 
            this.sifreBackground.BackColor = System.Drawing.Color.Transparent;
            this.sifreBackground.BackgroundImage = global::atm.Properties.Resources.button;
            this.sifreBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sifreBackground.Location = new System.Drawing.Point(200, 161);
            this.sifreBackground.Name = "sifreBackground";
            this.sifreBackground.Size = new System.Drawing.Size(199, 91);
            this.sifreBackground.TabIndex = 3;
            this.sifreBackground.TabStop = false;
            this.sifreBackground.Visible = false;
            // 
            // tcTxt
            // 
            this.tcTxt.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tcTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tcTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcTxt.Location = new System.Drawing.Point(215, 113);
            this.tcTxt.MaxLength = 11;
            this.tcTxt.Name = "tcTxt";
            this.tcTxt.Size = new System.Drawing.Size(171, 31);
            this.tcTxt.TabIndex = 4;
            this.tcTxt.Visible = false;
            // 
            // sifreTxt
            // 
            this.sifreTxt.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.sifreTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sifreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreTxt.Location = new System.Drawing.Point(215, 191);
            this.sifreTxt.MaxLength = 11;
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.PasswordChar = '*';
            this.sifreTxt.Size = new System.Drawing.Size(171, 31);
            this.sifreTxt.TabIndex = 5;
            this.sifreTxt.Visible = false;
            // 
            // girisBtn
            // 
            this.girisBtn.BackColor = System.Drawing.Color.Transparent;
            this.girisBtn.BackgroundImage = global::atm.Properties.Resources.giris;
            this.girisBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.girisBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.girisBtn.Location = new System.Drawing.Point(41, 345);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(200, 69);
            this.girisBtn.TabIndex = 6;
            this.girisBtn.TabStop = false;
            this.girisBtn.Visible = false;
            this.girisBtn.Click += new System.EventHandler(this.girisBtn_Click);
            // 
            // cikisBtn
            // 
            this.cikisBtn.BackColor = System.Drawing.Color.Transparent;
            this.cikisBtn.BackgroundImage = global::atm.Properties.Resources.cikis;
            this.cikisBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cikisBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikisBtn.Location = new System.Drawing.Point(364, 345);
            this.cikisBtn.Name = "cikisBtn";
            this.cikisBtn.Size = new System.Drawing.Size(200, 69);
            this.cikisBtn.TabIndex = 7;
            this.cikisBtn.TabStop = false;
            this.cikisBtn.Click += new System.EventHandler(this.cikisBtn_Click);
            // 
            // tcLabel
            // 
            this.tcLabel.AutoSize = true;
            this.tcLabel.BackColor = System.Drawing.Color.Transparent;
            this.tcLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcLabel.Location = new System.Drawing.Point(203, 77);
            this.tcLabel.Name = "tcLabel";
            this.tcLabel.Size = new System.Drawing.Size(96, 16);
            this.tcLabel.TabIndex = 8;
            this.tcLabel.Text = "T.C. Kimlik No";
            this.tcLabel.Visible = false;
            // 
            // sifreLabel
            // 
            this.sifreLabel.AutoSize = true;
            this.sifreLabel.BackColor = System.Drawing.Color.Transparent;
            this.sifreLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreLabel.Location = new System.Drawing.Point(203, 160);
            this.sifreLabel.Name = "sifreLabel";
            this.sifreLabel.Size = new System.Drawing.Size(38, 16);
            this.sifreLabel.TabIndex = 9;
            this.sifreLabel.Text = "Şifre";
            this.sifreLabel.Visible = false;
            // 
            // kartBtn
            // 
            this.kartBtn.BackColor = System.Drawing.Color.Transparent;
            this.kartBtn.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.kartBtn.Location = new System.Drawing.Point(678, 111);
            this.kartBtn.Name = "kartBtn";
            this.kartBtn.Size = new System.Drawing.Size(134, 99);
            this.kartBtn.TabIndex = 10;
            this.kartBtn.TabStop = false;
            this.kartBtn.Click += new System.EventHandler(this.kartBtn_Click_1);
            // 
            // kayitBtn
            // 
            this.kayitBtn.BackColor = System.Drawing.Color.Transparent;
            this.kayitBtn.BackgroundImage = global::atm.Properties.Resources.kayitOl;
            this.kayitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.kayitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kayitBtn.Location = new System.Drawing.Point(41, 270);
            this.kayitBtn.Name = "kayitBtn";
            this.kayitBtn.Size = new System.Drawing.Size(200, 69);
            this.kayitBtn.TabIndex = 11;
            this.kayitBtn.TabStop = false;
            this.kayitBtn.Visible = false;
            this.kayitBtn.Click += new System.EventHandler(this.kayitBtn_Click);
            // 
            // girisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 454);
            this.Controls.Add(this.kayitBtn);
            this.Controls.Add(this.kartBtn);
            this.Controls.Add(this.sifreLabel);
            this.Controls.Add(this.tcLabel);
            this.Controls.Add(this.cikisBtn);
            this.Controls.Add(this.girisBtn);
            this.Controls.Add(this.sifreTxt);
            this.Controls.Add(this.tcTxt);
            this.Controls.Add(this.sifreBackground);
            this.Controls.Add(this.tcBackground);
            this.Controls.Add(this.kartLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = global::atm.Properties.Resources.atmIcon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "girisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Koç Bank";
            this.Load += new System.EventHandler(this.girisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tcBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sifreBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cikisBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kartLabel;
        private System.Windows.Forms.PictureBox tcBackground;
        private System.Windows.Forms.PictureBox sifreBackground;
        private System.Windows.Forms.TextBox tcTxt;
        private System.Windows.Forms.TextBox sifreTxt;
        private System.Windows.Forms.PictureBox girisBtn;
        private System.Windows.Forms.PictureBox cikisBtn;
        private System.Windows.Forms.Label tcLabel;
        private System.Windows.Forms.Label sifreLabel;
        private System.Windows.Forms.PictureBox kartBtn;
        private System.Windows.Forms.PictureBox kayitBtn;
    }
}

